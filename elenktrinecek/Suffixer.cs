using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elenktrinecek
{
    internal class Suffixer
    {

        public List<string> categoryItemSuffixer()
        {
            List<string> listToReturn = new List<string>();
            bool isActive = true;
            string categoryNameToAdd = string.Empty;
            string input = string.Empty;

            while (isActive)
            {

                Console.Write("eklenecek kategorinin adini giriniz: ");
                categoryNameToAdd = Console.ReadLine();
                listToReturn.Add(categoryNameToAdd.ToLower());
                Console.WriteLine("cikmak icin 0, devam etmek icin 1 yaziniz: ");
                input = Console.ReadLine();

                if (input == "0")
                {
                    isActive = false;
                }
            }
            return listToReturn;
        }
    }
}
