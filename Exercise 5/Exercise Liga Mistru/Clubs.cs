using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Exercise_Liga_Mistru
{
    public enum FootballClub
    {
        [Description("None")] NONE,
        [Description("FC Porto")] FC_PORTO,
        [Description("Arsenal")] ARSENAL,
        [Description("Real Madrid")] REAL_MADRID,
        [Description("Chelsea")] CHELSEA,
        [Description("Barcelona")] BARCELONA
    };

    static class Clubs
    {
        private static string GetDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((System.ComponentModel.DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }
            return GenericEnum.ToString();
        }

        public static int getCountClubs()
        {
            return Enum.GetNames(typeof(FootballClub)).Length;
        }

        public static string[] getAllNameFootballClub()
        {
            int actualIndex = 0;
            int countClubs = Enum.GetNames(typeof(FootballClub)).Length;
            string[] nameClubs = new string[countClubs];

            foreach (FootballClub colorEnum in Enum.GetValues(typeof(FootballClub)))
            {
                nameClubs[actualIndex++] = colorEnum.GetDescription();
            }

            return nameClubs;
        }
    }
}
