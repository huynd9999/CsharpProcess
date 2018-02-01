using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bai 1
            Console.WriteLine("Chuong trinh ReverseString");
            ReverseString reverseString = new ReverseString();
            reverseString.Display();
            Console.WriteLine("==========");
            // Bai 2
            Console.WriteLine("Chuong trinh LengthCounter");
            LengthCounter lengthCounter = new LengthCounter();
            lengthCounter.Display();
            Console.WriteLine("==========");
            // Bai 3
            Console.WriteLine("Chuong trinh Draw");
            Draw draw = new Draw();
            draw.Display();
            Console.WriteLine("==========");
            Console.WriteLine("Chuong trinh Palindrome");
            Console.WriteLine("==========");
            // Bai 4
            Console.WriteLine("Chuong trinh Palindrome");
            Palindrome palindrome = new Palindrome();
            palindrome.Display();
            Console.WriteLine("==========");
            // Bai 5
            Console.WriteLine("Chuong trinh FizzBuzz");
            FizzBuzz fizzBuzz = new FizzBuzz();
            fizzBuzz.Display();
            Console.WriteLine("==========");
        }
    }

    // Bai 1: 
    class ReverseString
    {
        private string str = "";
        public ReverseString()
        {
            Console.Write("Nhap vao 1 chuoi: ");
            this.str = Console.ReadLine();
        }
        
        public void Display()
        {
            str = str.Replace(" ", string.Empty);
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write(arr[i] + "-");
            }
            Console.Write(arr[arr.Length-1]);
            Console.WriteLine();
        }
    }

    // Bai 2: 
    class LengthCounter 
    {
        private string str = "";
        public LengthCounter()
        {
            Console.Write("Nhap vao 1 chuoi: ");
            this.str = Console.ReadLine();
        }

        public void Display()
        {
            int count = 0;
            // char[] arr = str.ToCharArray();
            foreach (Char c in str)
            {
                count++;
            }
            Console.WriteLine("Chieu dai chuoi la: {0}", count);
        }
    }

    // Bai 3: 
    class Draw 
    {
        private int SoHang;
        public Draw()
        {
            Console.WriteLine("Nhap vao so hang: ");
            this.SoHang = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            for (int i = 1; i <= SoHang; i++) 
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
            Console.WriteLine();
            }    
        }
    }

    // Bai 4: 
    class Palindrome
    {
        private string str = "";
        public Palindrome()
        {
            Console.Write("Nhap vao 1 chuoi: ");
            this.str = Console.ReadLine();
        }
        public void Display()
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string newStr = new string(arr);
            if (str.Equals(newStr))
                Console.WriteLine("Chuoi la Palindrome");
            else
                Console.WriteLine("Chuoi khong phai la Palindrome");
        }
    }

    // Bai 5: 
    class FizzBuzz
    {
        public FizzBuzz()
        {
        }
        public void Display()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
