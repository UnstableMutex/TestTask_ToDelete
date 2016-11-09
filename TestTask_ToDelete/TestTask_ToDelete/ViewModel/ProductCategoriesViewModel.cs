using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask_ToDelete.Model;

namespace TestTask_ToDelete.ViewModel
{
    class ProductCategoriesViewModel:VMB
    {
        public ProductCategoriesViewModel()
        {
            Categories = DB.GetAllProductCategories().Select(x=>new ProductCategoryViewModel(x)).ToList();
        }
        public IEnumerable<ProductCategoryViewModel> Categories { get; private set; }
        
    }
}
