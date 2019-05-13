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

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();
                ret.AppendFormat("->{0}", node.Data.ToString());

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }

            return ret.ToString();
        }

        /// <summary>
        /// 二叉树查找节点
        /// </summary>
        /// <param name="data"></param>
        /// <param name="root"></param>
        /// <returns></returns>
        public static Node<T> Find<T>(Node<T> root, T data)
        {
            if (root == null)
            {
                return null;
            }

            Node<T> node = root;
            while (node != null)
            {
                if (node.Data.Equals(data))
                {
                    return node;
                }

                if (data is int)
                {
                    int? dInt = data as int?;
                    int? nInt = node.Data as int?;
                    if (dInt < nInt)
                    {
                        node = node.Left;
                    }
                    else
                    {
                        node = node.Right;
                    }
                }
                else
                {
                    Node<T> lNode = null, rNode = null;
                    if (node.Left != null)
                    {
                        lNode = Find(node.Left, data);
                    }
                    if (lNode == null && node.Right != null)
                    {
                        rNode = Find(node.Right, data);
                    }

                    if (lNode != null)
                    {
                        return lNode;
                    }
                    else if (rNode != null)
                    {
                        return rNode;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// 二叉树插入节点
        /// </summary>
        /// <param name="root"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Node<int> Insert(Node<int> root, int data)
        {
            if (root == null)
            {
                root = new Node<int>(data);
                return null;
            }

            Node<int> p = root;
            while(p != null)
            {
                if (p.Data > data)
                {
                    if (p.Left == null)
                    {
                        p.Left = new Node<int>(data);
                        return p.Left;
                    }
                    p = p.Left;
                }
                else if (p.Data < data)
                {
                    if (p.Right == null)
                    {
                        p.Right = new Node<int>(data);
                        return p.Right;
                    }
                    p = p.Right;
                }
                else
                {
                    return null;
                }
            }

            return null;
        }

        /// <summary>
        /// 二叉树删除节点
        /// </summary>
        /// <param name="root"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool Delete(Node<int> root, int data)
        {
            if (root == null)
            {
                return false;
            }

            Node<int> nodeParent = null;
            Node<int> node = root;
            while (node != null && node.Data != data)
            {
                nodeParent = node;
                if (node.Data > data)
                {
                    node = node.Left;
                }
                else
                {
                    node = node.Right;
                }
            }
            if (node == null)
            {
                return false;//没有找到
            }

            //待删节点有左右子节点
            if (node.Left != null && node.Right != null)
            {
                Node<int> minNodeParent = node;
                Node<int> minNode = node.Right;
                //取右分支的最小节点
                while(minNode.Left != null)
                {
                    minNodeParent = minNode;
                    minNode = minNode.Left;
                }
                //右分支最小节点替换待删节点
                node.Data = minNode.Data;
                //右分支最小节点变成待删节点
                nodeParent = minNodeParent;
                node = minNode;
            }

            Node<int> nodeChild = null;
            if (node.Left != null)
            {
                nodeChild = node.Left;
            }
            else if (node.Right != null)
            {
                nodeChild = node.Right; 
            }

            if (nodeParent == null)
            {
                root = null;
                return true;
            }
            else if (nodeParent.Left == node)
            {
                nodeParent.Left = nodeChild;
                return true;
            }
            else if (nodeParent.Right == node)
            {
                nodeParent.Right = nodeChild;
                return true;
            }

            return false;
        }

        /// <summary>
        /// 返回节点高度
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int Height<T>(Node<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.Left == null && node.Right == null)
            {
                return 0;
            }

            return Math.Max(Height(node.Left), Height(node.Right)) + 1;
        }
    }
}
