using System.Data.Entity;

namespace RandomWordRecord.Models
{
    public class RecordContext : DbContext
    {
        public RecordContext() : base("DB")
        {
            
        }
        public DbSet<Record> Records { get; set; }
    }
}