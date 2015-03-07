using System;

namespace UserManagement.Core.Search
{
    public class PaginationInfo : IPaginationInfo
    {
        public const int DEFAULT_FIRST_PAGE_INDEX = 1;

        public PaginationInfo(int maxResults, long pageIndex, long totalCount)
        {
           if (maxResults < 1)
            {
                throw new ArgumentException("Maximum results must be greater or equal to 1", "maxResults");
            }

            if (pageIndex < 1)
            {
                throw new ArgumentException("Page index must be greater or equal to 1", "pageIndex");
            }

            if (totalCount < 0)
            {
                throw new ArgumentException("Total count must be a positive value", "totalCount");
            }

            FirstPageIndex = DEFAULT_FIRST_PAGE_INDEX;
            MaxResults = maxResults;
            PageIndex = pageIndex;
            TotalCount = totalCount;
            PageCount = TotalCount / MaxResults + (TotalCount % MaxResults > 0 ? 1 : 0);

            if (PageIndex < PageCount)
            {
                HasNextPage = true;
                HasLastPage = true;

                NextPageIndex = PageIndex + 1;
                LastPageIndex = PageCount;
            }
            else if (PageIndex == PageCount)
            {
                HasLastPage = true;
                LastPageIndex = PageCount;
            }

            if (PageIndex > FirstPageIndex)
            {
                HasPreviousPage = true;
                HasFirstPage = true;
                PreviousPageIndex = PageIndex - 1;
            }
        }

        public long TotalCount { get; private set; }

        public long PageCount { get; private set; }

        public int MaxResults { get; private set; }

        public long PageIndex { get; private set; }

        public bool HasFirstPage { get; private set; }

        public long FirstPageIndex { get; private set; }

        public bool HasPreviousPage { get; private set; }

        public long PreviousPageIndex { get; private set; }

        public bool HasNextPage { get; private set; }

        public long NextPageIndex { get; private set; }

        public bool HasLastPage { get; private set; }

        public long LastPageIndex { get; private set; }
    }
}