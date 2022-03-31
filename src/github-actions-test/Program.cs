using System.Security.Cryptography;
using System.Text;

namespace github_actions_test
{
    public class Program
    {
        static void Main(string[] args)
        {
            string origoString = "Hello brother";

            var hashedString = Sha256(origoString);

            Console.WriteLine($"Original string: {origoString}");
            Console.WriteLine($"Hashed string: {hashedString}");
            Console.WriteLine("Hello World!");

            string salt = "shit";
            // create bytes array from string salt
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);

            var hashedSalted = Sha256(origoString, saltBytes);
            Console.WriteLine($"Hashed string: {hashedSalted}");
        }

        // Create method to return the sum of two numbers
        public static int Add(int a, int b) => a + b;

        // Create method to return the difference of two numbers
        public static int Subtract(int a, int b) => a - b;

        // Create method to return the product of two numbers
        public static int Multiply(int a, int b) => a * b;

        // Create method to return the quotient of two numbers
        public static int Divide(int a, int b) => a / b;

        // Create method to return the remainder of two numbers
        public static int Remainder(int a, int b) => a % b;

        // Create method to return the square of a number
        public static int Square(int a) => a * a;

        // Calculate sha256 hash of a string
        public static string Sha256(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(input);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        // Calculate sha256 hash with salt bytes of a string
        public static string Sha256(string input, byte[] saltBytes)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(input);
                var saltedBytes = new byte[bytes.Length + saltBytes.Length];

                for (int i = 0; i < bytes.Length; i++)
                    saltedBytes[i] = bytes[i];

                for (int i = 0; i < saltBytes.Length; i++)
                    saltedBytes[bytes.Length + i] = saltBytes[i];

                var hash = sha256.ComputeHash(saltedBytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}