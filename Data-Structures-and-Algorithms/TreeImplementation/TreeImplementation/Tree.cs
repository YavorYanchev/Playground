using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");

            }
            this.Root = new TreeNode<T>(value);
            
        }

        public Tree(T value,params Tree<T>[] children):this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public TreeNode<T> Root{
            get
            {
                return this.root;
            }
            private set
            {
                this.root = value;
            }
        }

        public void TraverseDFSWithStack()
        {
            var stack = new Stack<TreeNode<T>>();
            stack.Push(this.Root);
            while (stack.Count > 0)
            {
                TreeNode<T> currentNode = stack.Pop();
                Console.WriteLine("{0} ",currentNode.Value);
                for (int i = 0; i < currentNode.ChildrenCount; i++)
                {
                    TreeNode<T> childNode = currentNode.GetChild(i);
                    stack.Push(childNode);
                }
            }
        }

        public void TraverseBFS()
        {
            var queue = new Queue<TreeNode<T>>();
            queue.Enqueue(this.Root);
            while (queue.Count > 0)
            {
                TreeNode<T> currentNode = queue.Dequeue();
                Console.WriteLine("{0} ",currentNode.Value);
                for (int i = 0; i < currentNode.ChildrenCount; i++)
                {
                    TreeNode<T> childNode = currentNode.GetChild(i);
                    queue.Enqueue(childNode);
                }

            }
           
        }
    }
}
