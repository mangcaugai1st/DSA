import math
import os
import random
import re
import sys

def miniMaxSum(arr):
    arr.sort();
    sum = 0;
    for i in range(0, 5):
        sum += arr[i]
     
    minSum = sum - arr[len(arr) - 1]
    maxSum = sum - arr[0]
    
    print(f"{minSum} {maxSum}")
    
arr = [7, 69, 2, 221, 8974]
miniMaxSum(arr)


