using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;

namespace Investment.Persistance.Migrations
{
    public class ScriptGenerator
    {
        public string Run(string from, string to)
        {
            var migrator = new DbMigrator(new Configuration());
            var scriptor = new MigratorScriptingDecorator(migrator);
            var sql = scriptor.ScriptUpdate("", "a");
            //var sql = scriptor.ScriptUpdate("Name-Of-Source-Migration", "Name-Of-Target-Migration");
            return sql;
        }
    }
}
