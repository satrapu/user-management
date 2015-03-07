namespace UserManagement.Core.Search
{
    public abstract class SearchCriteria
    {
        public int MaxResults { get; set; }

        public long PageIndex { get; set; }
    }
}