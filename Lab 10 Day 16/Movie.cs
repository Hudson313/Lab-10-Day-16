using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_Day_16
{
    public class Movie
    {

        public string Title = "";
        public string Category = "";
        public Movie(string title,string category) {

            Title = title;
            Category = category;

        }

       public bool HasCategory(string category) {

            bool matchCategory = category == Category;
          return matchCategory; }



    }
}
