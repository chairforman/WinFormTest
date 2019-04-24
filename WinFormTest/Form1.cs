using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormTest.Algorithm;

namespace WinFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 算法
            //int[] a = { 3, 8, 5, 1, 9, 4, 3, 8, 7, 6, 2, 0 };

            //QuickSort.Sort(a);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    textBox1.Text += a[i] + " ";
            //}

            //textBox1.Text += "\r\n";

            //int[] result = MergeSort.Sort(a);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    textBox1.Text += result[i] + " ";
            //}

            var sl = new SkipList(4);
            sl.Insert(1);
            sl.Insert(10);
            sl.Insert(2);
            sl.Insert(9);
            sl.Insert(3);
            sl.Insert(8);
            sl.Insert(4);
            sl.Insert(7);
            sl.Insert(5);
            sl.Insert(6);
            textBox1.Text = sl.PrintAll();

            var node = sl.Find(6);
            textBox1.Text += "\r\n" +  node.ToString();

            sl.Delete(6);
            textBox1.Text += "\r\n" + sl.PrintAll();

            #endregion
        }
    }
}
