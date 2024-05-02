#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;
class Solution {
public: 
    bool containsDuplicate(vector<int>& nums){
        sort(nums.begin(), nums.end());
            for (int i = 1; i < nums.size(); ++i) {
                    if (nums[i] == nums[i - 1]) return true;
            }        
        return false;
    }
};    
int main() {
    vector<int> nums = {1,2,3,4};
    Solution obj1;
    string result = obj1.containsDuplicate(nums) == 1 ? "true" : "false";
    cout << result; 
    return 0;
}




