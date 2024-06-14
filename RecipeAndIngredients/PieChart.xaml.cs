using RecipeAndIngredientsWPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace RecipeAndIngredients
{
    /// <summary>
    /// Interaction logic for PieChart.xaml
    /// </summary>
    public partial class PieChart : Window
    {
        public PieChart()
        {
            InitializeComponent();
            using System.Collections.ObjectModel;
            using System.Windows;

namespace RecipeManagerWPF
    {
        public partial class PieChartWindow : Window
        {
            public ObservableCollection<DataPoint> DataPoints { get; set; }

            public PieChartWindow(Recipe recipe)
            {
                InitializeComponent();
                DataPoints = new ObservableCollection<DataPoint>();

                var foodGroups = recipe.Ingredients.GroupBy(i => i.FoodGroup)
                    .Select(g => new DataPoint { Category = g.Key, Value = g.Count() });

                foreach (var dataPoint in foodGroups)
                {
                    DataPoints.Add(dataPoint);
                }

                DataContext = this;
            }

            private void InitializeComponent()
            {
                throw new NotImplementedException();
            }
        }

        public class DataPoint
        {
            public string Category { get; set; }
            public int Value { get; set; }
        }
    }

}
    }
}
