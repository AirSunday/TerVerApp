using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerVerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<double> ParseStandart(bool flag = true)
        {
            try
            {
                string s = txtbxInput.Text;
                List<double> input = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
                if (flag)
                    lblStatus.Text = "Статус: Ооо, повезло, повезло!";
                return input;
            }
            catch
            {
                lblStatus.Text = "Статус: Обычный метод - ошибка. Выбран метод с большими N!";
                rbN.Checked = true;
                rbStandart.Checked = false;
                return ParseManyN(false);
            }
        }

        public List<double> ParseManyN(bool flag = true)
        {
            try { 
                string s = txtbxInput.Text;
                List<double> input = new List<double>();
                List<string> str = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var word in str)
                {
                    List<double> str2 = word.Split(new char[] { ':' }).Select(double.Parse).ToList();
                    for(int i = 0; i < str2[1]; i++)
                    {
                        input.Add(str2[0]);
                    }
                }
                if(flag)
                    lblStatus.Text = "Статус: Ооо, повезло, повезло!";
                return input;
            }
            catch
            {
                lblStatus.Text = "Статус: При больших N - ошибка. Выбран обычный метод!";
                rbN.Checked = false;
                rbStandart.Checked = true;
                return ParseStandart(false);
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calculator calc;
            if (rbStandart.Checked)
                calc = new Calculator(ParseStandart());
            else
                calc = new Calculator(ParseManyN());

            // Выборочный начальный момент n-ого порядка
            txtbxM1.Text = calc.mN(1);
            txtbxM2.Text = calc.mN(2);
            txtbxM3.Text = calc.mN(3);
            txtbxM4.Text = calc.mN(4);

            // Выборочный центральный момент n-ого порядка
            txtbxV2.Text = calc.vN(2);
            txtbxV3.Text = calc.vN(3);
            txtbxV4.Text = calc.vN(4);
            txtbxV5.Text = calc.vN(5);

            // Оценка Дисперсии
            txtbxSx.Text = calc.Sx();

            // Мода и Медиана
            txtbxMed.Text = calc.XMed();
            txtbxMod.Text = calc.XMod();

            // Коэф. Ас. и Екс.
            txtbxKas.Text = calc.Kas();
            txtbxKex.Text = calc.Kex();

            // Вариационный ряд
            var seq = calc.Sequence;
            seq.Sort();
            txtbxVarSeq.Text = string.Join(" ", seq.ToArray());
        }
    }
}
