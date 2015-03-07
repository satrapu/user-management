using System;
using System.Collections.Generic;

namespace UserManagement.Core.Search
{
    public class UserSearchCriteria : SearchCriteria
    {
        public int TenantId { get; set; }

        public string UserNamePattern { get; set; }

        public string FirstMiddleOrLastNamePattern { get; set; }

        public string EmailPattern { get; set; }

        public DateTime? ActiveFrom { get; set; }

        public DateTime? ActiveTo { get; set; }

        public IList<IRole> Roles { get; set; }

        public IList<IPermission> Permissions { get; set; }
    }
}