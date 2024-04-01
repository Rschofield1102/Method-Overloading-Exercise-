namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(1, 2);
            Add(2.4m, 2.4m);
            Add(1, 2, true);
            //Add(1, 5, true); //--- extra practice, added userinput
        }

        public static void Add(int num1, int num2)//exercise 1-----------
        {
            Console.WriteLine(num1 + num2);
        }
        public static void Add(decimal num1, decimal num2)//exercise 2
        {
            {
                Console.WriteLine(num1 + num2);
            }
        }
        public static string Add(int num1, int num2, bool check)//exercise 3
        {
            var sum = num1 + num2;
            if (check == true && sum <= 2)
            {
                Console.WriteLine($"{sum} dollar");
                return $"{sum} dollar";
            }         
            else
            {
                Console.WriteLine($"{sum} dollars.");
                return $"{sum} dollars.";
            }
        }




        //--------extra practive, added userinput -----------
        //---------------------------------------------------
        //----------------------------------------------------
        //public static string Add(int num1, int num2, bool check)
        //{

        //    int sum = num1 + num2;

        //    Console.WriteLine("Input a your money, I will add it to mine and give you the return ;).");
        //    int userInput = Convert.ToInt32(Console.ReadLine());

        //    int realSum = sum + userInput;
        //    if (check == true && realSum <= 2)
        //    {
        //        Console.WriteLine(realSum + $"dollar.");
        //        return realSum + $"dollar.";
        //    }
        //    else
        //    {
        //        Console.WriteLine(realSum + $"dollars.");
        //        return realSum + $"dollars.";
        //    }
    }




    }









}