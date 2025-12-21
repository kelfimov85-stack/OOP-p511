using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_p511
{
    public class Student
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private double AverageGrade { get; set; }

        public Student(string name, int age, double averageGrade)
        {
            Name = name;
            Age = age;
            AverageGrade = averageGrade;
        }
        public override string ToString()
        {
            return $"{Name} {Age} {AverageGrade}";
        }
    }

    public class StudentManager
    {
        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Успешно добавлен");
        }
        public void PrintAllStudents()
        {
            foreach (Student student in students)
            {
                if (!students.Any()) 
                {
                    Console.WriteLine("Никого неь");
                    return;
                }

                Console.WriteLine(student.ToString());
            }
        }

        public void SaveToFile(string path)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    foreach(Student student in students)
                    {
                        streamWriter.WriteLine(student.ToString());
                    }
                }
            }   
            catch (Exception ex)
            {
                Console.WriteLine("ошибка неизвестно");
            }
        }

        public void LoadFromFile(string path)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    string line;

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine("s");
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Ощибка");
            }
        }
    }
}