using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask_ToDelete.Model;

namespace TestTask_ToDelete.ViewModel
{
    class ProductCategoryViewModel:ViewModel<ProductCategory>
    {
        public ProductCategoryViewModel(ProductCategory model) : base(model)
        {
        }
    }

    class ViewModel<T> : VMB
    {
        protected readonly T _model;

        public ViewModel(T model)
        {
            _model = model;
        }

    }
}
