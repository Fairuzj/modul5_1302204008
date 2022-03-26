using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204008
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.title = title;
            this.id = random.Next(0, 100000);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int i)
        {
            this.playCount = this.playCount + 1;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Play Count : " + playCount);
            Console.WriteLine();
        }
        public int getPlayCount()
        {
            return playCount;
        }
        public String getTitle()
        {
            return title;
        }
    }
}
