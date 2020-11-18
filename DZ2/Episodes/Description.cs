using System;
using System.Collections.Generic;
using System.Text;

namespace Episodes
{
    public class Description
    {
        private int NumberOfEpisode;
        private TimeSpan EpisodeDuration;
        private string EpisodeName;

        public int GetNumberOfEpisode() => NumberOfEpisode;
        public TimeSpan GetEpisodeDuration() => EpisodeDuration;
        public string GetEpisodeName() => EpisodeName;
       
        public Description(int numberofepisode, TimeSpan episodeduration, string episodename)
        {
            NumberOfEpisode = numberofepisode;
            EpisodeDuration = episodeduration;
            EpisodeName = episodename;
        }
    }
}
