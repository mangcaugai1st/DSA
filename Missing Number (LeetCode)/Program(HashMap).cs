namespace dotnet 
{ 
  public class Solution 
  {
    public int MissingNumber(int[] nums)
    {
      Array.Sort(nums);
      Dictionary<int, int> map = new Dictionary<int, int>(); 
      for (int i = 0; i < nums.Length; i++)
      {
        map.Add(i, nums[i]);
      }
      foreach (var pair in map)
      {
        if (pair.Value > pair.Key)
        {
          return pair.Value - 1;
        }
      }
      return nums.Length;
    }
  }
  class Program 
  { 
    static void Main(string[] args)
    {      
      int[] nums = {9,6,4,2,3,5,7,0,1};
      Solution testcase1 = new Solution(); 
      Console.WriteLine(testcase1.MissingNumber(nums));
    }
  } 
}

