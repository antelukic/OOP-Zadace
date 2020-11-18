using System;
using System.Xml.Schema;

namespace Episodes
{
    public class Episode
    {

        public int NumberOfViews { get; private set; }
        public double SumOfGrades { get; private set; }
        public double MaxGrade { get; private set; }

        public Description EpisodeDescription { get; private set; }

        public Episode(int views, double sum, double maxgrade, Description episodedescription)
        {
            NumberOfViews = views;
            SumOfGrades = sum;
            MaxGrade = maxgrade;
            EpisodeDescription = episodedescription;
        }

        public Episode()
        {
        }

        public void AddView(double grade)
        {

            NumberOfViews++;
            SumOfGrades += grade;
            if (MaxGrade < grade)
            {
                MaxGrade = grade;
            }
        }
        public static bool operator >(Episode lhs, Episode rhs)
        {
            if (lhs is null) return rhs is null;
            if (lhs > rhs)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Episode lhs, Episode rhs)
        {
            if (lhs is null) return rhs is null;
            if (lhs < rhs)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return NumberOfViews + " " + SumOfGrades + " " + MaxGrade + " " + EpisodeDescription.GetNumberOfEpisode() 
                    + " " + EpisodeDescription.GetEpisodeDuration() + " " + EpisodeDescription.GetEpisodeName();
        }

    }

    
}
