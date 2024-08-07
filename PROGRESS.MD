* Problem 14 (easy)
  - June 26, 2024
  - 1 Incorrect submission
  - 21 minutes

* Problem 21 (easy)
  - June 26, 2024
  - 0 Incorrect submissions
  - 21 minutes (including a lot of setup)

* Problem 21 (easy) Solution #2
  - June 26, 2024
  - 0 Incorrect submissions
  - Not timed
  - Beats 58.89% runtime, 77.99% memory

* Problem 88 (easy)
  - June 26, 2024
  - 2 compilation error
  - 2 incorrect submission
  - Gave up on solution - incorrect premise/algorithm, start over.
  - Try #2 June 27, 2024
  - 0 incorrect submissions
  - ~5 minute solution
  - Beats 63.92% runtime, 71.84% memory

* Problem 26 (easy)
  - June 28, 2024
  - 0 errors or incorrect submissions
  - 10 minute solution
  - Beats 33.01% runtime, 83.76% memory

* Problem 80 (Medium) - modified from solution to #26
  - June 28, 2024
  - 0 errors or incorrect submissions
  - 5 minute solution
  - Beats 85.65% runtime, 94.54% memory

* Problem 2347 (Easy) Best poker hand
  - July 2, 2024
  - 0 errors or incorrect submissions
  - 9 minute solution
  - Beats 17.19% runtime, 64.06% memory

* Problem 48 (Medium) Rotate Image
  - July 2, 2024
  - Spent 30 minutes thrashing on the trick before reading comments
  - Once I realized that matrix algebra provided the solution, it was simple enough to transpose and vertically mirror the matrix to obtain the result
  - 0 errors or incorrect submissions
  - ~10 minute programming solution, after failing to come up with the linear algebra solution on my own
  - Beats 14.07% runtime, 27.62% memory
  - Removing functions, beats 56.73% runtime, 87.16% memory. Lesson learned, don't use functions

* Problem 49 (Medium) Group Anagrams
  - July 3, 2024
  - Spent 9 minutes without coming up with an algorithm. Took a break to think while running
  - July 4, 2024
  - 30 minute programming to come up with a working, brute force solution.
  - NOT ACCEPTED due to exceeding the time limit
  - In retrospect, my solution was crunching far too many anagrams, when I only needed to compare 1:1
  - July 5, 2024
  - No need to brute force. I just need to see if the next input is an anagram of the first element in an existing List
  - 14 minute programming to come up with a working solution
  - NOT ACCEPTED due to exceeding the time limit
  - 14 more minutes ACCEPTED
  - Runtime beats 5%, Memory beats 5%... ouch
  - Better solutions store a sorted string for comparison, rather than just the first instance of the anagram encountered

* Problem 53 (Medium) Max subarray
  - July 5, 2024
  - 27 minute programming to come up with a working solution
  - NOT ACCEPTED due to exceeding the time limit
  - Will return later (Update: Done July 15, 2024)

* Problem 28 (Easy) First Occurrence in a string
  - July 6, 2024
  - 9 minutes to create a one-pass solution that was incomplete/incorrect
  - Break for a long run
  - 10 minutes and a couple of edge case failures to create a second one-pass solution
  - Beats 96.52% time, 37.98% memory (I could optimize the storage - using lists)

* Problem 1550 (Easy) Three consecutive odds
  - July 8, 2024
  - 3 minute solution
  - Beats 65.23% runtime, 42.86% memory
  - Easiest problem encountered so far, just a fizzbang

* Problem 3 (Medium) Longest substring without repeating characters
  - July 8, 2024
  - I apparently had issues with this solution in 2022 and wanted to give it a second try
  - 15 minute solution
  - One logical error (resetting length for char outside of current substr)
  - Beats 96.16% runtime, 39.41% memory

* Problem 6 (Medium) Zigzag Conversion
  - July 9, 2024
  - ~18 minute solution
  - One very small/dumb edge case missed (1 < s.Length < numRows caused Index out of range)
  - Beats 77.21% runtime, 90.94% memory

* Problem 1652 (Easy) Defuse the bomb
  - July 9, 2024
  - I apparently had issues with this solution in 2022 and wanted to give it a second try
  - ~30 minute solution
  - Lots of thrashing, NEEDED the whiteboard for this one using basic arithmetic
  - Not an easy problem, probably medium
  - Beats 46.63% runtime, 94.64% memory

* Problem 994 (Medium) Rotting Oranges
  - July 10, 2024
  - A few off-by-one type mistakes along the way cleared up with the debugger
  - ~20-30 minute solution - untimed at dinner
  - Beats 85.01% runtime, 75.71% memory

* problem 215 (Medium) Kth Largest Element
  - July 11, 2024
  - First solution (n^2) exceeded time limit
  - Need to come back with a quicksort / quickselect solution. Burned out thinking about this problem today.
  - Jult 13, 2024
  - After thinking about it for 2 days, I'm going to create 2 solutions:
    - QuickSelect algorithm with random pivot (O(n^2) but average n time complexity)
    - PriorityQueue O(n*logk)
  - PriorityQueue solution was quick and easy (15 minutes)
    - Accepted beats 72.35% runtime, 93.84% memory
  - July 14, 2024
  - QuickSelect algorithm with end pivot done in ~15 minutes, couple mins more for random pivot
  - Beats 5.16% runtime, 54.14% memory

* Problem 871 (Hard) Minimum number of refueling stops
  - July 15, 2024
  - I spent ~2 hours trying to solve this as a graph problem using SSSP, but that was the wrong approach
  - I subsequently created a working solution that stored too many (N^2) values in the heap (out of memory)
  - After reading (aka cheating) a bit, I now know one of the better algorithms to solve this problem:
    - Go as far as you can at any given time
    - Remember the gas stations that you passed
    - If you don't have enough fuel to make it to your destination, add the largest fuel capacity that you have passed
  - New solution written in 10 minutes, accepted on first try
  - 68.42% runtime, 21.05% memory (non-optimized)

* Problem 589 (Easy) N-ary Tree Preorder Traversal
  - July 15, 2024
  - Solved recursively in ~5 minutes
  - Runtime beats 42.52%, memory beats 18.90%
  - Iterative solution in ~5 minutes with Stack
  - Runtime beats 65.35%, memory beats 74.02%

* Problem 53 (Medium) Max subarray
  - July 15, 2024
  - Tried this problem 10 days ago and gave up with an O(n^2) solution that exceeded time limit
  - I read the O(n) solution at that time, but have not practiced it or thought about it for 10 days
  - No issue whatsoever cranking out the default solution in ~10 minutes
  - Beats 87.51% runtime, 36.61% memory

* Problem 141 (Easy) Linked List Cycle
  - July 15, 2024
  - Quick (5 minute) Dictionary solution accepted
  - Beats 25.22% runtime, 5.04% memory
  - Gonna have to optimize this one...
  - Read about Tortoise and Hare algorithm. Keeping it in my toolbox, but not going to spend time writing the solution out

* Problem 20 (Easy) Valid Parens
  - July 16, 2024
  - Just getting reps, this is very easy
  - Quick 5 minute stack solution
  - Under 50% ruintime/memory because algorithm could have terminated earlier

* Problem 703 (Easy) Kth largest element in a stream
  - July 16, 2024
  - Tried to go too fast so I missed some edge cases
  - 5 minute solution, 2 edge cases missed (5 extra minutes to resolve)
  - Beats 97.67% runtime, 87.50% memory

* Problem 665 (Medium) Non-decreasing array
  - July 16, 2024
  - Missed several edge cases on a hard-ish single pass solution
  - Beats 97.14% runtime, 40% memory
  - I should probably start off on some of these algorithms with a worse time-complexity, but 100% working solution

* Problem 155 (Medium) Min Stack
  - July 17, 2024
  - First pass - solved in 10-15 minutes catching all edge cases
  - Beats 57.43% runtime, 6.25% memory
  - The memory evaluation isn't fair. The problem states all operations should be completed in O(1), so I allocated enough memory to not need to grow the stack on Push

* Problem 669 (Medium) Trim Binary Search Tree
  - July 17, 2024
  - First pass - solved in 15 minutes catching all edge cases
  - Beats 92.73% runtime, 9.09% memory
  - There's almost no variation in solutions

* Problem 160 (Easy) Find intersection of linked list
  - July 18, 2024
  - First pass - 7-8 minutes, no errors
  - Beats 54.95% runtime, 6.42% memory
  - Might follow up with challenge to solve with O(n) runtime O(1) memory... not sure on that solution right now
  - Read a hint: Count the number of nodes in each list first, then align the two pointers on distance from end
  - I could write this solution quickly, but no reason to. On to the next one...

* Problem 172 (Medium) Factorial Trailing Zeroes
  - July 19, 2024
  - 30 minute sloppy solution, beats 30.27% runtime, 13.41% memory.
  - There's clearly something I'm missing, in terms of an algorithm for factors of 100, 1000, 10000, etc
  - I started with the obvious (4*5 = 20, 10*x = x0), but when it gets to 625*614! being divisible by 10000 I don't see the trick

* Problem 674 (Easy) Longest continuous increasing subsequence
  - July 19, 2024
  - Bruised ego after the last one. Here to regain some confidence.
  - Quick solution ~5-10 mins, no errors
  - Optimized a couple of times. Can either beat 85%+ on runtime or memory, but not both. Checking in runtime optimized