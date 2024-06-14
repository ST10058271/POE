using RecipeAndIngredientsWPF;
using System;
using System.Windows;

namespace RecipeManagerWPF
{
    public partial class ScaleRecipeWindow : Window
    {
        private Recipe recipe;
        private object ScaleFactor;

        public ScaleRecipeWindow(Recipe recipe)
        {
            InitializeComponent();
            this.recipe = recipe;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Scale_Click(object sender, RoutedEventArgs e)
        {
            var factor = double.Parse(ScaleFactor.Text);
            recipe.ScaleRecipe(factor);
            MessageBox.Show("Recipe scaled.");
            this.Close();
        }
    }
}

