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
            // Array => Fixed size 
            //Array => is a Data structure
            //Array=> The same data type


            #region Array

            #region One Dimensional array
            //Grades For Student in specific material
            //int[] Numbers;
            //Declare Fror Reference From Type Array 'Numbers'
            // Reference 'Number' is Refer To Null 
            // CLR will Allocate 4 bytes At Stack For Reference
            //Numbers = new int[3] {1 , 2 , 3};
            //Console.WriteLine(Numbers[0]);
            //CLR will allocate 12 bytes At Heap For Array
            // Initialize Allocated Bytes with Default Values [0,0,0]
            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);

            //Numbers[0] = 5;
            //Numbers[1] = 10;
            //Numbers[2] = 20;

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);


            //Console.WriteLine($"Numbers of size of array{Numbers.Length} and Dimention of array is {Numbers.Rank}");


            //for (int i = 0; i < Numbers.Length; i++)

            //    Console.WriteLine(Numbers[i]);

            //foreach (var item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Creation
            //int[] Numbers = new int[5] ;
            //int[] Numbers01 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] Numbers02 = { 1, 2, 3, 4, 5 };
            //int[] Numbers03 = [1,2,3,4,5,6];//C3 12 Collection Expression
            #endregion

            #region  2D Array
            //Rectangular Array
            //int[,] Marks = new int[2, 5] { {1,2,3,4,5 } , {6,7,8,9,10} };
            // CLR will Allocate 40 bytes at Heap And Intialize with 0
            //Marks[0,0] = 200;
            //Console.WriteLine($"Numbers of size of array{Marks.Length} and Dimention of array is {Marks.Rank}");
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Grades of Student Number {i+1}");
            //    for (int j = 0; j < Marks.GetLength(1); /*j++*/ )
            //    {
            //        Console.WriteLine($"Subject Number {j + 1} : ");
            //        bool isParsed = int.TryParse(Console.ReadLine(), out Marks[i, j]);
            //        if (isParsed)
            //        {
            //            j++;
            //        }
            //    }
            //}
            //Console.WriteLine("====================");

            //for (int i = 0; i <Marks.Length ; /*i++*/)
            //{
            //    bool isParsed = int.TryParse(Console.ReadLine(), out int markValue);
            //    Console.WriteLine(Marks[i/Marks.GetLength(1) , i % Marks.GetLength(1) ]);
            //    if (isParsed)
            //    {
            //        i++;
            //    }else
            //    {
            //        i = i; 
            //    }
            //}


            #endregion

            #region jagged Array
            //Array of Arrayes it consider one dimentional Array
            //int[][] JaggedArray = new int[3][];

            //JaggedArray[0] = new int[4];
            //JaggedArray[1] = new int[] { 10, 20 };
            //JaggedArray[2] = [10, 15, 18];

            #endregion

            #region Methods of Array

            #region Class Member Methods 
            //int[] Numbers = [1, 2, 3, 4, 5, 6, 7, 4, 9, 10];
            //Array.Sort(Numbers); //order with ascending order
            //Array.Reverse(Numbers);
            //Array.Clear(Numbers);//Return to deafault Value
            //Array.Clear(Numbers , 2 , 5);//Overload
            //Array.IndexOf(Numbers, 4);//Finds the index of the first Value
            //Array.LastIndexOf(Numbers, 4);//Finds the index of the last Value
            //Array.Resize(ref Numbers , 10);//Craete New Array With New Size

            //foreach (var item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}

            int[] Arr01 = [1, 2, 3, 4, 5];
            int[] Arr02 = new int[5];

            Array.Copy(Arr01, Arr02, 4);

            Console.WriteLine(Arr02);

            Array.ConstrainedCopy(Arr01 , 1 , Arr02 , 3 , 2);


            #endregion

            #region Object MemberMethods
            //int[] Marks = [1, 2, 3, 4, 5];
            //Marks.CopyTo(Arr02, 0);
            //Marks.GetValue(5);
            //Marks.SetValue(5 , 1);
            //Marks.GetLength(1);
            #endregion


            #endregion

            #endregion


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
