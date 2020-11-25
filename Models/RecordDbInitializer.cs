using System.Data.Entity;

namespace RandomWordRecord.Models
{
    public class RecordDbInitializer : DropCreateDatabaseAlways<RecordContext>
    {
        protected override void Seed(RecordContext db)
        {
            base.Seed(db);
        }
    }
}