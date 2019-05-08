using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CYQ.Data;
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
            #region CYQ
            //string sql = textBox1.Text;
            //try
            //{
            //    using (MAction action = new MAction(sql))
            //    {

            //    }
            //}
            //catch (Exception ex)
            //{
            //    textBox1.Text = ex.ToString();
            //}
            #endregion

            #region 算法

            #region 快排+归并
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
            #endregion

            #region 跳表
            //var sl = new SkipList(4);
            //sl.Insert(1);
            //sl.Insert(10);
            //sl.Insert(2);
            //sl.Insert(9);
            //sl.Insert(3);
            //sl.Insert(8);
            //sl.Insert(4);
            //sl.Insert(7);
            //sl.Insert(5);
            //sl.Insert(6);
            //textBox1.Text = sl.PrintAll();

            //var node = sl.Find(6);
            //textBox1.Text += "\r\n" +  node.ToString();

            //sl.Delete(6);
            //textBox1.Text += "\r\n" + sl.PrintAll();
            #endregion

            #region 二叉树
            BinaryTree.Node<string> an = new BinaryTree.Node<string>("A");
            BinaryTree.Node<string> bn = new BinaryTree.Node<string>("B");
            BinaryTree.Node<string> cn = new BinaryTree.Node<string>("C");
            BinaryTree.Node<string> dn = new BinaryTree.Node<string>("D");
            BinaryTree.Node<string> en = new BinaryTree.Node<string>("E");
            BinaryTree.Node<string> fn = new BinaryTree.Node<string>("F");
            BinaryTree.Node<string> gn = new BinaryTree.Node<string>("G");
            an.Left = bn;
            an.Right = cn;
            bn.Left = dn;
            bn.Right = en;
            cn.Left = fn;
            cn.Right = gn;

            textBox1.Text = BinaryTree.PreOrder(an) + "\r\n";
            textBox1.Text += BinaryTree.InOrder(an) + "\r\n";
            textBox1.Text += BinaryTree.PostOrder(an) + "\r\n";
            #endregion

            #endregion
        }
    }
}
