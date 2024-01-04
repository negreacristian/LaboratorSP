using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SPLab
{
    public class Program
    {
        static void Main()
        {
            var startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            ImageProxy img1 = new ImageProxy("Pamela Anderson");
            ImageProxy img2 = new ImageProxy("Kim Kardashian");
            ImageProxy img3 = new ImageProxy("Kirby Griffin");

            Section playboyS1 = new Section("Front Cover");
            playboyS1.Add(img1);

            Section playboyS2 = new Section("Summer Girls");
            playboyS2.Add(img2);
            playboyS2.Add(img3);

            Book playboy = new Book("Playboy");
            playboy.Add(playboyS1);
            playboy.Add(playboyS2);

            var endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            // var creationTime = endTime - startTime;
            Console.WriteLine($"Creation of the content took {endTime - startTime} milliseconds");

            startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

            playboyS1.Print();
            endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Console.WriteLine($"Printing of the section 1 took {endTime - startTime} milliseconds");

            startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            playboyS1.Print();
            endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            Console.WriteLine($"Printing again the section 1 took {endTime - startTime} milliseconds");
        }
    }
}
