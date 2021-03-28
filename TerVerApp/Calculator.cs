using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerVerApp
{
    class Calculator
    {
        public List<double> Sequence { get; set; }

        public Calculator(List<double> sequence)
        {
            Sequence = sequence;
        }

        public string mN (int n)
        {
            double sum = 0;
            foreach (var num in Sequence)
            {
                sum += Math.Pow(num, n);
            }
            return (sum/Sequence.Count).ToString();
        }
        
        public string vN (int n)
        {
            double sum = 0;
            double m1 = double.Parse(mN(1));
            foreach (var num in Sequence)
            {
                sum += Math.Pow(num - m1, n);
            }
            return (sum/Sequence.Count).ToString();
        }

        public string Sx()
        {
            double sum = 0;
            double m1 = double.Parse(mN(1));
            foreach (var num in Sequence)
            {
                sum += Math.Pow(num - m1, 2);
            }
            return (sum/(Sequence.Count-1)).ToString();
        }

        public string XMod()
        {
            return Sequence.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key.ToString();
        }

        public string XMed()
        {
            List<double> seq = Sequence;
            seq.Sort();
            if (seq.Count % 2 == 1)
                return seq[seq.Count / 2].ToString();
            else
            {
                return ((seq[seq.Count / 2] + seq[seq.Count / 2 - 1]) / 2).ToString();
            }
        }

        public string Kas()
        {
            return (double.Parse(vN(3)) / Math.Pow(Math.Sqrt(double.Parse(vN(2))),3)).ToString();
        }

        public string Kex()
        {
            return (double.Parse(vN(4)) / Math.Pow(Math.Sqrt(double.Parse(vN(2))), 4) - 3).ToString();
        }
    }
}
