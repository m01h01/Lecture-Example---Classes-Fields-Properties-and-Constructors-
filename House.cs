using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___Classes__Fields__Properties__and_Constructors_
{
    public class House
    {
        public double price;
        public string room;
        public string bathroom;
        public double squareFt;

        public House (double price, string room, string bathroom, double sqaureft)
        {
            this.price = price;
            this.room = room;
           this.bathroom = bathroom;
            this.squareFt = sqaureft;
        }
        public House()
        { }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public double SquareFt
        {
            get
            {
                return this.squareFt;
            }
            set
            {
                this.squareFt = value;
            }
        }
        public string Room
        {
            get
            {
                return this.room;
            }
            set
            {
                this.room = value;
            }

        }
        public string Bathroom
        {
            get
            {
                return this.bathroom;
            }
            set
            {
                this.bathroom = value;
            }
        }



    }
}
