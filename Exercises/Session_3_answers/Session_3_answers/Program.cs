using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_answers {
    class Program {
        static void Main(string[] args) {

            Answers answers = new Answers();
            int[] array = new int[100000000];

            //--------Question1-------------
            string sentence = "lorem ipsum dolor sit amet consectetur adipiscing elit";

            string word = answers.LongestWord(sentence);

            Console.WriteLine("\nThe Longest word in the sentence is '{0}' and in uppercase is '{1}'", word, ConvertWordToUpper(word));
            Console.WriteLine("\nEnter to Continue...");
            Console.ReadLine();


            //--------Question2-------------

            Console.WriteLine("Please enter a word to reverse:");
            string inputWord = Console.ReadLine();

            string revered = answers.ReverseWord(inputWord);

            Console.WriteLine("\nYour word is: '{0}' and revered is '{1}'", inputWord, revered);
            Console.WriteLine("\nEnter to Continue...");
            Console.ReadLine();

            //--------Question3-------------

            Console.WriteLine("Please provide a number to compute all the numbers before it:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose Sum (s) or Product (p) from 1 until your number:");
            char choose = Convert.ToChar(Console.ReadLine());

            Computing(num, choose);

            //Console.WriteLine("Please provide how many numbers you want to enter:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("\nPlease start writing the numbers:");
            //InputNumbers(num, array);

            //Console.WriteLine("You have entered: ");
            //Values(num, array);

            //Console.WriteLine("If you want to see the sum of the numbers enter 's', and for product enter 'p': ");
            //char choose = Convert.ToChar(Console.ReadLine());

            //Computations(num, array, choose);

            Console.WriteLine("\nEnter to Continue...");
            Console.ReadLine();

            //--------Question4-------------

            Console.WriteLine("Please enter a number in order to display the prime form 1 to your number:");
            int numPrime = Convert.ToInt32(Console.ReadLine());

            PrintPrimeNumbers(numPrime);

            Console.WriteLine("\nEnter to Continue...");
            Console.ReadLine();

            //--------Question5-------------

            Console.WriteLine("Array1: [2, 4, 9, 12]");
            Console.WriteLine("Array2: [1, 3, 7, 10]");

            int multiplicationOfArrays = MultyplyArrays();
            Console.WriteLine("Multipication of the two arrays result is: {0}", multiplicationOfArrays);

            Console.WriteLine("\nEnter to Continue...");
            Console.ReadLine();

            //--------Question6-------------

            Console.WriteLine("Sort the given Array: [ 0, -2, 1, 20, -31, 50 , -4, 17, 89, 100 ] :");

            answers.SortTheArray();

            Console.WriteLine("\nEnter to Continue...");
            Console.ReadLine();

        }

        static string ConvertWordToUpper(string s) {
            return s.ToUpper();
        }

        static void Computing(int n, char c) {
            int sum = 0;
            int prod = 1;
            
            switch (c) {
                case 's':
                    for (int i = n; i > 0; i--) {
                        sum += i;
                    }
                    Console.WriteLine("The sum of the numbers is: {0}", sum);
                    break;
                case 'p':
                    for (int i = n; i > 1; i--) {
                        prod *= i;
                    }
                    Console.WriteLine("The product of the numbers is: {0}", prod);
                    break;
                default:
                    break;
            }
        }

        //static int InputNumbers(int n, int[] a) {

        //    for (int i = 0; i < n; i++) {
        //        Console.WriteLine("\nNumber {0} is", i);
        //        a[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    return n;
        //}

        //static int Values(int n, int[] a) {
        //    for(int j = 0; j < n; j++) {
        //        Console.WriteLine("{0} ", a[j]);
        //    }
        //    return n;
        //}

        //static void Computations(int n, int[] a, char c) {
        //    int sum = 0;
        //    int prod = 1;

        //    switch (c) {
        //        case 's':
        //            for (int k = 0; k < n; k++) {
        //               sum += a[k]; 
        //            }
        //            Console.WriteLine("The result of the sum is: {0}", sum);
        //            break;
        //        case 'p':
        //            for (int i = 0; i < n; i++) {
        //                prod = prod + a[i];
        //            }
        //            Console.WriteLine("The result of the product is: {0}", prod);
        //            break;
        //        default:
        //            Console.WriteLine("Invalid imput!");
        //            break;
        //    }
        //}

        static void PrintPrimeNumbers(int num) {
            int i, j, flag;

            Console.Write("Prime numbers between 1 and " +
                                           num + " are:\n");

            for (i = 1; i <= num; i++) {

                if (i == 1 || i == 0)
                    continue;

                flag = 1;

                for (j = 2; j <= i / 2; ++j) {
                    if (i % j == 0) {
                        flag = 0;
                        break;
                    }
                }

                if (flag == 1)
                    Console.Write(i + " ");
            }
        }

        static int MultyplyArrays() {

            int[] array1 = {2, 4, 9, 12};
            int[] array2 = {1, 3, 7, 10 };
            int[] output = new int[16];

            for (int i = 0; i < array1.Length; i++) {
                for (int j = 0; j < array2.Length; j++) {
                    output[i * array1.Length + j] = array1[i] * array2[j];
                }
            }

            return output[16];
        }
    }
}
