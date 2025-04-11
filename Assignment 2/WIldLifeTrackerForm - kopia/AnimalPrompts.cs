using System;
using System.ComponentModel;
using System.Reflection;

namespace WildlifeTracker
{
    public enum AnimalPrompts
    {
        [Description("Ange flyghastighet i km/h:")]
        FalkFlyghastighet,

        [Description("Är detta en fridens duva?")]
        DuvaFridensDuva,

        [Description("Ange sötindex (0-10):")]
        KattSötindex,

        [Description("Gillar hunden att leka med bollar?")]
        HundGillarBollar,

        [Description("Ange antalet tänder")]
        Tänder,

        [Description("Ange vingbredd i cm:")]
        FågelVingbredd,

        [Description("Pollinerar insekten blommor?")]
        BiFjärilPollinerar,

        [Description("Är biet gulligt?")]
        BiGulligt,

        [Description("Är fjärilen vacker?")]
        FjärilVacker
    }

    public static class EnumHelper
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
