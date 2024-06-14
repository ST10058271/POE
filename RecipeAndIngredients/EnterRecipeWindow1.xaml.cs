using System;
using System.Windows;

namespace RecipeAndIngredientsWPF

{
    public partial class EnterRecipeWindow : Window
    {
        private Recipe recipe;
        private object IngredientName;
        private object IngredientQuantity;
        private object IngredientUnit;
        private object StepDescription;

        public EnterRecipeWindow(Recipe recipe)
        {
            InitializeComponent();
            this.recipe = recipe;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            var name = IngredientName.Text;
            var quantity = double.Parse(IngredientQuantity.Text);
            var unit = IngredientUnit.Text;
            recipe.AddIngredient(name, quantity, unit);
            MessageBox.Show("Ingredient added.");
        }

        private void AddStep_Click(object sender, RoutedEventArgs e)
        {
            var description = StepDescription.Text;
            recipe.AddStep(description);
            MessageBox.Show("Step added.");
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    internal class Recipe
    {
        internal object Ingredients;

        internal void AddIngredient(object name, double quantity, object unit)
        {
            throw new NotImplementedException();
        }

        internal void AddStep(object description)
        {
            throw new NotImplementedException();
        }

        internal void ScaleRecipe(double factor)
        {
            throw new NotImplementedException();
        }
    }
}
