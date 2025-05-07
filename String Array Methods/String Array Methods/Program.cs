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

            text = text.ToLower().Replace(" ", "");

            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                    return false;
            }

            return true;
        }

        public static string RemoveDuplicateCharacters(string text)
        {
            string result = "";


            foreach (char c in text)
            {
                if (result.IndexOf(c) == -1)
                    result += c;
            }

            return result;
        }

        public static void PrintWords(string text)
        {
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                    Console.WriteLine(word);
            }

        }

        public static void PrintFirstFourChars(string text)
        {
            if (text.Length >= 4)
                Console.WriteLine(text.Substring(0, 4));
            else
                Console.WriteLine("Metnde 4 ve ya daha cox simvol yoxdur");
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
            foreach (char c in text)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public static string Capitalize(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            string firstLetter = text.Substring(0, 1).ToUpper(); 
            string remainingText = text.Substring(1).ToLower(); 
            return firstLetter + remainingText; 
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
