using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
            Debug.Assert(title != null, "Title yang anda masukkan kosong!");
            Debug.Assert(title.Length <= 200, "Panjang karakter melebihi 200!");
            Random random = new Random();
            this.title = title;
            this.id = random.Next(0, 100000);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int i)
        {
            Debug.Assert(i > 0, "PlayCount tidak boleh bernilai negative!");
            Debug.Assert(i <= 25000000, "Kebanyakan masukinnya!");
            try
            {
                if (i < 0)
                {
                    throw new Exception("Jangan kurang dari 0!!!");
                }
                else if (i > 25000000)
                {
                    throw new Exception("Kebanyakan masukinnya!!!");
                }
                else
                {
                    this.playCount = this.playCount + 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
