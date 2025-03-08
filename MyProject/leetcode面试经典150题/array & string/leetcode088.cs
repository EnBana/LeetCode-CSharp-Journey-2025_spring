using System;

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // 将数组nums2从序号0开始复制，覆盖nums1的尾部
        Array.Copy(nums2, 0, nums1, m, n);
        // 内置的timsort进行排序
        Array.Sort(nums1);
    }
}
