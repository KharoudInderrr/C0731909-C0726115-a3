using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C0731909_C0726115
{
    public delegate void Sort_DataStructure();
    class Program
    {
        static void Main(string[] args)
        {
            DataStructureStack a = new DataStructureStack();
            a.Run();
           

            Student s1 = new Student();
            s1.Announcement();
            AverageStudentGPA();


            Console.ReadLine();

        }
        static void AverageStudentGPA()
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();
            Student student5 = new Student();

            ArrayList stu = new ArrayList();
            stu.Add(student1);
            stu.Add(student2);
            stu.Add(student3);
            stu.Add(student4);
            stu.Add(student5);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(stu[0]);
            }
        }

    }

    class Student
    {
        String Student_name;
        String StudentID;
        double StudentGPA;

        // TODO: change this implementation so that the program pulls names from a Text File:
        // to do this, you must change the container for Student Names from Array to List
        String[] names = new String[5] { "Bill", "Mary", "Laura", "Sam", "Steve" };
        Random r1;

        public Student()
        {
            r1 = new Random();
            Student_name = names[r1.Next(0, 4)];
            StudentID = Convert.ToString(r1.Next(1000, 9999));
            StudentGPA = Convert.ToDouble(r1.Next(1, 99));
        }


        public void Announcement()
        {


            try
            {
                using (StreamReader sr = new StreamReader("U:/Users/731909/C0731909-C0726115/names.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public double AverageStudentGPA()
        {
            double sum = 0;
            // TO DO: implement the algorithm to calculate the Students' average GPA
            for (int i = 0; i < names.Length; i++)
            {
                sum += StudentGPA;
            }
            return StudentGPA;
        }

    }






    public interface IDataStructure
    {
        void Sort();
    }


    class DataStructureQueue : IDataStructure
    {
        // the QUEUE holds the classes (that is classroom of students!)
        // TO DO: insert the contents of the Data File: Classroom Data Set 

        public Queue q1 = new Queue();

        Sort_DataStructure Sort1;

        public void Sorter()
        {
            // TO DO : sort the Queue 
             // TO DO : sort the Queue 
            q1.Enqueue("Java - SAT - AM - A202");
            q1.Enqueue("Csharp - MON - PM - B122");
            q1.Enqueue("Math - FRI - AM - A506");
            q1.Enqueue("BigData - THU - B230");
            q1.Enqueue("Java - WED - PM - A202");
            q1.Enqueue("Csharp - THU - PM - B125");
            q1.Enqueue("Math - TUE - AM - B130");
            q1.Enqueue("EmergingTechnologies - FRI - B122");
            q1.Enqueue("MicrosoftDataStack - MON - PM - B122");
            q1.Enqueue("Math - MON - PM - B122");
            q1.Enqueue("Python - FRI - AM - B125");
            q1.Enqueue("JavaEE - FRI - PM - B230");
            q1.Enqueue("SignalProcessing - WED - PM - LAB1");
            q1.Enqueue("EmbeddedProcessor");

            foreach (Object obj in q1)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }

        public void Run()
        {
            for (int i = 0; i < 20; i++)
            {
                q1.Enqueue(new Student());
            }
            Sort1 = new Sort_DataStructure(Sorter);
        }
        public void Sort()
        {

        }

    }

    class DataStructureStack : IDataStructure
    {
        // the STACK holds the Students
        public Stack s1 = new Stack();

        Sort_DataStructure Sort1;

        public void Sorter()
        {
            // TO DO : sort the Stack
        }

        public void Run()
        {
            for (int i = 0; i < 20; i++)
            {
                s1.Push(new Student());
            }

            Sort1 = new Sort_DataStructure(Sorter);
        }

        public void Sort() { }
    }




    namespace BubbleSort
    {
        class MySort
        {
            static void Main2(string[] args)
            {
                int[] arr = { 78, 55, 45, 98, 13 };
                int temp;

                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    for (int i = 0; i <= arr.Length - 2; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            temp = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }

                Console.WriteLine("Sorted:");
                foreach (int p in arr)
                    Console.Write(p + " ");
                Console.Read();
            }
        }
    }
}