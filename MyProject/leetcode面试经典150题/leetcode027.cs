public class Solution027 {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;  // 计数器
        int n = nums.Length;

        for (int i = 0; i < n; i++) {
            if (nums[i] != val) {  // 如果元素不等于val
                nums[k] = nums[i];  // 将不等于val的元素移到前面
                k++;  // 增加计数器
            }
        }

        // 遍历完后，数组前k个元素就是不等于val的元素，剩下的部分可以忽略
        return k;  // 返回不等于val的元素个数
    }
}