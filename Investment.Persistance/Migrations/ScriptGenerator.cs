using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;

namespace Investment.Persistance.Migrations
{
    public class ScriptGenerator
    {
        public string Run(string from, string to)
        {
            var configuration = new Configuration();

            //Can set the Target Database to be in another Server or Environment
            //configuration.TargetDatabase =
            //    new DbConnectionInfo("Server=.;Database=Investment;Trusted_Connection=True;",
            //        "System.Data.SqlClient");

            //var context = (InvestmentContext)Activator.CreateInstance(configuration.ContextType);
            var runUpdate = false;

            var migrator = new DbMigrator(configuration);
            
            var scriptor = new MigratorScriptingDecorator(migrator);
            var sql = scriptor.ScriptUpdate("", "");
            //var sql = scriptor.ScriptUpdate("Name-Of-Source-Migration", "Name-Of-Target-Migration");
            //configuration.RunSeedProcess(context);

            if (runUpdate)
            {
                //Can run the update from here
                migrator.Update(); //Could add a "TargetMigration"
            }

            return sql;
        }
    }
}
