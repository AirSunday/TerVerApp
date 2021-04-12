using System;
using System.Collections.Generic;
using System.Linq;

namespace TerVerApp
{
    internal class Calculator
    {
        public List<double> Sequence { get; }

        public Calculator(List<double> sequence)
        {
            Sequence = sequence;
        }

        public string mN (int n)
        {
            var sum = Sequence.Sum(num => Math.Pow(num, n));
            return Math.Round((sum/Sequence.Count),6).ToString();
        }
        
        public string vN (int n)
        {
            var m1 = double.Parse(mN(1));
            var sum = Sequence.Sum(num => Math.Pow(num - m1, n));
            return Math.Round((sum/Sequence.Count),6).ToString();
        }

        public string Sx()
        {
            var m1 = double.Parse(mN(1));
            var sum = Sequence.Sum(num => Math.Pow(num - m1, 2));
            return Math.Round((sum/(Sequence.Count-1)),6).ToString();
        }

        public string XMod()
        {
            return Sequence.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key.ToString();
        }

        public string XMed()
        {
            var seq = Sequence;
            seq.Sort();
            return seq.Count % 2 == 1 ? seq[seq.Count / 2].ToString() : ((seq[seq.Count / 2] + seq[seq.Count / 2 - 1]) / 2).ToString();
        }

        public string Kas()
        {
            return Math.Round((double.Parse(vN(3)) / Math.Pow(Math.Sqrt(double.Parse(vN(2))),3)),6).ToString();
        }

        public string Kex()
        {
            return Math.Round((double.Parse(vN(4)) / Math.Pow(Math.Sqrt(double.Parse(vN(2))), 4) - 3),6).ToString();
        }
    }
}
