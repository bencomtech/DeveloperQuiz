using System.Data.Entity;

namespace DeveloperQuiz.Entities
{
    public class HengEntities : DbContext
    {
        public HengEntities(string connectionString) : base(connectionString)
        {
        }

        public virtual DbSet<Contract> Contracts { get; set; }
    }
}
