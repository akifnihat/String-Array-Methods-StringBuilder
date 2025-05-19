using System.Text;

namespace String_Array_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //int[] numbers = { -4, 7, -9, 0, 5, -2 };

            //int[] result = ConNegToPos(numbers);

            //Console.WriteLine("Deyisdirilmis array:");
            //foreach (int num in result)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion

            #region task2
            //Console.Write("sozu daxil edin: ");
            //string input = Console.ReadLine();

            //if (IsPalindrome(input))
            //{
            //    Console.WriteLine("Bu soz palindrome-dur.");
            //}
            //else
            //{
            //    Console.WriteLine("Bu soz palindrome deyil.");
            //}

            #endregion

            #region task3
            //Console.Write("string daxil et: ");
            //string input = Console.ReadLine();

            //string result = RemoveDuplicateCharacters(input);

            //Console.WriteLine("Tekrarsiz: " + result);

            #endregion

            #region task4
            //Console.Write("Metni daxil et: ");
            //string input = Console.ReadLine();

            //PrintWords(input);

            #endregion

            #region task5
            //Console.Write("Metni daxil edin: ");
            //string input = Console.ReadLine();

            //PrintFirstFourChars(input);

            #endregion

            #region task6
            //Console.Write("Email daxil et: ");
            //string email = Console.ReadLine();

            //string domain = FindDomain(email);
            //Console.WriteLine("Domain : " + domain);

            #endregion

            #region task7
            //Console.Write("Yazi daxil et: ");
            //string input = Console.ReadLine();

            //bool isOnlyLetters = IsOnlyLetters(input);
            //if (isOnlyLetters)
            //{
            //    Console.WriteLine("Yazi yalniz herflerden ibaretdir.");
            //}
            //else
            //{
            //    Console.WriteLine("Yazida yalniz herfler yoxdur.");
            //}

            #endregion

            #region task8
            //Console.Write("Yazi daxil et: ");
            //string input = Console.ReadLine();

            //string resultText = Capitalize(input);
            //Console.WriteLine("yekun yazi: " + resultText);
            #endregion

            #region task9
            //string[] fullNames = { "Akif Tagiyev", "Messi Lionel", "Ulvi Macid", "Nahid Mehdili" };
            //string[] names = FirstNames(fullNames);
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion
        }
        public static int[] ConNegToPos(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Array null ola bilmez");
                return null;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = -array[i];
                }
            }

            return array;
        }

        public static bool IsPalindrome(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            StringBuilder newText = new StringBuilder();
            foreach (char c in text)
            {
                if (!char.IsWhiteSpace(c))
                    newText.Append(char.ToLower(c));
            }
            string cleanedText = newText.ToString();
            for (int i = 0; i < cleanedText.Length / 2; i++)
            {
                if (cleanedText[i] != cleanedText[cleanedText.Length - 1 - i])
                    return false;
            }
            return true;
        }


        public static string RemoveDuplicateCharacters(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;
            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                if (result.ToString().IndexOf(c) == -1)
                    result.Append(c);
            }
            return result.ToString();
        }



        public static void PrintWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            StringBuilder wordBuilder = new StringBuilder();

            foreach (char c in text)
            {
                if (!char.IsWhiteSpace(c))
                {
                    wordBuilder.Append(c);
                }
                else
                {
                    if (wordBuilder.Length > 0)
                    {
                        Console.WriteLine(wordBuilder.ToString());
                        wordBuilder.Clear();
                    }
                }
            }

            if (wordBuilder.Length > 0)
                Console.WriteLine(wordBuilder.ToString());
        }


        public static void PrintFirstFourChars(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length < 4)
            {
                Console.WriteLine("Metnde 4 ve ya daha cox simvol yoxdur");
                return;
            }
            StringBuilder firstFour = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                firstFour.Append(text[i]);
            }
            Console.WriteLine(firstFour.ToString());
        }

        public static string FindDomain(string email)
        {
            int atIndex = email.IndexOf('@');
            if (atIndex != -1)
            return email.Substring(atIndex + 1);
            return string.Empty;
        }

        public static bool IsOnlyLetters(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;
            StringBuilder nonLetterBuilder = new StringBuilder();
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                    nonLetterBuilder.Append(c);
            }
            return nonLetterBuilder.Length == 0;
        }

        public static string Capitalize(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;
            StringBuilder result = new StringBuilder();
            result.Append(char.ToUpper(text[0]));
            for (int i = 1; i < text.Length; i++)
            {
                result.Append(char.ToLower(text[i]));
            }
            return result.ToString();
        }

        static string[] FirstNames(string[] fullNames)
        {
            string[] firstNames = new string[fullNames.Length];

            for (int i = 0; i < fullNames.Length; i++)
            {
                int spaceIndex = fullNames[i].IndexOf(' '); 
                if (spaceIndex >= 0)
                    firstNames[i] = fullNames[i].Substring(0, spaceIndex);
                else
                    firstNames[i] = fullNames[i]; 
            }
            return firstNames;
        }

    }
}
