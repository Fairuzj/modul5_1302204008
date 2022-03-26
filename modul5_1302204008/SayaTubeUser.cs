using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204008
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string username;

        public SayaTubeUser(string username)
        {
            Debug.Assert(username != null, "Username yang anda masukkan kosong!");
            Debug.Assert(username.Length <= 100, "Panjang karakter melebihi 100!");
            Contract.Requires(username != null && username.Length <= 100);
            Random random = new Random();
            this.username = username;
            this.id = random.Next(0, 100000);
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                total = total+video.getPlayCount();
            }
            return total;
        }
        public void addVideo(SayaTubeVideo v)
        {
            Debug.Assert(v != null, "KOSONG!");
            Debug.Assert(v.getPlayCount() <= 25000000, "Kebanyakan masukinnya!");
            this.uploadedVideos.Add(v);
        }
        public void PrintVideoDetails()
        {
            int i =0;
            Console.WriteLine("User: " + username);
            foreach(SayaTubeVideo video in uploadedVideos)
            {
                Console.WriteLine("Video " + (i+1) + " Judul: " + video.getTitle());
                i++;
            }
            Console.WriteLine();
        }

    }
}
