using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Vẽ hình tam giác.");
            Console.WriteLine("2. Vẽ hình vuông.");
            Console.WriteLine("3. Vẽ hình chữ nhật.");
            Console.WriteLine("0. Exit.");
            Console.WriteLine("Mời nhập lựa chọn của bạn :");
            choice=int.Parse(Console.ReadLine());
            while (choice != 0)
            {
               switch (choice)
                {
                    case 1:
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                        break;
                    case 2:
                        Console.WriteLine("*****");
                        Console.WriteLine("*****");
                        Console.WriteLine("*****");
                        break;
                    case 3:
                        Console.WriteLine("*******");
                        Console.WriteLine("*******");
                        Console.WriteLine("*******");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không có trong menu.");
                        break;
                }
                Console.WriteLine("Menu");
                Console.WriteLine("1. Vẽ hình tam giác.");
                Console.WriteLine("2. Vẽ hình vuông.");
                Console.WriteLine("3. Vẽ hình chữ nhật.");
                Console.WriteLine("0. Exit.");
                Console.WriteLine("Mời nhập lựa chọn của bạn :");
                choice = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
