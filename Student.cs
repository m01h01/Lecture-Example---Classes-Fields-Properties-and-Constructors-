using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___Classes__Fields__Properties__and_Constructors_
{
    public class Student
    {
    //Fields
         string firstName;
         string lastName;
         double csiGrade;
         double GenEdGrade;


        public Student(string FirstName, string LastName, double cis, double gened)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.csiGrade = cis;
            this.GenEdGrade = gened;
        
        }
        public Student(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.csiGrade = -1;
            this.GenEdGrade = -1;
        }
        public string FirstName
        {
            get 
            {
                return firstName;
            }
            set 
            {
                firstName = value;
            
            }
        
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;

            }

        }
        public double CSIGrade
        {
            get
            {
                return csiGrade;
            }
            set
            {
                csiGrade = value;

            }

        }
        public double GENedGrade
        {
            get
            {
                return GenEdGrade;
            }
            set
            {
                GenEdGrade = value;

            }

        }
    }
}
