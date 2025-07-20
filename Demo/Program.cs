namespace Demo
{
    internal class Program
    {
        // 1. Methods
        // 1.1 Class Member Methods [Static Methods]
        // 1.2 Object Member Methods [Non static Methods]

        #region EX Methodes Proto Type
        //public static void StaticMethod( string Shape , int Count = 5 )
        //{
        //    for (int i = 1; i <= Count; i++)
        //    {
        //        Console.WriteLine(Shape); 
        //    }

        //}

        #endregion

        #region EX Methods For Passing By Value
        //public static void swap(ref int X,ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        #endregion

        #region Sum Element 
        //public static int SumElements(ref int[] arr)
        //{
        //    int sum = 0;
        //    if (arr is not null)
        //    {
        //        arr = [10 , 20, 30 , 40];
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];

        //        }

        //    }
        //    return sum;
        //}
        #endregion

        #region Function or Methode return Multiplication and Sumtion
        //        public static void SumMultiplication(int X , int Y ,out int Sum ,out int Multiplication)
        //        {
        //             Sum = X + Y;
        //             Multiplication = X * Y;

        //            //return [ Sum, Multiplication ]; //Return Array
        //;        }
        #endregion

        #region Function For Params
        
        //public static int SumArray(params int[] arr)
        //{
        //    int Sum = 0;
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i <arr.Length; i++)
        //        {
        //            Sum += arr[i];
        //        }
        //    }
        //    return Sum;
        //}

        #endregion

        static void Main(string[] args)
        {
            #region Function Prototype
            //StaticMethod(":)" , 10 ); // Passing parameter by order
            //StaticMethod(Count: 20, Shape: "#"); // Passing Parameter by name
            //StaticMethod(); // Passing by deafault value
            //StaticMethod(Count: 3); //Passing Count By Name , Passing Shape by deafault
            //StaticMethod("%"); //Passing by Requird Parameter
            // /*\
            //int Name = 10;
            //StaticMethod(Shape: "/*\\", Count: 10); // Invalid [Escape Sequence]
            //Console.WriteLine(@"Youssef \ Mohamed \n Samir"); //@ ignore Escape Sequence
            //Console.WriteLine($"Youssef  Mohamed  {{{Name}}}");
            //Console.WriteLine($"Youssef  Mohamed  {{Name}}");
            //Console.WriteLine(@$"Youssef  Mohamed  {Name}");
            #endregion

            #region Function Parameters [Value] and [Reference] and [out] and [Params]

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

            #region Sum Element of Array by Value
            //int[] Numbers = { 1, 2, 3 };
            //int Reasult = SumElements(Numbers); // Passing by value [Address]
            //Console.WriteLine($"Resault of array is : {Reasult}");
            //Console.WriteLine(Numbers[0]);

            #endregion

            #region Sum Element of Array By Reference
            //int[] Numbers = { 1, 2, 3 };
            //int Reasult = SumElements(ref Numbers); // Passing by value [Address]
            //Console.WriteLine($"Resault of array is : {Reasult}");
            //Console.WriteLine(Numbers[0]);


            #endregion

            #region Changes that taken when passing by reference and passing by value


            //int[] Counters = { 1, 2, 3 };
            //Console.WriteLine($"Counter is {Counters[0]}");
            //int Reasult = SumElements(Counters); //Passing by Value
            //Console.WriteLine(Reasult);
            //Console.WriteLine($"Counter is {Counters[0]}");



            //int[] Counters = { 1, 2, 3 };
            //Console.WriteLine($"Counter is {Counters[0]}");
            //int Reasult = SumElements(ref Counters); //Passing by Value
            //Console.WriteLine(Reasult);
            //Console.WriteLine($"Counter is {Counters[0]}");

            #endregion

            #region Passing by Out

            //int A = 10, B = 20, SumNumber, MultiplicationNumber;

            //SumMultiplication(A, B,out SumNumber,out MultiplicationNumber);

            //Console.WriteLine($"Sum Numbers is {SumNumber} and Multiplication is {MultiplicationNumber}");





            #endregion

            #region Passing by Params
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int First = 1, Secound = 2, Third = 3;
            //int sum = SumArray(First , Secound , Third); // params As Array in Function 
            //Console.WriteLine($"Sum is {sum}");

            #endregion



            #endregion

        }
    }
}
