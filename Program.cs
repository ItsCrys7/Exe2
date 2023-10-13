namespace StringExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //null e valoare cu semn speciala = "nici o adresa/nu am continut"

            string text1 = "file";
            string text2 = "FILE";

            bool areEqual1 = (text1 == text2);
            bool areEqual2 = text1.Equals(text2, StringComparison.InvariantCultureIgnoreCase);
            bool areEqual3 = string.Equals(text1, text2, StringComparison.InvariantCultureIgnoreCase);

            Console.WriteLine(areEqual1);
            Console.WriteLine(areEqual2);
            Console.WriteLine(areEqual3);

            bool contanins = text1.Contains(text2);

        }
    }
}