namespace Demo
{
    internal class Program
    {
        // 1. Methods
        // 1.1 Class Member Methods [Static Methods]
        // 1.2 Object Member Methods [Non static Methods]

        #region Methods
        public static void StaticMethod( string Shape , int Count = 5 )
        {
            for (int i = 1; i <= Count; i++)
            {
                Console.WriteLine(Shape); 
            }

        }

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
        }
    }
}
