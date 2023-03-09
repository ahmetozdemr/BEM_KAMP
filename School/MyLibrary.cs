using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class MyLibrary
    {
        public void BookGiveOperation(Book book,Student student, Teacher teacher)
        {
            
            Console.WriteLine("Kitabı Alan Öğrenci Blgileri");
            Console.WriteLine($"Id :{student.studentId}");
            Console.WriteLine($"Ad :{student.studentName}");
            Console.WriteLine($"Soyad :{student.studentSurname}");
            Console.WriteLine("*********************************");
            Console.WriteLine("Kitabı Veren Öğretmen Blgileri");
            Console.WriteLine($"Id :{teacher.teacherId}");
            Console.WriteLine($"Ad :{teacher.teacherName}");
            Console.WriteLine($"Soyad :{teacher.teacherSurname}");
            Console.WriteLine("*********************************");
            Console.WriteLine("Kitap Blgileri");
            Console.WriteLine($"Id:{book.bookId}");
            Console.WriteLine($"Ad :{book.bookName}");
        }
    }
}
