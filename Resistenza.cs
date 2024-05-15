using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ES_22._34
{
    internal class Resistenza
    {
        public double Valore { get; set; }
        public Resistenza(double valore)
        {
            Valore = valore;
        }
        public static Resistenza operator &(Resistenza r1 , Resistenza r2)
        {
            double Req = r1.Valore + r2.Valore;
            return new Resistenza(Req);
        }
        public static Resistenza operator |(Resistenza r1, Resistenza r2)
        {
            double Req=1/((1/r1.Valore)+(1/r2.Valore));
            return new Resistenza(Req);
        }
        public static bool operator >(Resistenza r1, Resistenza r2)
        {
            return r1.Valore > r2.Valore;
        }
        public static bool operator <(Resistenza r1, Resistenza r2)
        {
            return r1.Valore< r2.Valore;
        }
        public static Resistenza Parse(string s)
        {
            double R = double.Parse(s);
            return new Resistenza(R);
        }
        public override string ToString()
        {
            return Valore.ToString();
        }

    }
}
