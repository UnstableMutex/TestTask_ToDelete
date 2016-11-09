using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace TestTask_ToDelete
{
   public static class Constants
   {
       private const string CS = @"Server=localhost;Database=AdventureWorks2014;Trusted_Connection=True;";
        public static SqlDatabase AdventureWorks { get; } = new SqlDatabase(CS);
   }
}
