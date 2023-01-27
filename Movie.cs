using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___Classes__Fields__Properties__and_Constructors_
{
    public class Movie
    {
        //Fields - Variables (make them public)

        public string movieName;
        public double movieRating;
        public string director;
        public int year;


        public string MovieName
        {
            get
            {
                return movieName;
            }
            set
            {
                movieName = value;
            }
        }
        public double MovieRating
        {
            get
            {
                return movieRating;
            }
            set
            {
                movieRating = value;
            }
        }
        public string Director
        {
            get
            {
                return director;
            }
            set
            {
                director = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

    }

   


}
