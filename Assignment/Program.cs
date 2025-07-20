namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int[] Numbers = [1, 2, 3, 4, 5];
            //int sum = 0;
            //if(Numbers is not null)
            //{
            //    for (int  i = 0; i < Numbers.Length; i++)
            //    {
            //        sum += Numbers[i];
            //    }
            //    Console.WriteLine($"Sum of Numbers of Array is : {sum} ");
            //}
            #endregion

            #region Q2
            //2.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] Arr01 = [1, 5, 6, 8];
            //int[] Arr02 = [7, 2, 4, 9];

            //int[] Merage = new int[Arr01.Length + Arr02.Length];

            //Arr01.CopyTo(Merage, 0);
            //Arr02.CopyTo(Merage, Arr01.Length);

            //Array.Sort(Merage);

            //foreach (var item in Merage)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2
            //2.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] Arr01 = [1, 5, 6, 8];
            //int[] Arr02 = [7, 2, 4, 9];

            //int[] Merage = new int[Arr01.Length + Arr02.Length];

            //Arr01.CopyTo(Merage, 0);
            //Arr02.CopyTo(Merage, Arr01.Length);

            //Array.Sort(Merage);

            //foreach (var item in Merage)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q3
            //3.Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] Summition = { 1, 4, 3, 4, 5 };




            //    for (int i = 0; i < Summition.Length; i++)
            //    {
            //        int Counter = 1;
            //        for (int j = i+1; j < Summition.Length; j++)
            //        {
            //            if (Summition[i] == Summition[j])
            //            {
            //                Counter++;
            //            }
            //        }
            //        Console.WriteLine($"Your Number is {Summition[i]} and your counter is {Counter}");
            //     }




            #endregion

            #region Q4
            //4.Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] Number = [1,2,3,4,5];

            //int Max = 0;
            //int min = 100;

            //for (int i = 0; i < Number.Length; i++)
            //{

            //    for (int  j = i+1; j < Number.Length; j++)
            //    {
            //        if (Number[i] > Number[j])
            //        {
            //            Max = Number[i];
            //        }else

            //        {
            //            Max = Number[j];
            //        }

            //    }

            //    for (int K = Number.Length -1; K >= 0 ; K--)
            //    {
            //        if (Number[i] < Number[K])
            //        {
            //            min = Number[i];
            //        }
            //        else
            //        {
            //            min = Number[K];
            //        }
            //    }

            //}
            //Console.WriteLine($"Max Number is {Max}");
            //Console.WriteLine($"Min Number is {min}");
            #endregion

            #region Q5
            //5.Write a program in C# Sharp to find the second largest element in an array.
            //int[] Numbers = { 1, 5, 6, 9, 8 };

            // Array.Sort(Numbers);

            //int Secound = Numbers[Numbers.Length - 2];

            //Console.WriteLine($"the Secound Max Number is :{Secound}");

            #endregion

            #region Q6
            //6.Consider an Array of Integer values with size N, having values as    
            //in this Example

            //int[] arr = [7, 0, 0, 0, 5, 6, 7, 5, 0, 5, 7, 3];
            //int[] arr01 = new int[12] { 7, 0, 0, 0, 5, 6, 7, 5, 0, 5, 7, 3 };


            #endregion

            #region Q9
            //9.Write a program to create two multidimensional arrays of the same size. Accept values from the
            //user and store them in the first array.
            //Now copy all the elements of the first array on second array and print the second array.

            //int[,] arr = new int[2, 2];
            //Console.WriteLine("Enter value of Two dimentional array");

            //for (int i = 0; i < arr.Length; /*i++*/)
            //{

            //    bool isParsed = int.TryParse(Console.ReadLine(), out int markValue);
            //    Console.WriteLine(arr[i / arr.GetLength(1), i % arr.GetLength(1)]);
            //    if (isParsed)
            //    {
            //        i++;
            //    }
            //    else
            //    {
            //        i = i;
            //    }
            //}



            #endregion

            #region Q10
            //10.	 Write a Program to Print One Dimensional Array in Reverse Order

            int[] EmployeeNumber = { 1, 2, 3, 4, 5, 6 };

            Array.Reverse(EmployeeNumber);

            for (int i = 0; i < EmployeeNumber.Length; i++)
            {
                Console.WriteLine(EmployeeNumber);
            }

            #endregion
        }
    }
}
