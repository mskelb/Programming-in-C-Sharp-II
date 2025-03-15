

namespace WildlifeTracker
{
    public enum EaterType
    {
        Carnivore,
        Herbivore,
        Omnivore
    }

    public class FoodSchedule
    {
        private List<string> foodList = new List<string>();

        public void AddFoodItem(string food)
        {
            foodList.Add(food);
        }

        public string[] GetFoodListInfoStrings()
        {
            return foodList.ToArray();
        }
    }
}
