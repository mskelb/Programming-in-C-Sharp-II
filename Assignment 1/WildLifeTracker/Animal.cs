using System.ComponentModel;

namespace WildlifeTracker
{
    public abstract class Djur
    {
        private static int nextID = 1;

        public int ID { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Category { get; set; }
        public bool IsDomesticated { get; set; }
        public string ImagePath { get; set; }

        public Djur(string name, int age, string gender, string category, bool isDomesticated)
        {
            ID = nextID++;
            Name = name;
            Age = age;
            Gender = gender;
            Category = category;
            IsDomesticated = isDomesticated;
            ImagePath = null;
        }

        public override string ToString()
        {
            return $"ID: {ID}\r\n" +
                   $"Namn: {Name}\r\n" +
                   $"Ålder: {Age}\r\n" +
                   $"Kön: {Gender}\r\n" +
                   $"Kategori: {Category}\r\n" +
                   $"Tamdjur?: {(IsDomesticated ? "Ja" : "Nej")}\r\n";
        }
    }
}
