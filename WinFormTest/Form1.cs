using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            #region CYQ
            //string sql = "BPMS_Organization";
            //try
            //{

            //    using (MAction action = new MAction(sql, "Conn"))
            //    {
            //        action.Data.Clear();
            //    }

            //    using (MAction action = new MAction(sql, "OldASConn"))
            //    {
            //        action.Data.Clear();
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
            //BinaryTree.Node<string> an = new BinaryTree.Node<string>("A");
            //BinaryTree.Node<string> bn = new BinaryTree.Node<string>("B");
            //BinaryTree.Node<string> cn = new BinaryTree.Node<string>("C");
            //BinaryTree.Node<string> dn = new BinaryTree.Node<string>("D");
            //BinaryTree.Node<string> en = new BinaryTree.Node<string>("E");
            //BinaryTree.Node<string> fn = new BinaryTree.Node<string>("F");
            //BinaryTree.Node<string> gn = new BinaryTree.Node<string>("G");
            //an.Left = bn;
            //an.Right = cn;
            //bn.Left = dn;
            //bn.Right = en;
            //cn.Left = fn;
            //cn.Right = gn;

            //textBox1.Text = BinaryTree.PreOrder(an) + "\r\n";
            //textBox1.Text += BinaryTree.InOrder(an) + "\r\n";
            //textBox1.Text += BinaryTree.PostOrder(an) + "\r\n";
            //textBox1.Text += BinaryTree.LevelOrder(an) + "\r\n";

            //BinaryTree.Node<int> n1 = new BinaryTree.Node<int>(1);
            //BinaryTree.Node<int> n2 = new BinaryTree.Node<int>(2);
            //BinaryTree.Node<int> n3 = new BinaryTree.Node<int>(3);
            //BinaryTree.Node<int> n4 = new BinaryTree.Node<int>(4);
            //BinaryTree.Node<int> n5 = new BinaryTree.Node<int>(5);
            //BinaryTree.Node<int> n6 = new BinaryTree.Node<int>(6);
            //BinaryTree.Node<int> n7 = new BinaryTree.Node<int>(7);
            //n1.Left = n2;
            //n1.Right = n3;
            //n2.Left = n4;
            //n2.Right = n5;
            //n3.Left = n6;
            //n3.Right = n7;

            //BinaryTree.Node<int> root = new BinaryTree.Node<int>(33);
            //BinaryTree.Node<int> n17 = new BinaryTree.Node<int>(17);
            //BinaryTree.Node<int> n50 = new BinaryTree.Node<int>(50);
            //BinaryTree.Node<int> n13 = new BinaryTree.Node<int>(13);
            //BinaryTree.Node<int> n18 = new BinaryTree.Node<int>(18);
            //BinaryTree.Node<int> n34 = new BinaryTree.Node<int>(34);
            //BinaryTree.Node<int> n58 = new BinaryTree.Node<int>(58);
            //BinaryTree.Node<int> n16 = new BinaryTree.Node<int>(16);
            //BinaryTree.Node<int> n25 = new BinaryTree.Node<int>(25);
            //BinaryTree.Node<int> n51 = new BinaryTree.Node<int>(51);
            //BinaryTree.Node<int> n66 = new BinaryTree.Node<int>(66);
            //BinaryTree.Node<int> n19 = new BinaryTree.Node<int>(19);
            //BinaryTree.Node<int> n27 = new BinaryTree.Node<int>(27);
            //n33.Left = n17;
            //n33.Right = n50;
            //n17.Left = n13;
            //n17.Right = n18;
            //n50.Left = n34;
            //n50.Right = n58;
            //n13.Right = n16;
            //n18.Right = n25;
            //n58.Left = n51;
            //n58.Right = n66;
            //n25.Left = n19;
            //n25.Right = n27;

            //BinaryTree.Node<int> node = BinaryTree.Find(n33, 19);
            //if (node  != null)
            //{
            //    textBox1.Text = node.Data.ToString();
            //}
            //else
            //{
            //    textBox1.Text = "null";
            //}

            BinaryTree.Node<int> root = new BinaryTree.Node<int>(33);
            BinaryTree.Insert(root, 16);
            BinaryTree.Insert(root, 50);
            BinaryTree.Insert(root, 13);
            BinaryTree.Insert(root, 18);
            BinaryTree.Insert(root, 34);
            BinaryTree.Insert(root, 58);
            BinaryTree.Insert(root, 15);
            BinaryTree.Insert(root, 17);
            BinaryTree.Insert(root, 25);
            BinaryTree.Insert(root, 51);
            BinaryTree.Insert(root, 66);
            BinaryTree.Insert(root, 19);
            BinaryTree.Insert(root, 27);
            BinaryTree.Insert(root, 55);
            textBox1.Text += BinaryTree.LevelOrder(root) + "\r\n";

            BinaryTree.Delete(root, 13);
            BinaryTree.Delete(root, 18);
            BinaryTree.Delete(root, 55);
            textBox1.Text += BinaryTree.LevelOrder(root) + "\r\n";

            textBox1.Text += BinaryTree.Height(root) + "\r\n";
            #endregion

            #endregion
        }
    }
}
