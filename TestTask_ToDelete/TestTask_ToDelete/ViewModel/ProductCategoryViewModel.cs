using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using TestTask_ToDelete.Model;

namespace TestTask_ToDelete.ViewModel
{
    class ProductCategoryViewModel : ViewModel<ProductCategory>
    {
        public ProductCategoryViewModel(ProductCategory model) : base(model)
        {

        }

        public string Name => _model.Name;
        MemoryCache mc = MemoryCache.Default;

        IEnumerable<Product> GetProductsCached()
        {
            var key = _model.ID.ToString();

            if (!mc.Contains(key))
            {
                var obj = DB.GetProductsByCategory(_model.ID);
                mc.Add(key, obj, DateTime.Now.AddHours(2));
            }
            return (IEnumerable<Product>) mc.Get(key);
        }

        public IEnumerable<Product> Products
        {
            get { return GetProductsCached(); }

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
