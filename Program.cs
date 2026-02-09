namespace _5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine(IntPalindrome(1213));
            Console.WriteLine(IntPalindrome(12321));

            //2
            Console.WriteLine(SumOfDigits(12345));
            Console.WriteLine(SumOfDigits(20202020));

            //3
            int[] nums1 = { 1, 2, 3, 1 };
            int[] nums2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(AtLeast2Digits(nums1));
            Console.WriteLine(AtLeast2Digits(nums2));
        }

        //1
        public static bool IntPalindrome(int num) 
        {
            int originalNum = num;
            int reversed = 0;
            if (num < 0) return false;
            else
            {
                //O(n)
                while (num > 0)
                {
                    int lastDigit = num % 10;
                    reversed = reversed * 10 + lastDigit;
                    num = num / 10;
                }
            }
            return reversed == originalNum;
        }

        //2
        public static int SumOfDigits(int num)
        {
            int sum = 0;
            // O(n)
            while (num > 0)
            {
                int lastDigit = num % 10;
                sum += lastDigit;
                num = num / 10;
            }
            return sum;
        }

        //3
        public static bool AtLeast2Digits(int[] arr)
        { 
            // O(2n) or just O(n)
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (!frequency.ContainsKey(num))
                { 
                    frequency.Add(num, 1);
                }
                else 
                {
                    frequency[num]++;
                }
            }

            bool duplicates = false;
            foreach (int num in frequency.Values)
            {
                if (num > 1)
                { 
                    duplicates = true;
                    break;
                }
            }
            return duplicates;
        }
    }
}
