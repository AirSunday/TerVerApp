using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerVerApp
{
    class TableObject
    {
        public int CountRow { get; private set; }
        public int CountColumn { get; private set; } = 4;

        public object[,] CreateTable(List<double> varSeq)
        {
            CountRow = Convert.ToInt32(Math.Log(Convert.ToDouble(varSeq.Count), 2.0)) + 1;

            object[,] Table = { { new int[CountRow] },
                                { new KeyValuePair<double, double>[CountRow] }, 
                                { new int[CountRow] }, 
                                { new double[CountRow] } };

            double delt = (varSeq[varSeq.Count - 1] - varSeq[0]) / CountRow;

            Table[1, 0] = new KeyValuePair<double, double>(varSeq[0], varSeq[0] + delt);

            int temp = 0, j;

            for (int i = 0; i < CountRow; i++)
            {
                Table[0, i] = (i + 1);

                if(i != 0)
                {
                    Table[1, i] = new KeyValuePair<double, double>( 
                                    ((KeyValuePair<double, double>)Table[1,i-1]).Value, 
                                    ((KeyValuePair<double, double>)Table[1, i - 1]).Value + delt);
                }

                for (j = temp; varSeq[j] < ((KeyValuePair<double, double>)Table[1, i]).Value; j++);
                Table[2, i] = j - temp + 1;
                temp = j;

                Table[3, i] = Convert.ToDouble(Table[2, i]) / delt / varSeq.Count;
            }

            return Table;
        }
    }
}
