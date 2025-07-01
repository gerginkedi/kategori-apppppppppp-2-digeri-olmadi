using System.Net.Sockets;

namespace elenktrinecek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActive1 = true;
            bool isActive2 = true;
            bool isExist = true;
            string categoryForLooking = string.Empty;
            string itemOrExit = string.Empty;
            string categoryNameWhichWillBeCompleted = string.Empty;
            string itemNameWillBeAdded = string.Empty;
            bool index = true;
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

            while (isActive1)
            {
                Console.WriteLine(" Hangi kategoriye item ekleme islemi yapilsin");
                Console.WriteLine("(cikmak icin 0)");
                Console.WriteLine("===================================");

                foreach (string kategoriler in categoryNamesComeFromSuffixer)
                {
                    Console.WriteLine(kategoriler.ToUpper());
                }
                while (true)
                {
                    Console.Write("Kategori ismi: ");
                    Console.Write("(cikmak icin 0)");
                    categoryNameWhichWillBeCompleted = Console.ReadLine().ToLower();

                    foreach (string check in categoryNamesComeFromSuffixer)
                    {
                        index = true;
                        if (categoryNameWhichWillBeCompleted == check || categoryNameWhichWillBeCompleted == "0")
                        {
                            index = false;
                            break;
                        }
                    }
                    if (index)
                    {
                        Console.WriteLine("kategori isimini dogru gir");
                    }
                    else
                    {
                        break;
                    }
                }

                if (categoryNameWhichWillBeCompleted == "0")
                {
                    break;
                }
                else
                {
                    foreach (string categoryThatWillBeCompleted in categoryNamesComeFromSuffixer)
                    {
                        if (categoryThatWillBeCompleted == categoryNameWhichWillBeCompleted)
                        {
                            break;
                        }
                    }//kategoriyi bulduk

                    while (isActive2)
                    {
                        Console.Write("eklenecek item adi giriniz: ");
                        Console.Write("(cikmak icin 0)");
                        itemNameWillBeAdded = Console.ReadLine().ToLower();

                        if (itemNameWillBeAdded == "0")
                        {
                            break;
                        }
                        menu[categoryNameWhichWillBeCompleted].Add(itemNameWillBeAdded);
                    }
                }
            }




            Console.WriteLine("/////////////////////////////////////////////////////////////");
            Console.WriteLine("                             MENU");

            //foreach (string keyValues in menu.Keys)
            //{
            //    Console.WriteLine(keyValues.ToUpper());

            //    foreach (List<string> values in menu.Values)
            //    {
            //        //zatne bende olan keyleri sira sira donmek yerine valuesdaki tum degerleri dondum yanlis kod
            //        foreach (string item3 in values)
            //        {
            //            Console.WriteLine(item3);
            //        }
            //    }
            //}

            foreach (string keyValues in menu.Keys)
            {
                Console.WriteLine(keyValues.ToUpper());

                foreach (var values in menu[keyValues])
                {
                    Console.WriteLine(values);
                }
            }
        }
    }
}
