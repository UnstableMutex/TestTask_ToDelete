﻿namespace TestTask_ToDelete.ViewModel
{
    class MainViewModel :VMB, IContent
    {
        public MainViewModel()
        {
            Content = new ProductCategoriesViewModel();
        }
        private object _content;

        public object Content
        {
            get { return _content; }
            set
            {
                _content = value;
                RaisePropertyChanged(nameof(Content));
            }
        }
    }
}
