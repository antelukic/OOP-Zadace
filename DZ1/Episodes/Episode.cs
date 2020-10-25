using System;
using System.Xml.Schema;

namespace Episodes
{
    public class Episode
    {
        
        private int number_of_views;
        private double sum_of_views;
        private double max_grade;

        public Episode (int views, double sum, double maxgrade)
        {
            number_of_views = views;
            sum_of_views = sum;
            max_grade = maxgrade;
        }

        public Episode()
        {
        }

        public int GetViewerCount() => number_of_views;
        public double GetAverageScore() => sum_of_views / number_of_views;
        public double GetMaxScore () =>  max_grade;
        
        public void AddView(double grade)
        {
           
            number_of_views++;
            sum_of_views += grade;
            if(max_grade< grade)
            {
                max_grade = grade;
            }
        }

        public static double GenerateRandomScore()
        {
          Random random = new Random();
          return random.NextDouble() * 10;
            
        }




    }
}
