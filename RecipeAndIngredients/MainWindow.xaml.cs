using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecipeAndIngredients
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private static void FilterRecipes_Click(object sender, RoutedEventArgs e)
        {
            var filteredRecipes = recipe.FilterByIngredient(FilterTextBox.Text);
            OutputTextBox.Text = filteredRecipes;
        }
    }

    internal class OutputTextBox
    {
        internal static object Text;
    }

    internal class FilterTextBox
    {
        internal static object Text;
    }

    internal class recipe
    {
        internal static object FilterByIngredient(object text)
        {
            throw new NotImplementedException();
        }
    }
}
