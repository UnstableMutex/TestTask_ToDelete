using System.Collections.Generic;
using System.Linq;

namespace TestTask_ToDelete.ViewModel
{
    class ProductCategoriesViewModel:VMB
    {
        private ProductCategoryViewModel _selectedCategory;

        public ProductCategoriesViewModel()
        {
            Categories = DB.GetAllProductCategories().Select(x=>new ProductCategoryViewModel(x)).ToList();
        }
        public IEnumerable<ProductCategoryViewModel> Categories { get; private set; }

        public ProductCategoryViewModel SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                RaisePropertyChanged(nameof(SelectedCategory));
            }
        }
    }
}
