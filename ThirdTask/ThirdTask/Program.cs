using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Student studentObj = new Student();
            studentObj.StudentInfo();

        }
    }
    class Student
    {
        public string StudentName = "Arbjon";
        public int StudentGrade = 10;
    
    public void StudentInfo()
        {
            Console.WriteLine($"The student name: {StudentName}. \nThe student grade: {StudentGrade}.");
        }
    } 

}
