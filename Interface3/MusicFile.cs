using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    abstract class MusicFile
    {
        private string title;

        public string Music_Title
        {
            get { return title; }
            set { title = value; }
        }
        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        private int Releaseyear;

        public int Release_Year
        {
            get { return Releaseyear; }
            set { Releaseyear = value; }
        }
        private int durationInSeconds;

        public int DurationInSeconds
        {
            get { return durationInSeconds; }
            set { durationInSeconds = value; }
        }
        public MusicFile()
        {
        }
        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.Releaseyear = Releaseyear;
            this.durationInSeconds = durationInSeconds;
           
        }
        public void changeTitle(string newTitle)
        {
            title = newTitle;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Music Title : " + title);
            Console.WriteLine("Artist : " + artist);
            Console.WriteLine("Release Year : " + Releaseyear);
            Console.WriteLine("Duration  " + durationInSeconds + " Seconds");
        }
    }
}