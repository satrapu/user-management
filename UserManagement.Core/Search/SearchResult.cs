using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UserManagement.Core.Search
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SearchResult<T> : ReadOnlyCollection<T>, ISearchResult<T>
    {
        public SearchResult(SearchCriteria searchCriteria, IList<T> list, long totalCount) : base(list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }

            IsEmpty = list.Count == 0;
            PaginationInfo = new PaginationInfo(searchCriteria.MaxResults, searchCriteria.PageIndex, totalCount);
        }

        public IPaginationInfo PaginationInfo { get; private set; }

        public bool IsEmpty { get; private set; }
    }
}