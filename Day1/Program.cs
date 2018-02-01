using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bai 1
            Console.WriteLine("Chuong trinh SimpleCalculator");
            SimpleCalculator simpleCalculator = new SimpleCalculator();
            simpleCalculator.Display();
            Console.WriteLine("==========");
            // Bai 2
            Console.WriteLine("Chuong trinh SwappingNumber");
            SwappingNumber swappingNumber = new SwappingNumber();
            swappingNumber.Display();
            Console.WriteLine("==========");
            // Bai 3
            Console.WriteLine("Chuong trinh DisplayInfo");
            DisplayInfo displayInfo = new DisplayInfo();
            displayInfo.Display();
            Console.WriteLine("==========");
            // Bai 4
            Console.WriteLine("Chuong trinh BinaryConverter");
            BinaryConverter binaryConverter = new BinaryConverter();
            binaryConverter.Display();
            Console.WriteLine("==========");
            // Bai 5
            Console.WriteLine("Chuong trinh CountVowels");
            CountVowels countVowels = new CountVowels();
            countVowels.Display();
            Console.WriteLine("==========");
        }
    }
    // Bai 1: 
    class SimpleCalculator
    {
        private double a;
        private double b;
        public SimpleCalculator()
        {
            
            Console.Write("Nhap vao so thu nhat: ");
            this.a = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            this.b = double.Parse(Console.ReadLine());
        }
        public void Display()
        {
            try {
                Console.WriteLine("Tong 2 so vua nhap la: {0}", a + b);
                Console.WriteLine("Hieu 2 so vua nhap la: {0}", a - b);
                Console.WriteLine("Tich 2 so vua nhap la: {0}", a * b);
                if  (b != 0)
                {
                    Console.WriteLine("Thuong 2 so vua nhap la: {0}", a / b);
                }
                else 
                {
                    Console.WriteLine("Khong the chia cho 0");
                }
            }
            catch(System.FormatException e) {
                Console.WriteLine(e.Message);
            }
            catch(DivideByZeroException e) {
                Console.WriteLine(e.Message); 
            }
        }
    }

    // Bai 2:
    class SwappingNumber
    {
        private double a;
        private double b;
        public SwappingNumber() 
        {
            Console.Write("Nhap vao so thu nhat: ");
            this.a = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            this.b = double.Parse(Console.ReadLine());
            Console.WriteLine("Truoc khi hoan doi gia tri: a = {0}, b = {1}", this.a, this.b);
        }
        public void Display() 
        {
            try {
                double temp;
                temp = a;
                a = b;
                b = temp;
                Console.WriteLine("Sau khi hoan doi gia tri: a = {0}, b = {1}", a, b);
            }
            catch(System.FormatException) {
                Console.WriteLine("Invalid Number");
            }
        }
    } 
    
    // Bai 3: 
    class DisplayInfo
    {
            private string Name;
            private int StudentID;
            private int Age;
            private string Class;
            private string SchoolName;
        public DisplayInfo()
        {
            Console.Write("Nhap vao ho ten: ");
            this.Name = Console.ReadLine();
            Console.Write("Nhap vao ma sinh vien: ");
            this.StudentID = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao tuoi: ");
            this.Age = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao lop: ");
            this.Class = Console.ReadLine();
            Console.Write("Nhap vao ten truong: ");
            this.SchoolName = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Ten sinh vien: {0}", Name);
            Console.WriteLine("Ma sinh vien: {0}", StudentID);
            Console.WriteLine("Tuoi sinh vien: {0}", Age);
            Console.WriteLine("Lop sinh vien: {0}", Class);
            Console.WriteLine("Truong sinh vien: {0}", SchoolName);
        }
    }

    // Bai 4: 
    class BinaryConverter 
    {
        private int x;
        public BinaryConverter()
        {
            Console.Write("Nhap vao 1 so nguyen: ");
            this.x = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            System.Console.WriteLine("Dang nhi phan cua so vua nhap la: {0}", Convert.ToString(x, 2));
        }
    }

    // Bai 5:
    class CountVowels 
    {
        private string str = "";
        public CountVowels() 
        {
            Console.Write("Nhap vao 1 chuoi: ");
            this.str = Console.ReadLine();
        }

        public void Display()
        {
            int countA = 0;
            int countE = 0;
            int countO = 0;
            int countU = 0;
            int countI = 0;
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'a' || arr[i] == 'A') {
                    countA++;
                }
                else if (arr[i] == 'e' || arr[i] == 'E') {
                    countE++;
                }
                else if (arr[i] == 'o' || arr[i] == 'O') {
                    countO++;
                }
                else if (arr[i] == 'u' || arr[i] == 'U') {
                    countU++;
                }
                else if (arr[i] == 'i' || arr[i] == 'I') {
                    countI++;
                }
            }
            Console.WriteLine("Co {0} nguyen am", countA + countE + countI + countO + countU);
            Console.WriteLine("Co {0} nguyen am 'a'", countA);
            Console.WriteLine("Co {0} nguyen am 'e'", countE);
            Console.WriteLine("Co {0} nguyen am 'o'", countO);
            Console.WriteLine("Co {0} nguyen am 'u'", countU);
            Console.WriteLine("Co {0} nguyen am 'i'", countI); 
        }
    }
}
