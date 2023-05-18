using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decision_Making_Metods.UnderCertainly;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int rows;
        int columns;
        public Form1()
        {
            InitializeComponent();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rows = Convert.ToInt32(textBox2.Text);
            columns = Convert.ToInt32(textBox3.Text);
            Certainly c=null;
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    c = new Maximax(rows,columns);
                    break;
                case 1:
                    c = new Maximin(rows, columns);
                    break;
                case 2:
                    c = new MiniMax_Regret(rows, columns);
                    break;
                case 3:
                    c = new EquallyLikelyCriterion(rows, columns);
                    break;
                default:
                    label5.Text = "Please Select Correct Method";
                    break;
            }
            string msg=null;
            int[] answer= c?.Solve(out msg);
            textBox1.Text +=$"{msg}\n";
            foreach (var item in answer)
            {
                textBox1.Text += $"{item}\n";
            }


        }
        //private int[,] SetValues(string val)
        //{
        //    string[] values = val.Split(',');
        //    int[,] arr = new int[rows, columns];
        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < columns; j++)
        //        {
        //            arr[i, j] = Convert.ToInt32(values[i]);
        //        }
        //    }

        //}
    }
}
