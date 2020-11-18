using System;
using System.Globalization;


namespace Episodes
{
    public class TvUtilities
    {
     
        public static double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * 10;

        }
   
        
        public static Episode Parse(string line)
        {
            NumberFormatInfo dot = new NumberFormatInfo();
            dot.NumberDecimalSeparator = ".";
            string[] entries = line.Split(',');
            //Predpostavljamo da su podaci u datoteci jednaki,tj. da svaka linija ima sve ove podatke 
            var viewers = int.Parse(entries[0]);
            var sum = Convert.ToDouble(entries[1], dot);
            var maxGrade = Convert.ToDouble(entries[2], dot);
            var numberOfEpisode = int.Parse(entries[3]);
            TimeSpan lengthOfEpisode = new TimeSpan();
            lengthOfEpisode = TimeSpan.Parse(entries[4]);
            string nameOfTheEpisode = entries[5];
            Description description = new Description(numberOfEpisode, lengthOfEpisode, nameOfTheEpisode);
            Episode episode = new Episode(viewers, sum, maxGrade, description);
            return episode;

        }  
        public static void swap(Episode a, Episode b)
        {
            Episode temp = a;
            b = a;
            a = temp;
        }
        public static void Sort(Episode[] episode)
        {
           for (int i=0;i<episode.Length;i++)
            {
                for (int j=0;j<episode.Length;j++)
                {
                    if(episode[i]>episode[j])
                    {
                        swap(episode[i], episode[j]);
                    }
                }
            }
        }
       
    }
}
