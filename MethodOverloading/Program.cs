namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(1, 2);
            Add(2.4m, 2.4m);
            Add(1, 2);


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
            { return $"{sum} dollar"; }

            else
            { return $"{sum} dollar."; }



        }




       









    }
}