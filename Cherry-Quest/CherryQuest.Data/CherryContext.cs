namespace CherryQuest.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Migrations;
    using Models;

    public class CherryContext : DbContext
    {
        public CherryContext()
            : base("name=CherryContext")
        {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<CherryContext, Configuration>());
        }

        public virtual IDbSet<Player> Characters { get; set; }
    }
}