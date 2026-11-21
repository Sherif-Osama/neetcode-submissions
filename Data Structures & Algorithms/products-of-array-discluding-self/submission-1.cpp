class Solution {
   public:
    vector<int> productExceptSelf(vector<int>& nums) {
        vector<int> Prefix(nums.size(), 0);

        Prefix[0] = 1;

        for (int i = 1; i < nums.size(); i++) Prefix[i] = Prefix[i - 1] * nums[i - 1];

        int Suffix = 1;

        for (int i = nums.size() - 1; i >= 0; i--) {
            Prefix[i] *= Suffix;

            Suffix *= nums[i];
        }

        return Prefix;
    }
};
