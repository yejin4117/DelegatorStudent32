using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatorStudent32
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.Add(new Student("함기훈", 4.5));
            students.Add(new Student("박성래", 4.4));
            students.Add(new Student("마이콜", 1.0));

            students.Print();
            students.Print((s) =>
            {
                Console.WriteLine("*************");
                Console.WriteLine(" 이름:" + s.Name);
                Console.WriteLine(" 학점:" + s.Score);
            });
            students.Print((s) =>
            {
                Console.WriteLine("<student>");
                Console.WriteLine("  <name>" + s.Name + "</name>");
                Console.WriteLine("  <score>" + s.Score + "</score>");
                Console.WriteLine("</student>");
            });
        }
    }
}
