using System;
using System.Collections.Generic;
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
