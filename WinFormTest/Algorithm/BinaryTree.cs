using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTest.Algorithm
{
    /// <summary>
    /// 二叉树
    /// </summary>
    public class BinaryTree
    {
        /// <summary>
        /// 二叉树节点
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Node<T>
        {
            public Node<T> Left { get; set; }
            public Node<T> Right { get; set; }
            public T Data { get; set; }

            public Node() { }
            public Node(T data)
            {
                this.Data = data;
            }
        }

        /// <summary>
        /// 前序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static string PreOrder<T>(Node<T> root)
        {
            string ret = string.Empty;

            if (root == null)
            {
                return ret;
            }

            ret += "->" + root.Data.ToString();
            if (root.Left != null)
            {
                ret += PreOrder(root.Left);
            }
            if (root.Right != null)
            {
                ret += PreOrder(root.Right);
            }

            return ret;
        }

        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static string InOrder<T>(Node<T> root)
        {
            string ret = string.Empty;

            if (root == null)
            {
                return ret;
            }

            if (root.Left != null)
            {
                ret += InOrder(root.Left);
            }
            ret += "->" + root.Data.ToString();
            if (root.Right != null)
            {
                ret += InOrder(root.Right);
            }

            return ret;
        }

        /// <summary>
        /// 后序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static string PostOrder<T>(Node<T> root)
        {
            string ret = string.Empty;

            if (root == null)
            {
                return ret;
            }

            if (root.Left != null)
            {
                ret += PostOrder(root.Left);
            }
            if (root.Right != null)
            {
                ret += PostOrder(root.Right);
            }
            ret += "->" + root.Data.ToString();

            return ret;
        }

        /// <summary>
        /// 层级遍历
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>
        public static string LevelOrder<T>(Node<T> root)
        {
            if (root == null)
            {
                return string.Empty;
            }

            StringBuilder ret = new StringBuilder();
            List<List<Node<T>>> treeList = new List<List<Node<T>>>();

            Queue<Node<T>> queue = new Queue<Node<T>>();
            Queue<Node<T>> curQueue = new Queue<Node<T>>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                while (queue.Count > 0)
                {
                    curQueue.Enqueue(queue.Dequeue());
                }

                List<Node<T>> eList = new List<Node<T>>(curQueue.Count);
                while (curQueue.Count > 0)
                {
                    Node<T> node = curQueue.Dequeue();
                    eList.Add(node);

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }
                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }
                if (eList.Count > 0)
                {
                    treeList.Add(eList);
                }
            }

            foreach (var iList in treeList)
            {
                foreach (var item in iList)
                {
                    ret.AppendFormat("->{0}", item.Data.ToString());
                }
            }

            return ret.ToString();
        }
    }
}
