using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace TestTask_ToDelete
{
   public static class Constants
   {
       private const string CS = @"Server=localhost;Database=Database;Trusted_Connection=True;";
        public static SqlDatabase AdventureWorks { get; } = new SqlDatabase(CS);
   }
}
