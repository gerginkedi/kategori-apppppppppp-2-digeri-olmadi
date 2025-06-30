using System.Net.Sockets;

namespace elenktrinecek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActive = true;
            bool isActive1 = true;
            string categoryForLooking = string.Empty;
            string itemOrExit = string.Empty;

            Suffixer suffixer = new Suffixer();

            Dictionary<string, List<string>> menu = new Dictionary<string, List<string>>();

            List<string> categoryNamesComeFromSuffixer = new List<string>();

            foreach (string item in suffixer.categoryItemSuffixer())
            {
                categoryNamesComeFromSuffixer.Add(item);
            }

            foreach (string item in categoryNamesComeFromSuffixer)
            {
                menu.Add(item, new List<string>());
            }

            while (isActive)
            {

                Console.WriteLine(" Hangi kategoriye item ekleme islemi yapilsin");
                Console.WriteLine("(cikmak icin 0)");
                Console.WriteLine("===================================");
                foreach (string kategoriler in categoryNamesComeFromSuffixer)
                {
                    Console.WriteLine(kategoriler.ToUpper());
                }



                //foreach (string item in categoryNamesComeFromSuffixer)
                //{
                //    categoryForLooking = Console.ReadLine();

                //    if (item == categoryForLooking)
                //    {
                //        while (isActive1)
                //        {
                //            Console.Write("eklenecek item adi giriniz: ");
                //            Console.Write("cikmak iicn 0");
                //            Console.WriteLine("///////////////");

                //            itemOrExit = Console.ReadLine();

                //            if (itemOrExit == "0")
                //            {
                //                isActive1 = false;
                //            }

                //            menu[categoryForLooking].Add(itemOrExit);
                //        }
                //    }

                //    else
                //    {
                //        Console.WriteLine("boyle bir kategori yok");
                //    }
                //}

                Console.WriteLine("//////////////////////////////////////////////////////////////////");
                Console.WriteLine(categoryForLooking.ToUpper());
                foreach (string sil in menu[categoryForLooking])
                {
                    Console.WriteLine(sil.ToLower());
                }

            }
        }
    }
}
