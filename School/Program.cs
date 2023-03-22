using System;

namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Teacher teacher = new Teacher();
            teacher.teacherName = "İbrahim";
            teacher.teacherSurname = "İnan";
            teacher.teacherId = 1;

            Student student = new Student();
            student.studentName = "Ahmet";
            student.studentSurname = "Özdemir";
            student.studentId = 1;

            Book book = new Book();
            book.bookName = "Harry Potter";
            book.bookId = 1;

            MyLibrary myLibrary = new MyLibrary();
            myLibrary.BookGiveOperation(book, student, teacher);

            Console.ReadKey();

        }
    }
}
