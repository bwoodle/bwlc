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

# Guide for solving future problems
# Look for signs to identify the class of problem:
#   Recursion, Linear algebra, linked list, search tree
# Identify data structures that will help
#   Dictionary/HashSet (const insertion/lookup), Queue, Stack, List
# Identify any data pre-processing which may help (sorting, etc)
# Write out edge test cases ahead of time (beginning, end, empty, etc)
# Use a whiteboard for notes, not pen+paper

* Problem 53 (Medium) Max subarray
  - July 5, 2024
  - 27 minute programming to come up with a working solution
  - NOT ACCEPTED due to exceeding the time limit
  - Will return later

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