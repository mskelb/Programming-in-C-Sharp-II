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
            return animalList.Select(a => a.GetExtraInfo()).ToArray();
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
            animalList.Sort(); 
        }

        public void SortAnimalsBySpecies()
        {
            animalList.Sort(new AnimalSpeciesComparer()); 
        }
    }
}
