using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharp
{
    public class TreeNode 
    {
        public int val; 
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)   
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution 
    {
        List<int> result = new List<int>();
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null) return result;
            InorderTraversal(root.left);
            result.Add(root.val);
            InorderTraversal(root.right); 
            return result;
        }
    }
    class Program 
    {    
        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);   
            root.left.right = new TreeNode(5);
            root.right.right = new TreeNode(6);
            Solution s = new Solution();
            var l = s.InorderTraversal(root);
            foreach(var x in l)
            {
                Console.Write(x + " ");
            } 
        }
    }
}








