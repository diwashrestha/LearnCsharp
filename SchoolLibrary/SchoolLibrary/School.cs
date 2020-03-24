using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            // make sure the twitter address starts with @
            get { return _twitterAddress; }
            set
            {
                if(value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }else
                {
                    throw new Exception ( "The twitter address must begin with @" );
                }
            }

        }

        // Constructor
        public School()
        {
            Name = "Untitled School";
            Phone = "01-734567";
        }

        public School(string schoolName, string schoolPhone)
        {
            Name = schoolName;
            Phone = schoolPhone;

        }

        //Methods
        // Method Overloading
        public static float averageThreeScores(float a, float b, float c)
        {
            var result = (a + b + c ) / 3;
            return result;
        }


/*        public int averageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) /  3;
            return result;
        }*/
        
            // function bodied expressions
        public static int averageThreeScores(int a, int b, int c) => (a + b + c) /3;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.AppendLine(City);
            sb.Append(", ");
            sb.Append(Province);
            sb.Append(" ");
            sb.Append(Zip);

            return base.ToString();
        }
    }
}
