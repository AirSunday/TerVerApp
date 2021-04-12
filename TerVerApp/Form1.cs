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
                s = s.Replace("−", "-");
                List<double> input = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
                if (flag)
                {
                    lblStatus.Text = "Статус: Ооо, повезло, повезло!";
                    lblStatus.ForeColor = Color.Green;
                    txtbxInput.Focus();
                }
                return input;
            }
            catch
            {
                if (!flag)
                {
                    lblStatus.Text = "Статус: Ввод некорректен!";
                    lblStatus.ForeColor = Color.Red;
                    txtbxInput.Focus();
                    return null;
                }
                lblStatus.Text = "Статус: Обычный метод - ошибка. Выбран метод с большими N!";
                lblStatus.ForeColor = Color.Blue;
                txtbxInput.Focus();
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
                if (flag)
                {
                    lblStatus.Text = "Статус: Ооо, повезло, повезло!";
                    lblStatus.ForeColor = Color.Green;
                    txtbxInput.Focus();
                }
                return input;
            }
            catch
            {
                if (!flag)
                {
                    lblStatus.Text = "Статус: Ввод некорректен!";
                    lblStatus.ForeColor = Color.Red;
                    txtbxInput.Focus();
                    return null;
                }
                lblStatus.Text = "Статус: При больших N - ошибка. Выбран обычный метод!";
                lblStatus.ForeColor = Color.Blue;
                txtbxInput.Focus();
                rbN.Checked = false;
                rbStandart.Checked = true;
                return ParseStandart(false);
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            tableGist.Visible = false;
            tableGist.Controls.Clear();
            if (txtbxInput.Text == "")
            {
                lblStatus.Text = "Статус: Ничего не введено!";
                lblStatus.ForeColor = Color.Red;
                txtbxInput.Focus();
                return;
            }
                
            Calculator calc;
            if (rbStandart.Checked)
                calc = new Calculator(ParseStandart());
            else
                calc = new Calculator(ParseManyN());

            if (calc.Sequence == null)
                return;

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

            TableObject tableObject = new TableObject();
            TableClass table = tableObject.CreateTable(seq);
            tableGist.ColumnCount = tableObject.CountColumn;
            tableGist.RowCount = tableObject.CountRow + 1;

            tbxH.Text = (tableObject.CountRow).ToString();
            tbxS.Text = (tableObject.Delt).ToString();

            for (int j = 0; j <= tableObject.CountRow; j++)
            {
                Label label1 = new Label();
                Label label2 = new Label();
                Label label3 = new Label();
                Label label4 = new Label();
                label1.AutoSize = false;
                label2.AutoSize = false;
                label3.AutoSize = false;
                label4.AutoSize = false;
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label2.TextAlign = ContentAlignment.MiddleCenter;
                label3.TextAlign = ContentAlignment.MiddleCenter;
                label4.TextAlign = ContentAlignment.MiddleCenter;
                label1.Dock = DockStyle.Fill;
                label2.Dock = DockStyle.Fill;
                label3.Dock = DockStyle.Fill;
                label4.Dock = DockStyle.Fill;

                if (j == 0)
                {
                    label1.Text = "№";
                    label2.Text = "Интервал";
                    label3.Text = "Частота";
                    label4.Text = "Высота столбца";
                    label1.Font = new Font(label7.Font.Name, 8.25f, label7.Font.Style);
                    label2.Font = new Font(label7.Font.Name, 8.25f, label7.Font.Style);
                    label3.Font = new Font(label7.Font.Name, 8.25f, label7.Font.Style);
                    label4.Font = new Font(label7.Font.Name, 8.25f, label7.Font.Style);

                    tableGist.Controls.Add(label1, 0, 0);
                    tableGist.Controls.Add(label2, 1, 0);
                    tableGist.Controls.Add(label3, 2, 0);
                    tableGist.Controls.Add(label4, 3, 0);
                    continue;
                }

                label1.Text = table.Num[j-1].ToString();
                tableGist.Controls.Add(label1, 0, j);

                if(j != tableObject.CountRow)
                    label2.Text = "[ " + table.Inter[j-1].Key.ToString() + " ; " + table.Inter[j-1].Value.ToString() + " )";
                else
                    label2.Text = "[ " + table.Inter[j-1].Key.ToString() + " ; " + table.Inter[j-1].Value.ToString() + " ]";
                tableGist.Controls.Add(label2, 1, j);

                label3.Text = table.Chast[j-1].ToString();
                tableGist.Controls.Add(label3, 2, j);

                label4.Text = table.Hight[j-1].ToString();
                tableGist.Controls.Add(label4, 3, j);
            }
            tableGist.Visible = true;
        }
    }
}
