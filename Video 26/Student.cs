using System;
using System.Collections.Generic;
using System.Text;

namespace Video_26
{
    class Student
    {
        // Fields /Variables

        private string studentNum, studentLastName, studentFirstName, major;
        private int score1, score2, score3;

        //Constructor

        //   Default

        public Student ()
        {

        }

        //Constuctor - One Arg

        public Student (string sID)
        {
            studentNum = sID;
        }

        // Constuctor - Three Arguments
        public Student(string sID, string lastName, string firstname)
        {

            studentNum = sID;
            studentLastName = lastName;
            studentFirstName = firstname;

        }

        public Student(string sID, string lastname, string firstName, string Major, int Score1, int Score2, int Score3)
        {
            this.studentNum = sID;
            this.studentLastName = lastname;
            this.major = Major;
            this.score1 = Score1;
            this.score2 = Score2;
            this.score3 = Score3;
        }

        // Properties

        
        public string StudentNum { get => studentNum; set => studentNum = value; }
        public string StudentLastName { get => studentNum; set => studentNum = value; }
        public string StudentFirstName { get => studentFirstName; set => studentFirstName = value; }
        public string Major { get => major; set => major = value; }
        public int Score1 { get => score1; set => score1 = value; }
        public int Score2 { get => score2; set => score2 = value; }
        public int Score3 { get => score3; set => score3 = value; }






        // Methods

        public double CalculateAverage()
        {


            return (score1 + score2 + score3) / 3.0;


        }

        public override string ToString()
        {
            return "Name :" = studentFirstName + " " + studentLastName +
                " /nMajor : " + major + " /nScore Average : " + CalculateAverage().ToString("F2");

        }



    }
}
