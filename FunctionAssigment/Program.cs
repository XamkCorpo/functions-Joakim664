namespace FunctionAssigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Everything is intentionally inside Main before refactoring to functions
            //Your job is to refactor this code to use functions for better readability and reusability.
            //Check learn on how to do this

            string name = "";
            int age = 0;
            bool valid = false;
            AskName(ref name, ref valid);
            valid = AskAge(ref age);
            PrintNameAndAge(name, age);
            CheckAge(age);
            string compareName = "Matti";
            ComparisonIgnoringCase(name, compareName);
            ComparisonMatchCase(name, compareName);
        }

        /// <summary>
        /// check if name matches comparison
        /// </summary>
        /// <param name="name">users name</param>
        /// <param name="compareName">compare name to comparison</param>
        private static void ComparisonMatchCase(string name, string compareName)
        {
            if (name.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }


        /// <summary>
        /// check if name doesnt match comparison
        /// </summary>
        /// <param name="name">users name</param>
        /// <param name="compareName">compare name to comparison</param>
        private static void ComparisonIgnoringCase(string name, string compareName)
        {
            if (name.Equals(compareName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");
        }

        /// <summary>
        /// check if user is 18 or younger
        /// </summary>
        /// <param name="age">is user adult or not adult</param>
        private static void CheckAge(int age)
        {
            if (age >= 18)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");
        }

        /// <summary>
        /// print users name and age
        /// </summary>
        /// <param name="name">users name</param>
        /// <param name="age">users age</param>
        private static void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }

        /// <summary>
        /// ask users age
        /// </summary>
        /// <param name="age">users age</param>
        /// <returns>users age</returns>
        private static bool AskAge(ref int age)
        {
            bool valid = false;
            while (!valid)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age) && age > 0)
                    valid = true;
                else
                    Console.WriteLine("Please enter a positive integer.");
            }

            return valid;
        }

        /// <summary>
        /// ask users name and check if the input is valid
        /// </summary>
        /// <param name="name">users name</param>
        /// <param name="valid">is name valid</param>
        private static void AskName(ref string name, ref bool valid)
        {
            while (!valid)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    valid = true;
                else
                    Console.WriteLine("Name cannot be empty.");
            }
        }
    }
}
