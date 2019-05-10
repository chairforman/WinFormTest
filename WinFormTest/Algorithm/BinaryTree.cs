﻿using System;
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
    }
}
