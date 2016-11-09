using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.EnterpriseLibrary.Data;
using TestTask_ToDelete.Model;

namespace TestTask_ToDelete
{
    static class DB
    {

        public static IEnumerable<ProductCategory> GetAllProductCategories()
        {
            const string spName = "Production.ProductCategory_SelectAll";
            return Constants.AdventureWorks.ExecuteSprocAccessor<ProductCategory>(spName).ToList();
        }

        public static IEnumerable<Product> GetProductsByCategory(int id)
        {
            string spName = "Production.Product_SelectByCategory";
            return Constants.AdventureWorks.ExecuteSprocAccessor<Product>(spName, id).ToList();
        }
    }
}
