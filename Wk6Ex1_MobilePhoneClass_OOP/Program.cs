using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6Ex1_MobilePhoneClass_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Goal: Create a class to hold studnet information.
            // Include a constructor to initialize the properties.
            // Have a module within the class to display their information.
            // Create three students(objects of the student class) and display their information.

            // Initialize the first student. Name him Jonothan, give him the id 123123, set his age to 20, and name his course about children and grandmas scripting
            Student student1 = new Student("Jonothan", 123123, 20, "Web Design for Babies and Old People");
            // Initialize the second student. Name her Maria, give her the id 456456, set her age to 45, and name her course about robots sewing
            Student student2 = new Student("Maria", 456456, 45, "Teach Your Robot to Sew Socks");
            // Initialize the third student. Name them Ambigous Ghost, give them the id 789789, set their age to 105, and name their course about something very normal and not suspicious or legally concerning at all.
            Student student3 = new Student("Ambiguous Ghost", 789789, 105, "NDAs About Radioative Water and How Long They Last");

            // display the info for student 1
            student1.DisplayStudentInfo();

            // display the info for student 2
            student2.DisplayStudentInfo();

            // display the info for student 3
            student3.DisplayStudentInfo();
        }
    }


    // Student Class

    class Student
    {
        // Properties/Attributes/Field Names
        public string Name;        // Declare an attribute of the class to hold a student's name
        public int ID;          // Declare an attribute of the class to hold a student's ID
        public int Age;          // Declare an attribute of the class to hold a student's ID
        public string Course;          // Declare an attribute of the class to hold a student's ID


        // Constructor
        // (Needs to have the same name as the class)
        public Student(string aName, int aID, int aAge, string aCourse)
        {
            Name = aName;       // set the Name of the student object in the student class to be the name we type
            ID = aID;       // set the ID of the student object in the student class to be the ID we type
            Age = aAge;     // set the Age of the student object in the student class to be the Age we type
            Course = aCourse;       // set the course of the student object in the student class to be the course we type
        }


        // Methods

        // Method to display all student information
        public void DisplayStudentInfo()
        {
            // print student details
            Console.WriteLine($"Student Information\n" +      // title
                $"Name: {Name}\n" +     // output name of student
                $"ID: {ID}\n" +     // output the student's ID number
                $"Age: {Age}\n" +       // output the student's age
                $"Course: {Course}\n");       // output the student's course. End with a line break for readability
        }
    }



}
