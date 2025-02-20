# LEETCODE
LeetCode is a popular platform for practicing coding problems, and it features a wide variety of implementations for algorithms like Exponential Search, Binary Search, Two Pointers, and Sliding Window. 

Below is a description of many implementations of these algorithms as seen on LeetCode:

---

### 1. **Exponential Search**
   - **Purpose**: Efficiently search for an element in an unbounded or sorted array.
   - **Implementation**:
     1. Start with a range of size 1 and double it (`i = 1, 2, 4, 8, ...`) until the target is within the range.
     2. Once the range is found, perform a **Binary Search** within that range.
   - **Time Complexity**: O(log n), where `n` is the position of the target.
   - **Use Case**: Ideal for unbounded or infinite arrays.

---

### 2. **Binary Search**
   - **Purpose**: Efficiently search for an element in a sorted array.
   - **Implementation**:
     1. Define `low` and `high` pointers to the start and end of the array.
     2. Calculate `mid = (low + high) // 2`.
     3. Compare the target with the middle element:
        - If equal, return the index.
        - If target < mid, search the left half (`high = mid - 1`).
        - If target > mid, search the right half (`low = mid + 1`).
     4. Repeat until `low` exceeds `high`.
   - **Time Complexity**: O(log n).
   - **Use Case**: Searching in sorted arrays or as a subroutine in other algorithms.

**Problem Solved in Leetcode: **
- https://leetcode.com/problems/binary-search/
- https://leetcode.com/problems/intersection-of-two-arrays/

---

### 3. **Two Pointers**
   - **Purpose**: Solve problems involving pairs, subarrays, or sequences efficiently.
   - **Implementation**:
     1. Use two pointers (e.g., `left` and `right`) to traverse the array or list.
     2. Move the pointers based on specific conditions:
        - Move `left` forward or `right` backward.
        - Adjust pointers to meet a condition (e.g., sum, palindrome, etc.).
   - **Time Complexity**: Typically O(n) for linear traversal.
   - **Use Case**: Problems like finding pairs with a target sum, checking palindromes, or merging sorted arrays.

**Problem Solved in Leetcode: **
   - https://leetcode.com/problems/reverse-words-in-a-string-iii/

---

### 4. **Sliding Window**
   - **Purpose**: Solve problems involving subarrays or subsequences with a fixed or dynamic window size.
   - **Implementation**:
     1. Define a window using two pointers (`left` and `right`).
     2. Expand the window by moving the `right` pointer.
     3. Shrink the window by moving the `left` pointer when a condition is met (e.g., window sum exceeds a limit).
     4. Track the result (e.g., maximum sum, minimum length) during the process.
   - **Time Complexity**: Typically O(n) for linear traversal.
   - **Use Case**: Problems like finding maximum subarray sums, longest substrings with unique characters, or minimum window substrings.

**Problem Solved in Leetcode: **
- https://leetcode.com/problems/maximum-length-substring-with-two-occurrences/  

---

### Summary Table:
| Algorithm          | Purpose                              | Key Steps                                                                 | Time Complexity | Use Case                                   |
|--------------------|--------------------------------------|---------------------------------------------------------------------------|-----------------|-------------------------------------------|
| **Exponential Search** | Search in unbounded/sorted arrays   | Double range, then Binary Search                                         | O(log n)        | Unbounded arrays                          |
| **Binary Search**     | Search in sorted arrays             | Divide array into halves, compare mid                                    | O(log n)        | Sorted arrays                             |
| **Two Pointers**      | Solve pair/subarray problems        | Move two pointers based on conditions                                    | O(n)            | Pairs, palindromes, merged arrays         |
| **Sliding Window**    | Solve subarray/subsequence problems | Expand/shrink window, track result                                       | O(n)            | Maximum sums, unique substrings, etc.    |

These algorithms are fundamental tools for solving a wide range of problems efficiently.
