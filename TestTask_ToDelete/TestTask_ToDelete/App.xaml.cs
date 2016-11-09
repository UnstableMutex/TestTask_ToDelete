﻿using System.Reflection;
using System.Windows;

namespace TestTask_ToDelete
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MVVMTemplateSelection.TypeSource.AddAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
