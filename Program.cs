using Assignment_CSharp_Demo.Implements;
using System;
using System.Text;

namespace Assignment_CSharp_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            StudentService studentService = new StudentService();
            int choice;

            while (true)
            {
                Console.WriteLine("\n====== Menu ======");
                Console.WriteLine("1. Nhập dữ liệu cho sinh viên");
                Console.WriteLine("2. Hiển thị toàn bộ sinh viên");
                Console.WriteLine("3. Tìm kiếm theo điểm và hiển thị sinh viên");
                Console.WriteLine("4. Tìm kiếm theo tên");
                Console.WriteLine("5. Thoát");
                Console.Write("Mời bạn chọn: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        studentService.InputData();
                        break;
                    case 2:
                        studentService.Display();
                        break;
                    case 3:
                        Console.Write("Nhập điểm thấp nhất: ");
                        double minScore = double.Parse(Console.ReadLine());
                        Console.Write("Nhập điểm cao nhất: ");
                        double maxScore = double.Parse(Console.ReadLine());
                        var studentsByScore = studentService.Search(minScore, maxScore);
                        foreach (var student in studentsByScore)
                        {
                            Console.WriteLine($"ID: {student.Id} \n" +
                                    $"Name: {student.Name}\n" +
                                    $"Math: {student.MathScore}\n" +
                                    $"Physics: {student.PhyScore}\n" +
                                    $"Chemistry: {student.CheScore}");
                        }
                        break;
                    case 4:
                        Console.Write("Nhập tên sinh viên cần tìm: ");
                        string name = Console.ReadLine();
                        var studentsByName = studentService.Search(name);
                        foreach (var student in studentsByName)
                        {
                            Console.WriteLine($"ID: {student.Id} \n" +
                                    $"Name: {student.Name}\n" +
                                    $"Math: {student.MathScore}\n" +
                                    $"Physics: {student.PhyScore}\n" +
                                    $"Chemistry: {student.CheScore}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Thoát chương trình...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Mời chọn lại.");
                        break;
                }
            }
        }
    }
}
