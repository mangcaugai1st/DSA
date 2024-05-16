using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharp
{

    public class TreeNode 
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode (int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution 
    {
        List<int> result = new List<int>();
        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null) return result;  
            else 
            {
                result.Add(root.val);   
                PreorderTraversal(root.left);
                PreorderTraversal(root.right);
            }
            return result;
        }
    }
    class Program 
    {    
        public static void Main(string[] args)
        {
            TreeNode root = new  TreeNode(1); 
            root.right = new TreeNode(2);   
            root.right.left = new TreeNode(3);
            Solution testcase1 = new Solution();    
            var items = testcase1.PreorderTraversal(root);    
            foreach (var item in items)
            {
                Console.Write(item + " ");
            }
        }
    }
}








