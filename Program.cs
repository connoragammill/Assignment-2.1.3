namespace Assignment_2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the method you want to use:");
            Console.WriteLine("1. Add (int num1, int num2)");
            Console.WriteLine("2. Add (decimal num1, decimal num2, decimal num3)");
            Console.WriteLine("3. Multiply (float num1, float num2)");
            Console.WriteLine("4. Multiply (float num1, float num2, float num3)");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter two integers:");
                    int int1 = int.Parse(Console.ReadLine());
                    int int2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + Maths.Add(int1, int2));
                    break;
                case 2:
                    Console.WriteLine("Enter three decimals:");
                    decimal dec1 = decimal.Parse(Console.ReadLine());
                    decimal dec2 = decimal.Parse(Console.ReadLine());
                    decimal dec3 = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + Maths.Add(dec1, dec2, dec3));
                    break;
                case 3:
                    Console.WriteLine("Enter two floats:");
                    float float1 = float.Parse(Console.ReadLine());
                    float float2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + Maths.Multiply(float1, float2));
                    break;
                case 4:
                    Console.WriteLine("Enter three floats:");
                    float float3 = float.Parse(Console.ReadLine());
                    float float4 = float.Parse(Console.ReadLine());
                    float float5 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + Maths.Multiply(float3, float4, float5));
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        public class Maths
        {
            public static int Add(int num1, int num2)
            {
                return num1 + num2;
            }
            public static decimal Add(decimal num1, decimal num2, decimal num3)
            {
                return num1 + num2 + num3;
            }
            public static float Multiply(float num1, float num2)
            {
                return num1 * num2;
            }
            public static float Multiply(float num1, float num2, float num3)
            {
                return num1 * num2 * num3;
            }
        }
    }
    
}
