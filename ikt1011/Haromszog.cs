using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikt1011
{
    internal class Haromszog
    {
        int aOldal;
        int bOldal;
        int cOldal;

        public Haromszog(int elsoOldal, int masodikOldal, int harmadikOldal)
        {
            this.ElsoOldal1 = elsoOldal;
            this.MasodikOldal1 = masodikOldal;
            this.HarmadikOldal1 = harmadikOldal;
        }
        public int MasodikOldal1 { get => bOldal; set => bOldal = value; }
        public int ElsoOldal1 { get => aOldal; set => aOldal = value; }
        public int HarmadikOldal1 { get => cOldal; set => cOldal = value; }

        public int HaromszogKeruleteP
        {
            get
            {
                if (IsSzerkeszthetoP)

                    return aOldal + bOldal + cOldal;
                else return -1;
            }
        }

        public int HaromszogKeruleteM()
        {
            return aOldal + bOldal + cOldal;
        }
        bool IsSzerkeszthetoP
        {
            get
            {
                if (aOldal + bOldal > cOldal && cOldal + bOldal > aOldal && aOldal + cOldal > bOldal)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string IsDerekszoguM()
        {
            int a = aOldal;
            int b = bOldal;
            int c = cOldal;

            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                return "Derékszögű";
            }
            else
            {
                return "Nem derékszögű";
            }
        }

        public double HaromszogTeruletM()
        {
            if (IsSzerkeszthetoP)
            {
                double s = (double)aOldal + (double)bOldal + (double)cOldal / 2;
                return Math.Sqrt((s - aOldal) * (s - bOldal) * (s - cOldal) * s);
            }
            else
            {
                return -1;
            }
        }


    }
}
