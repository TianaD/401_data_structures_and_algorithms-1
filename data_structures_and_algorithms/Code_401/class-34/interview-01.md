# Interview 01

Determine the most common word in a book.

## Specifications

- Read all of the following instructions carefully.
- Act as an interviewer, giving a candidate a code challenge
- Score the candidate according to the [Whiteboard Rubric](https://docs.google.com/spreadsheets/d/1scthkmARfzAFZrSYAp6LA2coOaoWUWbSzMbtIU4jcHw){:target="_blank"}
- You are free to offer suggestions or guidance (and see how they respond), but don't solve it for the candidate.

## Feature Tasks

- Ask the candidate to write a function that determines the most common word in a book.
- The most efficient solution to this problem is to use a hash-table.
- Spaces don't count, and words are not case sensitive (i.e. Cat, CAT, and cat are all the same)
- Don't concern yourself wth punctuation.
- The function created should take in a string as an argument.
- The best approach to this is to iterate through the string and to keep a "tally" of how many times a word appears.
- the word should be the "key", and a counter as the "value".
- The word with the highest counter at the end is the returned word.
- It is possible for the candidate to have a "tempWord" and "tempCounter" that will hold the highest word and count so far.
This will prevent them from having to iterate through the hash-table once the string is completed.
- Time and Space is O(n).

### Edge Cases

- It is possible to have words show up the same amount of times as others, In this case, return the first occurrence.
(i.e. both "dog" and "cat" show up twice -> return "dog");

## Structure

Familiarize yourself with the grading rubric, so you know how to score the interview.

Look for effective problem solving, efficient use of time, and effective communication with the whiteboard space available.

Every solution might look a little different, but the candidate should be able to test their solution with different inputs to verify correctness.

Assign points for each item on the Rubric, according to how well the candidate executed on that skill.

Add up all the points at the end, and record the total at the bottom of the page.

## Example

| Input | Output |
|-----|----|
| `In a galaxy far far away` | `far` |
| `Taco cat ate a taco` | `taco` |
| `No. Try not. Do or do not. There is no try.` | `No` |

## Documentation

Record detailed notes on the rubric, to share with the candidate when the interview is complete.

## Solution

<details>
  <summary>Algorithm</summary>
  Create a Hash Table with words as keys, and integers as values.  This will store the number of occurrences for words found in the input string.  Iterate through the input string.  Either parse the string or use Regex to find all discreet words within the input string.  For each word read, increment the value in the Hash Table.  After you're finished iterating, read all values from the Hash Table.  return the word that is associated with the hightest value stored in the Table.
</details>
<details>
  <summary>Pseudocode</summary>
  <pre><code>algorithm MOST_COMMON_WORD:
  declare string BOOK <- input string
  declare hashtable WORD_COUNT <- new HashTable storing words as keys and integers as values
  for each WORD in BOOK:
    if WORD_COUNT contains the key WORD:
      increment WORD_COUNT at WORD by 1
    else
      add WORD to WORD_COUNT as key with 1 as value
  return the highest value in WORD_COUNT</code></pre>
</details>
<details>
  <summary>Big O</summary>
  Depending on the length of the input book,  we will read and store more words in our Hash Table.  If we iterate through our book once to tally up the word count, and perhaps again when we find the largest value in the Hash Table we will have a run time complexity of 0(n).  Since we are storing all words in a Hash Table, we will also have a space complexity of 0(n) as well.
</details>