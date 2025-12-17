using System;

public class Program
{
    public static void Main(string[] args)
    {
        int thang;

        Console.Write("Nhập tháng (1-12): ");
        thang = Convert.ToInt32(Console.ReadLine());

        switch (thang)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Tháng " + thang + " có 31 ngày");
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Tháng " + thang + " có 30 ngày");
                break;

            case 2:
                Console.WriteLine("Tháng 2 có 28 ngày");
                break;

            default:
                Console.WriteLine("Tháng không hợp lệ");
                break;
        }
    }
}
