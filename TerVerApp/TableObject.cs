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
        public double Delt { get; private set; }

        public TableClass CreateTable(List<double> varSeq)
        {
            CountRow = Convert.ToInt32(Math.Floor(Math.Log(Convert.ToDouble(varSeq.Count), 2.0))) + 1;

            TableClass Table = new TableClass();
            Table.Num = new int[CountRow];
            Table.Inter = new KeyValuePair<double, double>[CountRow];
            Table.Chast = new int[CountRow];
            Table.Hight = new double[CountRow];

            //TableClass[] Table = {   new int[CountRow],
            //                     new KeyValuePair<double, double>[CountRow], 
            //                     new int[CountRow], 
            //                     new double[CountRow] };

            Delt = (varSeq[varSeq.Count - 1] - varSeq[0]) / CountRow;

            Table.Inter[0] = new KeyValuePair<double, double>(varSeq[0], varSeq[0] + Delt);

            int temp = 0, j;

            for (int i = 0; i < CountRow; i++)
            {
                Table.Num[i] = (i + 1);

                if(i != 0)
                {
                    Table.Inter[i] = new KeyValuePair<double, double>( 
                                    ((KeyValuePair<double, double>)Table.Inter[i-1]).Value, 
                                    ((KeyValuePair<double, double>)Table.Inter[i - 1]).Value + Delt);
                }

                for (j = temp; j < varSeq.Count && varSeq[j] < ((KeyValuePair<double, double>)Table.Inter[i]).Value; j++);
                Table.Chast[i] = j - temp;
                if (i == CountRow - 1) Table.Chast[i]++;
                temp = j;

                Table.Hight[i] = Convert.ToDouble(Table.Chast[i]) / Delt / varSeq.Count;
            }

            return Table;
        }
    }
}
