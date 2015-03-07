namespace UserManagement.Core.Search
{
    public interface IPaginationInfo
    {
        /// <summary>
        /// Gets the total number of search result items.
        /// </summary>
        long TotalCount { get; }

        /// <summary>
        /// Gets the number of pages containing all search result items.
        /// </summary>
        long PageCount { get; }

        /// <summary>
        /// Gets the maximum amount of search result items to be found on each page.
        /// </summary>
        int MaxResults { get; }

        /// <summary>
        /// Gets the index of the current page containing search result items.
        /// </summary>
        long PageIndex { get; }

        bool HasFirstPage { get; }

        /// <summary>
        /// Gets the index of the first page containing search result items.
        /// </summary>
        long FirstPageIndex { get; }

        bool HasPreviousPage { get; }

        /// <summary>
        /// Gets the index of the previous page containing search result items.
        /// </summary>
        long PreviousPageIndex { get; }

        bool HasNextPage { get; }

        /// <summary>
        /// Gets the index of the next page containing search result items.
        /// </summary>
        long NextPageIndex { get; }

        bool HasLastPage { get; }

        /// <summary>
        /// Gets the index of the last page containing search result items.
        /// </summary>
        long LastPageIndex { get; }
    }
}