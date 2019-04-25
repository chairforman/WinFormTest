using System;
using System.Text;

namespace WinFormTest.Algorithm
{
    /// <summary>
    /// 跳表
    /// </summary>
    public class SkipList
    {
        /// <summary>
        /// 最大层数
        /// </summary>
        private static int MAX_LEVEL = 16;

        /// <summary>
        /// 当前总层数
        /// </summary>
        private int levelCount = 1;

        /// <summary>
        /// 头节点
        /// </summary>
        private Node head = new Node();

        private Random r = new Random();

        #region 构造函数
        public SkipList() { }

        public SkipList(int maxLevel)
        {
            MAX_LEVEL = maxLevel;
        }
        #endregion

        /// <summary>
        /// 查找指定值的节点
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Find(int value)
        {
            Node p = head;
            for (int i = levelCount - 1; i >= 0; i--)
            {
                while (p.forward[i] != null && p.forward[i].Data < value)
                {
                    p = p.forward[i];
                }
            }

            if (p.forward[0] != null && p.forward[0].Data == value)
            {
                return p.forward[0];
            }
            else
            {
                return null;
            }
        }

        public void Insert(int value)
        {
            int level = RandomLevel();//新节点总层数
            Node newNode = new Node(value, level);
            Node[] update = new Node[level];
            Node p = head;
            for (int i = level - 1; i >= 0; i--)
            {
                while (p.forward[i] != null && p.forward[i].Data < value)
                {
                    p = p.forward[i];
                }
                update[i] = p;
            }

            for (int i = 0; i < update.Length; i++)
            {
                newNode.forward[i] = update[i].forward[i];
                update[i].forward[i] = newNode;
            }

            if (levelCount < level)
            {
                levelCount = level;
            }
        }

        public void Delete(int value)
        {
            Node[] update = new Node[levelCount];
            Node p = head;
            for (int i = levelCount - 1; i >= 0; i--)
            {
                while (p.forward[i] != null && p.forward[i].Data < value)
                {
                    p = p.forward[i];
                }
                update[i] = p;
            }

            if (p.forward[0] != null && p.forward[0].Data == value)
            {
                for (int i = 0; i < update.Length; i++)
                {
                    if (update[i].forward[i] != null && update[i].forward[i].Data == value)
                    {
                        update[i].forward[i] = update[i].forward[i].forward[i];
                    }
                }
            }
        }

        /// <summary>
        /// 输出全部节点
        /// </summary>
        /// <returns></returns>
        public string PrintAll()
        {
            Node p = head;
            StringBuilder sb = new StringBuilder();
            do
            {
                sb.Append(p.ToString() + " ");
                p = p.forward[0];
            } while (p != null);
            return sb.ToString();
        }

        /// <summary>
        /// 随机生成节点的总层数
        /// </summary>
        /// <returns></returns>
        private int RandomLevel()
        {
            int ret = 1;
            for (int i = 1; i < MAX_LEVEL; i++)
            {
                if (r.Next() % 2 == 1)
                {
                    ret++;
                }
            }
            return ret;
        }

        public class Node
        {
            private int _data = -1;//初始值
            public int Data
            {
                get { return _data; }
            }

            /// <summary>
            /// 当前节点最高层级
            /// </summary>
            private int _maxLevel = 0;

            /// <summary>
            /// 当前节点在每一层里指向的下一个节点
            /// </summary>
            public Node[] forward = new Node[MAX_LEVEL];

            #region 构造函数
            public Node() { }

            public Node(int data)
            {
                _data = data;
            }

            public Node(int data, int maxLevel)
            {
                _data = data;
                _maxLevel = maxLevel;
            }
            #endregion

            public override string ToString()
            {
                return $"{{ data: {_data}; levels: {_maxLevel} }}";
            }
        }
    }
}
