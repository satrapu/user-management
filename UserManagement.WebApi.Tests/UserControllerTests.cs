using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using AttributeRouting.Web.Http.WebHost;
using Autofac;
using Autofac.Extras.Moq;
using Autofac.Integration.WebApi;
using NUnit.Framework;
using UserManagement.Core.DataAccess;
using UserManagement.Core.Search;
using UserManagement.WebApi.Tests.Utilities;

namespace UserManagement.WebApi.Tests
{
    [TestFixture]
    public class UserControllerTests
    {
        [Test]
        public async void Get_WhenUsingValidSearchCriteria_ReturnUsers()
        {
            var searchCriteria = new UserSearchCriteria
            {
                UserNamePattern = "satrapu",
                MaxResults = 5,
                PageIndex = 1
            };

            using (var mock = AutoMock.GetLoose())
            {
                var userSearchResultItems = new List<IUserSearchResultItem>
                {
                    mock.Mock<IUserSearchResultItem>().Object
                };

                var userRepositoryMock = mock.Mock<IUserRepository>();
                userRepositoryMock
                    .Setup(x => x.Get(searchCriteria))
                    .Returns(() => new SearchResult<IUserSearchResultItem>(searchCriteria, userSearchResultItems, userSearchResultItems.Count));

                var builder = new ContainerBuilder();
                //// Solution #1 - builder.RegisterType for the UserController class and builder.RegisterInstance for the mock object
                //builder.RegisterType<UserController>().InstancePerRequest();
                //builder.RegisterInstance(userRepositoryMock.Object).SingleInstance();

                // Solution #2 - call builder.Register
                builder.Register(c => new UserController(userRepositoryMock.Object)).InstancePerRequest();

                using (var container = builder.Build())
                {
                    var httpConfiguration = new HttpConfiguration
                    {
                        DependencyResolver = new AutofacWebApiDependencyResolver(container),
                        IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always
                    };
                    httpConfiguration.Routes.MapHttpAttributeRoutes(config =>
                    {
                        config.InMemory = true;
                        config.AddRoutesFromController<UserController>();
                    });

                    using (var httpServer = new HttpServer(httpConfiguration))
                    {
                        using (var httpClient = new HttpClient(new LoggingHandler(httpServer)))
                        {
                            httpClient.BaseAddress = new Uri("http://localhost:9000");
                            httpClient.DefaultRequestHeaders.Accept.Clear();
                            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                            var response = await httpClient.PostAsJsonAsync("api/users", searchCriteria);
                            var users = response.Content.ReadAsAsync<ISearchResult<IUserSearchResultItem>>().Result;

                            Assert.That(users.Count, Is.GreaterThanOrEqualTo(1), "Expected to find at least one user when searching using valid search criteria");
                        }
                    }
                }
            }
        }
    }
}