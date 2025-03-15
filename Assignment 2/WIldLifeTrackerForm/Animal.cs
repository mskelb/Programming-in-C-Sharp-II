using System;
using System.Collections.Generic;

namespace WildlifeTracker
{
    public enum Gender { Hane, Hona, Okänd }
    public enum Category { Däggdjur, Fågel, Insekt }

    public interface IDjur
    {
        int ID { get; }
        int Age { get; set; }
        string Name { get; set; }
        Gender Gender { get; set; }
        Category Category { get; set; }
        bool IsDomesticated { get; set; }
        string ImagePath { get; set; }
        EaterType EaterType { get; set; }
        FoodSchedule GetFoodSchedule();
        string GetExtraInfo();
    }

    public abstract class Djur : IDjur
    {
        private static int nextID = 1;
        public int ID { get; private set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Category Category { get; set; }
        public EaterType EaterType { get; set; }
        public bool IsDomesticated { get; set; }
        public string ImagePath { get; set; }

        public Djur(string name, int age, Gender gender, Category category, EaterType eaterType, bool isDomesticated, string imagePath)
        {
            ID = nextID++;
            Age = age;
            Name = name;
            Gender = gender;
            Category = category;
            EaterType = eaterType;
            IsDomesticated = isDomesticated;
            ImagePath = imagePath;
        }

        public abstract FoodSchedule GetFoodSchedule();

        public virtual string GetExtraInfo()
        {
            return $"ID: {ID}\r\n" +
                   $"Ålder: {Age}\r\n" +
                   $"Namn: {Name}\r\n" +
                   $"Kön: {Gender}\r\n" +
                   $"Kategori: {Category}\r\n" +
                   $"Är jag tam? {(IsDomesticated ? "Ja" : "Nej")}\r\n" +
                   $"{(string.IsNullOrEmpty(ImagePath) ? $"Det finns ännu ingen bild på {Name} :(" : $"Bild på {Name} finns i bildrutan")}\r\n";
        }

        public override string ToString()
        {
            return GetExtraInfo();
        }
    }

}
