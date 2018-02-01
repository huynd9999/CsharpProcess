using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bai 1
            Console.WriteLine("Chuong trinh PrimeNumber");
            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.Display();
            Console.WriteLine("==========");

            // Bai 2 
            Console.WriteLine("Chuong trinh Fibonacci");
            Fibonacci fibonacci = new Fibonacci();
            
            fibonacci.Display();
            Console.WriteLine("==========");

            // Bai 3 
            Console.WriteLine("Chuong trinh Fibonacci_N");
            Fibonacci_N fibonacci_N = new Fibonacci_N();
            fibonacci_N.Display();
            Console.WriteLine("==========");

            // Bai 4
            Console.WriteLine("Chuong trinh LCD");
            LCM lCM = new LCM();
            lCM.Display();
            Console.WriteLine("==========");

            // Bai 5
            Console.WriteLine("Chuong trinh GCD");
            GCD gCD = new GCD();
            gCD.Display();
            Console.WriteLine("==========");
        }
    }

    // Bai 1: 
    class PrimeNumber 
    {
        private int x;
        public PrimeNumber()
        {
            Console.Write("Nhap vao 1 so: ");
            this.x = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            bool laSoNguyenTo = true;
            for (int i = 2; i <= (x/2); i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("{0} khong phai la so nguyen to", x);
                    laSoNguyenTo = false;
                    break;
                }
            }
            if (laSoNguyenTo)
            {
                Console.WriteLine("{0} la so nguyen to", x);
            }
        }
    }

    // Bai 2: 
    class Fibonacci
    {
        private int n;
        public Fibonacci()
        {
            Console.Write("Nhap so phan tu trong day Fibonacci: ");
            this.n = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            if (n == 1) 
            {
                Console.WriteLine("Day Fibonacci: {0}", n1);
            }
            else if (n == 2)
            {
                Console.WriteLine("Day Fibonacci: {0}, {1}", n1, n2);
            }
            else
            {
                Console.Write("Day Fibonacci: {0}, {1}", n1, n2);
                for (int i = 3; i <= n; i++)
                { 
                    n3 = n1 + n2; 
                    n1 = n2; 
                    n2 = n3; 
                    Console.Write(", {0}", n3);
                }
                Console.WriteLine();
                Console.WriteLine(n2);
            }
        }
    }

    // Bai 3: 
    class Fibonacci_N 
    { 
        private int n;
        public Fibonacci_N()
        {
            Console.Write("Nhap so phan tu trong day Fibonacci: ");
            this.n = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            if (n == 1)
            {
                Console.WriteLine("So Fibonacci thu {0} la: {1}", n, 0);
            }
            else if (n == 2)
            {
                Console.WriteLine("So Fibonacci thu {0} la: {1}", n, 1);
            }
            else 
            {
                for (int i = 3; i <= n; i++)
                {
                    n3 = n1 + n2; 
                    n1 = n2; 
                    n2 = n3;
                }
                Console.WriteLine("So Fibonacci thu {0} la: {1}", n, n2);
            }
        }
    }
    
    // Bai 4:
    class LCM
    {
        private int a;
        private int b;
        public LCM()
        {
            Console.Write("Nhap vao so thu nhat: ");
            this.a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            this.b = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Boi so chung nho nhat la: 0");
            }
            else  
            {
                int temp = 1;
                int n = (a < b) ? a : b;
                for (int i = 1; i <= n; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        temp = i;
                    }
                } 
                Console.WriteLine("Boi so chung nho nhat la {0}", (a * b)/temp);
            }
        }
    }

    // Bai 5: 
    class GCD 
    {
        private int a;
        private int b;
        public GCD()
        {
            Console.Write("Nhap vao so thu nhat: ");
            this.a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            this.b = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            if (a != 0 && b == 0)
            {
                Console.WriteLine("Uoc so chung lon nhat la: {0}", a);
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("Uoc so chung lon nhat la: {0}", b);
            }
            else 
            {
                int temp = 1;
                int n = (a < b) ? a : b;
                for (int i = 1; i <= n; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        temp = i;
                    }
                }
                Console.WriteLine("Uoc so chung lon nhat la: {0}", temp);
            }
        }
    }
}
