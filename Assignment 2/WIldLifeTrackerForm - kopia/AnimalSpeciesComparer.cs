using System.Collections.Generic;

namespace WildlifeTracker
{
    public class AnimalSpeciesComparer : IComparer<Djur>
    {
        public int Compare(Djur x, Djur y)
        {
            return x.GetType().Name.CompareTo(y.GetType().Name);
        }
    }

}
