using System.Text.RegularExpressions;
// Chalenge#1: Create a function called shortcut to remove the lowercase vowels (a, e, i, o, u ) in a given string.
// Examples
// "hello"     -->  "hll"
// "codewars"  -->  "cdwrs"
// "goodbye"   -->  "gdby"
// "HELLO"     -->  "HELLO"

//solution:
// public class Kata

// {
//     public static void Main(string[] args)
//     {
//         Shortcut("codewars");
//     }
//     public static string Shortcut(string input)
//     {
//         string newString = Regex.Replace(input, "[aeiouAEIOU]", "");
//         return newString;
//     }
// }


// Chalenge#2: Define String.prototype.toAlternatingCase (or a similar function/method such as to_alternating_case/toAlternatingCase/ToAlternatingCase in your selected language; see the initial solution for details) such that each lowercase letter becomes uppercase and each uppercase letter becomes lowercase. For example:

// "hello world".ToAlternatingCase() == "HELLO WORLD"
// "HELLO WORLD".ToAlternatingCase() == "hello world"
// "hello WORLD".ToAlternatingCase() == "HELLO world"
// "HeLLo WoRLD".ToAlternatingCase() == "hEllO wOrld"
// "12345".ToAlternatingCase() == "12345" // Non-alphabetical characters are unaffected
// "1a2b3c4d5e".ToAlternatingCase() == "1A2B3C4D5E"
// "String.ToAlternatingCase".ToAlternatingCase() == "sTRING.tOaLTERNATINGcASE"

//Solution:

// namespace Extensions
// {
//     public static class StringExt
//     {
//         public static void Main(string[] args)
//         {
//             string input = "Hello World";
//             string result = input.ToAlternatingCase();
//             Console.WriteLine(result);
//         }
//         public static string ToAlternatingCase(this string s)
//         {
//             char[] newChars = new char[s.Length];
//             for (var i = 0; i < s.Length; i++)
//             {
//                 if (s[i] == char.ToUpper(s[i]))
//                 {
//                     newChars[i] = char.ToLower(s[i]);
//                 }
//                 else if (s[i] == char.ToLower(s[i]))
//                 {
//                     newChars[i] = char.ToUpper(s[i]);
//                 }
//             }
//             return new String(newChars);
//         }
//     }
// }

// // Chalenge#3: Task Given a list of unique numbers sorted in ascending order, return a new list so that the values increment by 1 for each index from the minimum value up to the maximum value (both included).

// Example
// Input:  1,3,5,6,7,8 Output: 1,2,3,4,5,6,7,8


// //solution
// using System.Collections.Generic;
// using System.Linq;

// namespace Fixer
// {
//     public class Fixer
//     {

//         public static void Main(string[] args)
//         {
//             List<int> newList = new() { 1, 3, 5, 6, 7, 8 };
//             var result = PipeFix(newList);
//             foreach (int num in result)
//             {
//                 Console.WriteLine(num);
//             }
//         }
//         public static List<int> PipeFix(List<int> numbers)
//         {


//             for (var i = 0; i < numbers.Count - 1; i++)
//             {
//                 if ((numbers[i + 1] - numbers[i]) != 1)
//                 {
//                     numbers.Insert(i + 1, numbers[i] + 1);
//                 }
//                 else
//                 {
//                     continue;
//                 }
//             }
//             return numbers;
//         }

//     }

// }
