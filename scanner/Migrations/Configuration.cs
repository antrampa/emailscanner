using scanner.Contexts;
using System.Data.Entity.Migrations;

namespace scanner.Migrations
{
    public class Configuration : DbMigrationsConfiguration<MainContext>
    {
        public Configuration()
        {
            //AutomaticMigrationsEnabled = false;
            //AutomaticMigrationDataLossAllowed = false;

            AutomaticMigrationsEnabled = false;

            // register mysql code generator
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(MainContext context)
        {
            base.Seed(context);
        }
    }
}
