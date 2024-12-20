using System;

namespace assigment
{
    internal class Program
    {
        static void swapbyvalue(int n01, int n02)
        {
            int temp = n01;
            n01 = n02;
            n02 = temp;
        }
        static void swapbyreference(ref int n01, ref int n02)
        {
            int temp = n01;
            n01 = n02;
            n02 = temp;
        }

        static int Test1value(int[] arr)
        {
            int sum = 0;
            arr[0] = 500;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static int Test2value(int[] arr)
        {
            int sum = 0;
            arr = new int[] { 700, 800, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static int Test1ref(ref int[] arr)
        {
            int sum = 0;
            arr[0] = 500;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static int Test2ref(ref int[] arr)
        {
            int sum = 0;
            arr = new int[] { 700, 800, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void sumaandsub(int n01, int n02, out int sum, out int sub)
        {
            sum = n01 + n02;
            sub = n01 - n02;
        }

        static int Sumofdigit(int number)
        {
            int Return = 0;
            while (number > 0)
            {
                Return += number % 10;
                number /= 10;
            }
            return Return;
        }
        static bool Isprime(int number)
        {
            bool Return = false;
            if (number == 2 || number == 3)
                Return = true;
            else if (number % 2 == 0 || number < 2)
                Return = false;

            for (int i = 3; i <= number; i++)
            {
                if (number % i == 0 && number != i)
                { Return = false; break; }
                else if (number == i)
                { Return = true; }
            }
            return Return;
        }

        static void MinMaxArray(int[] arr, out int max, out int min)
        {
            max = arr.Max();
            min = arr.Min();
        }

        static bool factor(int num, out int sum)
        {
            sum = 1;
            if (num == 0) { sum = 1; return true; }
            else if (num < 0) { sum = 0; return false; }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    sum *= i;
                }
                return true;
            }

        }

        static void ChangeChar(ref string Str, int index, char Char)
        {
            Char[] chararray = Str.ToCharArray();
            chararray[index] = Char;
            Str = new string(chararray);
        }
        static int[,] identitymatrix(int n)
        {

            if (n <= 0)
            {
                throw new ArgumentException("not valid input");
            }
            int[,] Return = new int[n, n];
            for (int i = 0, j = 0; i < n && j < n; i++)
            {
                if (i == j)
                {
                    Return[j, i] = 1;
                }
                else
                {
                    Return[j, i] = 0;
                }

                if (i == n - 1 && j != n - 1)
                {
                    j++;
                    i = -1;
                    continue;
                }
            }
            return Return;
        }

        static int sum(int[] arr)
        {
            int sum = 0;
            if (arr.Length == 0)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        static void merge(ref int[] arr1, int[] arr2)
        {
            if ((arr1.Length != arr2.Length) || arr1.Length == 0)
            {
                throw new ArgumentException("not correcto"); //try to avoid exception
            }
            else
            {
                arr1 = arr1.Union(arr2).Order().ToArray();
            }
        }

        static string Frequency(int[] arr)
        {
            int frequency = 0;
            string output = "";
            int[] count = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (count.Contains(arr[i])) { continue; }
                for (int j = 0; j < arr.Length; j++)
                { 
                    if (arr[i] == arr[j]) { frequency++;}
                }

                if (frequency == 0) { continue; }
                output += string.Format("element number{0} repeat {1} times\n", i, frequency);
                count[i] = arr[i];
                frequency = 0;
            }
            return output;
        }

        static int secondlargestelement(int[] arr)
        { 
            arr = arr.Order().ToArray();
            return arr[arr.Length - 2];
        }

        static uint longdistance(int[] arr)
        {
            uint distance = 0, check = 0, counter = 0;
            
            for (uint i = 0; i < arr.Length; i++)
            {
                for (uint j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && i != j) 
                        check =  j - i - 1;
                    counter = j;
                }
                if (check > distance) { distance = check; }
            }
            return distance;
        }

        static void reverse(ref string Str)
        {
            string[] strings = Str.Split(' ');
           strings = strings.Reverse().ToArray();
            Str = string.Join(' ', strings);
        }

        static void Print_reverse_of_any_array<T>(T[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {                                                //GENERIC
                Console.Write($"{arr[i]} ");
            }
        }
        static void Main(string[] args)
        {
            #region 1
            ////passing by value ==> only hold the value and use it as input paramter
            //int n01 = 5, n02 = 6;
            //Console.WriteLine($"n01 before swap: {n01}\n n02 before swap: {n02}");
            //swapbyvalue(n01, n02);
            //Console.WriteLine($"n01 after swap: {n01}\n n02 after swap: {n02}");
            ////passing by reference hold the reference of variable in main function(addres) and work as input output paramter
            //Console.WriteLine($"n01 before swap: {n01}\n n02 before swap: {n02}");
            //swapbyreference(ref n01,ref n02);
            //Console.WriteLine($"n01 after swap: {n01}\n n02 after swap: {n02}");
            #endregion
            #region 2
            ////reference type when send in paramter as value it will refer to same object in heap so if i modifiy any value it will be in main function modified
            ////but if i use new key word it will make refering to another object in heap
            ////reference type when send in paramter as reference it will be elies name to main reference in stack so if i modifiy any number it will be modified but if i use new key word it will refer to another object in heap
            //int[] test = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(Test1value(test));
            //Console.WriteLine(test[0]);
            //Console.WriteLine("after new");
            //Console.WriteLine(Test2value(test));
            //Console.WriteLine(test[0]);
            //Console.WriteLine("ref");
            //Console.WriteLine(Test1ref(ref test));
            //Console.WriteLine(test[0]);
            //Console.WriteLine("ref with new key word");
            //Console.WriteLine(Test2ref(ref test));
            //Console.WriteLine(test[0]);
            #endregion
            #region 3
            //int n01 = 5, n02 = 3;
            //sumaandsub(n01, n02, out int sum, out int sub);
            //Console.WriteLine($"sum: {sum}, sub: {sub}"); 
            #endregion
            #region 4
            //int num = 25;
            //Console.WriteLine(Sumofdigit(num));
            #endregion
            #region 5
            //int prime = 13;
            //int prime1 = 17;
            //Console.WriteLine(Isprime(prime));
            //Console.WriteLine(Isprime(prime1));
            #endregion
            #region 6
            //int[] arr = { 35, 44, 100, 500 };
            //MinMaxArray(arr, out int max, out int min);
            //Console.WriteLine($"max: {max}\nmin: {min}");
            #endregion
            #region 7
            //int num = 5;
            //Console.WriteLine($"valid number to get his factor: {factor(num , out int Factor)}, factor: {Factor}");
            #endregion
            #region 8
            //string test = "osama";
            //ChangeChar(ref test, 0, 'a');
            //Console.WriteLine(test);
            #endregion
            #region 9
            //int n = 0;
            //int[,] matrix = identitymatrix(n);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //    Console.WriteLine(); // New line for each row
            //}
            #endregion
            #region 10
            //int[] ints = { 1, 2,3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(sum(ints));
            #endregion
            #region 11
            //int[] arr = { 20, 5, 8, 1, 10 };
            //int[] arr1 = { 30, 48, 300, 4, 50};
            //merge(ref arr, arr1);
            //foreach (int i in arr)
            //    System.Console.WriteLine(i);
            #endregion
            #region 12
            //int[] arr = {1,2,3,1,3,2,5,6,5,6};
            //Console.WriteLine(Frequency(arr));
            #endregion
            #region 13
            //did it before
            #endregion
            #region 14
            //int[] arr = { 315, 100, 448, 105 };
            //Console.WriteLine(secondlargestelement(arr));
            #endregion
            #region 15
            //مش عارف اوصل لحل ليها هنا
            //int[] arr = {7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 6, 3};
            //Console.WriteLine(longdistance(arr));
            #endregion
            #region 16
            //string Str = "osama sayed abdelkhalek";
            //reverse(ref Str);
            //Console.WriteLine(Str);
            #endregion
            #region 18
            //double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            //    Print_reverse_of_any_array(doubleArray);
            #endregion
        }

    }
}

