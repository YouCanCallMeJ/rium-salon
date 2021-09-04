using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiumSalon.JSClasses
{
    class JSUtility
    {
        public static string returnServiceFee(string service)
        {
            switch (service)
            {
                case "Men's Bleaching Color":
                    return "200";
                case "Men's Color":
                    return "100";
                case "Men's Perm":
                    return "140";
                case "Men's Sidedown-Perm":
                    return "50";
                case "Men's Haircut":
                    return "30";
                case "Women's Botox Treatment":
                    return "230";
                case "Women's Balayage, Hightlights, Ombre & Color with Design":
                    return "300";
                case "Women's Root Touch Up (Less than 3cm)":
                    return "60";
                case "Women's Color":
                    return "170";
                case "Women's Root Volume / Bang Perm":
                    return "70";
                case "Women's Straight & Wave Permanent":
                    return "300";
                case "Women's Wave / Straight Permanent":
                    return "300";
                case "Women's Blowdry & Styling":
                    return "40";
                case "Women's Bang Cut":
                    return "10";
                case "Women's Haircut":
                    return "50";

                default:
                    return "";
            }
        }

        public static string returnWorker(string service)
        {
            switch (service)
            {
                case "Men's Bleaching Color":
                    return "Daniel";
                case "Men's Color":
                    return "Daniel";
                case "Men's Perm":
                    return "Daniel";
                case "Men's Sidedown-Perm":
                    return "Daniel";
                case "Men's Haircut":
                    return "Daniel";
                case "Women's Botox Treatment":
                    return "Marie";
                case "Women's Balayage, Hightlights, Ombre & Color with Design":
                    return "Marie";
                case "Women's Root Touch Up (Less than 3cm)":
                    return "Marie";
                case "Women's Color":
                    return "Marie";
                case "Women's Root Volume / Bang Perm":
                    return "Marie";
                case "Women's Straight & Wave Permanent":
                    return "Marie";
                case "Women's Wave / Straight Permanent":
                    return "Marie";
                case "Women's Blowdry & Styling":
                    return "Marie";
                case "Women's Bang Cut":
                    return "Marie";
                case "Women's Haircut":
                    return "Marie";

                default:
                    return "";
            }
        }
    }
}
