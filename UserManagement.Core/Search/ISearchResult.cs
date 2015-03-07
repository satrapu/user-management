using System.Collections.Generic;

namespace UserManagement.Core.Search
{
    /// <summary>
    /// Represents the outcome of a search operation.
    /// </summary>
    /// <typeparam name="T">The type of the search result item.</typeparam>
    public interface ISearchResult<out T> : IReadOnlyCollection<T>
    {
        /// <summary>
        /// Gets the details needed to paginate through all items matching the search criteria used for this search operation.
        /// </summary>
        IPaginationInfo PaginationInfo { get; }

        /// <summary>
        /// Gets whether there are any items  matching the search criteria used for this search operation.
        /// </summary>
        bool IsEmpty { get; }
    }
}