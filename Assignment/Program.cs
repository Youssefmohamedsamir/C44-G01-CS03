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

            //int[] EmployeeNumber = { 1, 2, 3, 4, 5, 6 };

            //Array.Reverse(EmployeeNumber);

            //for (int i = 0; i < EmployeeNumber.Length; i++)
            //{
            //    Console.WriteLine(EmployeeNumber);
            //}

            #endregion



            #region Q1 and Q2 Function
            //1-	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            #region Passing By Value
            //int A = 10;
            //int B = 20;
            //Console.WriteLine($"{A}");
            //Console.WriteLine($"{B}");

            //swap(A, B); //Passing By Value

            //Console.WriteLine("After Swappig");
            //Console.WriteLine($"{A}");
            //Console.WriteLine($"{B}");
            #endregion

            #region Passing By Reference

            //int A = 10;
            //int B = 20;
            //Console.WriteLine($"{A}");
            //Console.WriteLine($"{B}");

            //swap( ref A , ref B); //Passing By Value

            //Console.WriteLine("After Swappig");
            //Console.WriteLine($"{A}");
            //Console.WriteLine($"{B}");


            #endregion


            #endregion

            #region Q3 Function

            //3-Write a c# Function that accept 4 parameters from user and return result of summation and
            //subtracting of two numbers

            //Console.WriteLine("Enter 4 number to sum and sub");
            //int X = 10;
            //int Y = 20;
            //int Z = 30;
            //int W = 40;

            //Summition(X, Y, Z, W, out int Sum, out int Sub);

            //Console.WriteLine($"Summition is {Sum} and sub is : {Sub}");


            #endregion

            #region Q4 Function 
            //Console.Write("Enter a number: ");
            //int input = int.Parse(Console.ReadLine());

            //int result = SumOfDigits(input);

            //Console.WriteLine($"The sum of the digits of the number {input} is: {result}");
            #endregion

            #region Q5 Function
            //5-Create a function named "IsPrime", which receives an integer number and returns true if it is prime,
            //or false if it is not:

            //Console.Write("Enter a number: ");
            //int input = int.Parse(Console.ReadLine());



            //bool Reasult = Isprime(input);
            //Console.WriteLine(Reasult);




            #endregion

            #region Q6 Function
            //6-	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array,
            //     using reference parameters


            int[] arr = { 10, 5, 22, 3, 15, 7 };
            int min = 0, max = 0;

            MinMaxArray(arr, ref min, ref max);

            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");
        }
        #endregion




    }
}
}
