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
    }
}
