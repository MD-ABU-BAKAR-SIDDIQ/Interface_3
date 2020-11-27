using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    class Phone : MusicFile, MusicPlayerInterface
    {
        private MusicFile[] musicFiles;
        private int musicFileCount;
        public int MusicFileCount
        {
            get { return musicFileCount; }
            set { musicFileCount = value; }
        }
        public Phone()
        {
            musicFiles = new MusicFile[500];
            musicFileCount = 0;
        }
        public Phone(string title, string artist, int yearOfRelease, int durationInSeconds) : base(title, artist, yearOfRelease, durationInSeconds)
        {
            musicFiles = new MusicFile[500];
            musicFileCount = 0;

        }
        public void switchs(bool currentMode)
        {
            bool start = true;
            bool stop = false;
            if (currentMode == true)
            {
                Console.Write("The Music Player Switch on");
            }
            else
            {
                Console.Write("The Music Player Switch Off ");
            }
        }
        public void play(bool currentMode)
        {
            bool start = true;
            bool stop = false;
            if (currentMode == true)
            {
                Console.WriteLine("The Music Player Is Playing ");
            }
            else
            {
                Console.WriteLine("The Music Player Is Not Playing ");
            }
        }
        public void setVolume(int loudnessl)
        {

            if (loudnessl >= 0)
            {
                Console.WriteLine("The Music Player Loudness Level  : " + loudnessl);
            }
            else
            {
                Console.WriteLine("Volume Set on ''0'' ");
                Console.WriteLine("The Music Player Music Loudness Level " + loudnessl + "Considered As 0 Level Loudness.");
            }
        }
        public void retune(double frequencyl)
        {
            Console.WriteLine("The Radio Player Frequency No: " + frequencyl);
        }
        public void AddMusicFile(params MusicFile[] musicFiles)
        {
            foreach (var a in musicFiles)
            {
                if (musicFileCount < 500)
                {
                    this.musicFiles[musicFileCount++] = a;
                }
                else
                {
                    Console.WriteLine("Cannot Create " + a.Music_Title);
                }
            }
        }
        public void ShowAllMusicFile()
        {
            for (int i = 0; i < musicFileCount; i++)
            {
                this.musicFiles[i].ShowInfo();

            }
        }
        public void playNext()
        {
            Console.WriteLine("Next Music In The PlayList ");
            for (int i = 1; i < musicFileCount; i++)
            {
                this.musicFiles[i + 1].ShowInfo();
                break;
            }
        }

        public void playPrevious()
        {
            Console.WriteLine("Previous Music In The PlayList ");
            for (int i = 0; i < musicFileCount; i++)
            {
                this.musicFiles[i].ShowInfo();
                break;
            }
        }

        public void changeChannel()
        {
            Console.WriteLine("Change The Channel");
        }

    }

}
