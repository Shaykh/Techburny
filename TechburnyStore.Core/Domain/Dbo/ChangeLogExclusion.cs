namespace TechburnyStore.Core.Domain.Dbo
{
    public class ChangeLogExclusion
    {
        public int? ID { get; set; }

        public string EntityName { get; set; }

        public string PropertyName { get; set; }
    }
}