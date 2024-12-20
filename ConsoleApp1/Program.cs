namespace ConsoleApp1
{
    internal class Program
    {
  
        static void Main(string[] args)
        {
            #region array
            ////int[] x =>(allocate 8 byte in stack for reference, reference refer to null)
            ////to reach any value = index * n.of.bytes + address of first element
            ////x = new int[5] => (allocate bytes in heap(5 * 4 = 20 + clr overhead) +assign to default value zero +goes to user constructor + make reference in stack refer to first elemnt of array(hold first element address))
            ////int[] x = {1.2.3.4.5}; same as int x = new int[5] {1.2.3.4.5} same as int x = int[] {1.2.3.4.5}
            ////array is fixed size cant change it after create it
            //int[] x = { 1, 2, 3 };
            //Console.WriteLine(x.IsFixedSize);
            //Console.WriteLine(x.Length);
            //Console.WriteLine(x.Rank);
            //Console.WriteLine(x.Average()); //error cant convert from method group to bool cause of it ()
            ////////////
            //two D array 
            //1- rectangle ==> row is equal
            //2- judge ==> row is not equal
            //int[,] ints = { {1 , 2}, {3, 4} };
            //for (int i = 0, j = 0; j < 2; j++)
            //{ 
            //    Console.WriteLine(ints[i, j]);
            //    if (j == 1)
            //    {
            //        if (i == 1)
            //        { 
            //            break;
            //        }
            //        i++;
            //        j = -1;
            //    }
            //}
            //foreach (int i in ints) { Console.WriteLine(i);  }
            #endregion

            #region note
            //passing by value in fumction is input and by reference is input output and out is output
            #endregion

        }
    }
}
