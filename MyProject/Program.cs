using System;

class Program {
    static void Main() {
        int[] nums1 = {1, 2, 3, 0, 0, 0}; // nums1 长度为 m+n
        int m = 3;
        int[] nums2 = {2, 5, 6};
        int n = 3;

        Solution solution = new Solution();
        solution.Merge(nums1, m, nums2, n);

        Console.WriteLine("Merged Array: " + string.Join(", ", nums1));
    }
}
