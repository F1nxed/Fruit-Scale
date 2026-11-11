using Fruit_Scale.Data;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;


namespace Fruit_Scale
{
    public sealed partial class MainWindow : Window
    {
        private readonly Random random = new();
        public MainWindow()
        {
            InitializeComponent();

            using (var db = new AppDb())
            {
                db.Database.EnsureCreated();
            }

        }

        private void LoadItems()
        {
            using var db = new AppDb();



        }


        private void admin_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
