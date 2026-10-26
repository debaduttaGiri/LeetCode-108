namespace Leet_108._Convert_Sorted_Array_to_Binary_Search_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5};
            var sol = new Solution();
            TreeNode bst =  sol.SortedArrayToBST(arr);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortBST(nums, 0, nums.Length);
        }
        public TreeNode SortBST(int[] nums, int left, int right)
        {
            
            if (left > right)
                return null;
            int mid = left + (right - left)/2;

            var node = new TreeNode(nums[mid]);

            node.left = SortBST(nums, left, mid - 1);
            node.right = SortBST(nums,mid+1, right);
            return node;
        }
    }
}
