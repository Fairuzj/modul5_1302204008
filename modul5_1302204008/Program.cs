using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser u1 = new SayaTubeUser("Fairuz");
            SayaTubeVideo v1 = new SayaTubeVideo("Review Film Game of Thrones Season 1 oleh Fairuz");
            SayaTubeVideo v2 = new SayaTubeVideo("Review Film Game of Thrones Season 2 oleh Fairuz");
            SayaTubeVideo v3 = new SayaTubeVideo("Review Film Game of Thrones Season 3 oleh Fairuz");
            SayaTubeVideo v4 = new SayaTubeVideo("Review Film Game of Thrones Season 4 oleh Fairuz");
            SayaTubeVideo v5 = new SayaTubeVideo("Review Film Game of Thrones Season 5 oleh Fairuz");
            SayaTubeVideo v6 = new SayaTubeVideo("Review Film Game of Thrones Season 6 oleh Fairuz");
            SayaTubeVideo v7 = new SayaTubeVideo("Review Film Game of Thrones Season 7 oleh Fairuz");
            SayaTubeVideo v8 = new SayaTubeVideo("Review Film Game of Thrones Season 8 oleh Fairuz");
            SayaTubeVideo v9 = new SayaTubeVideo("Review Film The Boys Season 1 oleh Fairuz");
            SayaTubeVideo v10 = new SayaTubeVideo("Review Film The Boys Season 2 oleh Fairuz");

            u1.addVideo(v1);
            u1.addVideo(v2);
            u1.addVideo(v3);
            u1.addVideo(v4);
            u1.addVideo(v5);
            u1.addVideo(v6);
            u1.addVideo(v7);
            u1.addVideo(v8);
            u1.addVideo(v9);
            u1.addVideo(v10);
            u1.PrintVideoDetails();

            Console.WriteLine("Test prekondisi dll");
            SayaTubeUser u2 = new SayaTubeUser("Ruziruz");
            SayaTubeVideo w1 = new SayaTubeVideo("");
            SayaTubeVideo w2 = new SayaTubeVideo("cobaan 2");
            w2.IncreasePlayCount(25000001);
            SayaTubeVideo w3 = new SayaTubeVideo("cobaan 3");
            u2.addVideo(w1);
            u2.addVideo(w2);
            u2.addVideo(w3);

        }
    }
}
