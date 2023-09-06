using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strals_Uzd3
{
    internal class Auto
    {
        private String marka;
        private String modelis;
        private double jauda;
        private double tilpums;
        public string Marka { get => marka; set => marka = value; }
        public double Jauda { get => jauda; set => jauda = value; }
        public double Tilpums { get => tilpums; set => tilpums = value; }
        public string Modelis { get => modelis; set => modelis = value; }

        public Auto(string marka, string modelis, double jauda, double tilpums)
        {
            Marka = marka;
            Modelis = modelis;
            Jauda = jauda;
            Tilpums = tilpums;
        }

        public void PrintIt()
        {
            Console.WriteLine("Marka: " + marka + " Modelis: " + modelis + " Jauda: " + jauda + " Tiplums: " + tilpums);
        }
    }
}
