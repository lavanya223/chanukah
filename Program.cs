/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK
*/

/*
************************self reflection, Time and Recommendation**********************************
*Time : it took me approximately 14 hours to solve all the problems
*self Reflection : because of this assignment i am habituated to the syntax of the c#
*the problems in this assignment are some what harder than the assignments in the Kattis
*recommendation : this format is some what confusing , it would be graet if there is a chance of submitting the individual problems
*/
using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "arshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "zimmermanbuilding";
            char ch = 'x';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                String final_string = "";
                // checking for the vowels
                foreach (char i in s)
                {
                    if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u' || i == 'A' || i == 'E' || i == 'I' || i == 'O' || i == 'U')
                    {
                        // replacing with the empty string when there is an vowel
                        final_string += "";
                    }
                    else
                    {
                        //if we do not find the vowels i am placing the same character in the output
                        final_string += i;
                    }
                }

                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                // declaring the temperory strings
                string y1 = "";
                string y2 = "";
                bool flag = false;
                // combining all the elements in the first string after converting them to lowercase
                for (int k = 0; k < bulls_string1.Length; k++)
                {
                    y1 = y1 + bulls_string1[k].ToLower();
                }
                // combining all the elements in the second string after converting them to lowercase
                for (int k = 0; k < bulls_string2.Length; k++)
                {
                    y2 = y2 + bulls_string2[k].ToLower();
                }
                // if both the stringds are equal we are sending the true
                if (y1 == y2)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

                return flag;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                //finding the length of the bull_bucks
                int[] x = new int[bull_bucks.Length];
                int total = 0;

                for (int l = 0; l < bull_bucks.Length; l++)
                {
                    x[l] = -1;
                }
                //adding all the  elements
                for (int i = 0; i < bull_bucks.Length; i++)
                {
                    total += bull_bucks[i];

                    int repeatedNo = 1;
                    for (int j = i + 1; j < bull_bucks.Length; j++)
                    {
                        if (bull_bucks[i] == bull_bucks[j])
                        {
                            repeatedNo++;
                            x[j] = 0;
                        }

                    }
                    //checking for the unique elements in the passed array by passing 0 if it matches any other elements in a given array
                    if (x[i] != 0)
                    {
                        x[i] = repeatedNo;
                    }
                    //counting how many times an element is repeated
                }
                for (int k = 0; k < bull_bucks.Length; k++)
                {
                    if (x[k] > 1)
                    {
                        total -= (x[k] * bull_bucks[k]);
                    }
                }

                return total;

            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int sum = 0;
                // checking whether we have the same nop of rows ans same no of columns
                if (bulls_grid.GetLength(0) == bulls_grid.GetLength(1))
                {
                    for (int i = 0; i < bulls_grid.GetLength(0); i++)
                    {
                        for (int j = 0; j < bulls_grid.GetLength(1); j++)
                        {
                            if (i == j)
                            {
                                sum += bulls_grid[i, j];
                            }
                            if (i + j == bulls_grid.GetLength(0) - 1)
                            {
                                sum += bulls_grid[i, j];
                            }

                        }

                    }
                    // subtracting the common element in both the diagnols from the total sum
                    if (bulls_grid.GetLength(0) % 2 != 0)
                    {
                        int xy = (bulls_grid.GetLength(0) - 1) / 2;
                        sum -= bulls_grid[xy, xy];
                    }
                }


                return sum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                char[] x = bulls_string.ToCharArray();
                char[] newString = new char[bulls_string.Length];
                // calculating the position of the index
                for (int i = 0; i < x.Length; i++)
                {
                    newString[indices[i]] = x[i];
                }
                string valueString = "";
                //creating the output from the indexes
                for (int k = 0; k < bulls_string.Length; k++)
                {
                    valueString += newString[k];
                }

                return valueString;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {

                if (bulls_string6.Contains(ch))
                {
                    String prefix_string = "";
                    int i;
                    for (i = 0; i < bulls_string6.Length; i++)
                    {
                        if (bulls_string6[i] == ch)
                        {
                            break;
                        }

                    }
                    //The new_string is basically the bulls_string after the part till character ch is removed

                    string reversed = "";
                    int j;
                    //This part reverses the part of bulls_string6
                    for (j = i; j >= 0; j--)
                    {
                        reversed = reversed + bulls_string6[j];

                    }
                    /*This part adds the reversed part to the new_string that is obtained
                    after snipping the part of bulls_string till character ch*/
                    string part = bulls_string6.Substring(0, i);
                    prefix_string = bulls_string6.Replace(part, reversed);
                    return prefix_string;
                }
                else
                {
                    return bulls_string6;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


        }
    }
}