namespace CQRS.Template.Domain.QueryMapper
{
    public class QueryOptions
    {
        public const int LimitSize = 100;

        public string UserId { get; set; }

        public string SortyBy { get; set; }

        public string Sort { get; set; }

        public int Limit { get; set; } = LimitSize;
    }
}