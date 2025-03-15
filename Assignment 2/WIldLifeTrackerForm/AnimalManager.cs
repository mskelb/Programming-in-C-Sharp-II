using System;
using System.Collections.Generic;
using System.Linq;

namespace WildlifeTracker
{
    public class AnimalManager
    {
        private List<Djur> animalList = new List<Djur>();

        public void Add(Djur animal)
        {
            if (animal != null)
                animalList.Add(animal);
        }

        public string[] GetAnimalInfoStrings()
        {
            return animalList.Select(a => a.ToString()).ToArray();
        }

        public List<Djur> GetAllAnimals()
        {
            return animalList;
        }

        public void Remove(Djur animal)
        {
            if (animal != null)
                animalList.Remove(animal);
        }

        public void SortAnimalsByName()
        {
            animalList = animalList.OrderBy(a => a.Name).ToList();
        }

        public void SortAnimalsByCategory()
        {
            animalList = animalList.OrderBy(a => a.Category).ToList();
        }
    }
}
