using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;
using System.Data.Entity.Infrastructure;

namespace Tache.Models
{
    public class MySqlInitializer : IDatabaseInitializer<EmployeeContext>
    {
        public void InitializeDatabase(EmployeeContext context)
        {
            if (!context.Database.Exists())
            {
                context.Database.Create();
            }
            else
            {
                var migrationHistoryTableExists = ((IObjectContextAdapter)context).ObjectContext.ExecuteStoreQuery<int>(
                    string.Format(
                        "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = {0} AND table_name = '__MigrationHistory'",
                        "[Insert your database schema here - such as 'employee']"
             ));
                if(migrationHistoryTableExists.FirstOrDefault() == 0)
                {
                    context.Database.Delete();
                    context.Database.Create();
                }
            }
        }
    }
}