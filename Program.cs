using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        class student
        {
            public string name;
            public int roll_no;
            public float cgpa;
            public char isHostalide;
            public string department;
        }
        static void Main(string[] args)
        {
            student[] s = new student[10];
            int count = 0;
            char option;
            do
            {
                option = Menu();
                if (option == '1')
                {
                    s[count] = addStudent();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    viewStudent(s, count);

                }
                else if (option == '3')
                {
                    topStudent(s, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid choice");
                }
            }
            while (option != 4);
            Console.WriteLine("press enter to exit");
            Console.Read();
        }
           static void task1()
            {
                student s1 = new student();
                s1.name = "musa";
                s1.roll_no = 116;
                s1.cgpa = 3.4F;

                Console.WriteLine("student name {0}", s1.name);
                Console.WriteLine("roll no {0}", s1.roll_no);
                Console.WriteLine("cgpa {0}", s1.cgpa);
                Console.ReadKey();

            }
            static void task2()
            {


                student s2 = new student();
                s2.name = "ali";
                s2.roll_no = 23;
                s2.cgpa = 3.5F;
                Console.WriteLine("name {0} rollno {1} cgpa {2}", s2.name, s2.roll_no, s2.cgpa);
                Console.ReadKey();
            }
            static void task3()
            {
                student s3 = new student();
                Console.WriteLine("enter user name :");
                s3.name = Console.ReadLine();
                Console.WriteLine("enter roll no :");
                s3.roll_no = int.Parse(Console.ReadLine());
                Console.WriteLine("enter cgpa :");
                s3.cgpa = float.Parse(Console.ReadLine());


                Console.ReadKey();
            }
            static void task4()
        {
            char option;
            option =Menu();

        }
        static char Menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("enter 1 for add student ");
            Console.WriteLine("enter 2 for view student ");
            Console.WriteLine("enter 3 for top three student ");
            Console.WriteLine("enter 4 EXIT ");
            choice = char.Parse(Console.ReadLine());
            return choice;

        }
        static student addStudent()
        {
            Console.Clear();
            student s1 = new student();
            Console.WriteLine("enter user name :");
            s1.name = Console.ReadLine();
            Console.WriteLine("enter roll no :");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("enter cgpa :");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("enter department ");
            s1.department = Console.ReadLine();
            Console.WriteLine("IS hostalide(y or n) ");
            s1.isHostalide = char.Parse( Console.ReadLine());
            return s1;
        }
        static void viewStudent(student[] s,int count)
        {
            Console.Clear();
            for(int x=0;x<count;x++)
            {
                Console.WriteLine("name: {0} rollno: {1} cgpa: {2} department: {3} ishostalide: {4}", s[x].name, s[x].roll_no,s[x].cgpa, s[x].department, s[x].isHostalide);
            }
            Console.WriteLine("press any key to continue..");
            Console.ReadKey();
        }
        static int largest(student[] s,int start, int end)
        {
            int index = start ;
            float large = s[start].cgpa;
            for(int x =start;x<end;x++)
            {
                if(large < s[x].cgpa)
                {
                    large = s[x].cgpa;
                    index = x;
                }
            }
            return index;
        }
        static void topStudent(student[] s,int count)
        {
            Console.Clear();
            if(count ==0)
            {
                Console.WriteLine("no record present");

            }
            else if (count ==1)
            {
                viewStudent(s, 1);
            }
            else if (count ==2)
            {
                for(int i=0;i<2;i++)
                {
                    int index = largest(s, i, count);
                    student temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                viewStudent(s, 2);
            }
            else if(count == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    int index = largest(s, i, count);
                    student temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                viewStudent(s, 3);
            }
        }



    }
}
