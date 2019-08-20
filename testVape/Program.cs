using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testVape
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxService bService = new BoxService();

            Box b1 = new Box
            {
                MinWatts = 1,
                MaxWatts = 80,
                Brand = "iStick Rim Leaf"
            };

            Box b2 = new Box
            {
                MinWatts = 1,
                MaxWatts = 80,
                Brand = "iKuu i80"
            };

            b1.Id = bService.Insert(b1);
            b2.Id = bService.Insert(b2);

            AtomiserService aService = new AtomiserService();

            Atomiser a1 = new Atomiser
            {
                MinWatt = 1,
                MaxWatt = 80,
                Brand = "TFV V8 Baby",
                Ml = 4,
                Resistance = 0.4
            };

            Atomiser a2 = new Atomiser
            {
                MinWatt = 1,
                MaxWatt = 60,
                Brand = "Melo 5",
                Ml = 5,
                Resistance = 0.2
            };

            a1.Id = aService.Insert(a1);
            a2.Id = aService.Insert(a2);

            MontageService mService = new MontageService();

            Montage m1 = new Montage
            {
                BoxId = b1.Id,
                AtomiserId = a2.Id,
                Nickname = "yolo"
            };


            m1.Id = mService.Insert(m1);
            Console.ReadKey();

        }
    }
}
