using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateIndustry.Services
{
    class InputService
    {
        public List<string> ShopNames { get; set; }
        public string[] lines { get; set; }

        public string[] col { get; set; }

        public string Path = @"C:\Users\spyros\source\repos\ChocolateIndustry\ChocolateIndustry\ExternalSources\ShopNames.txt";
        public InputService()
        {
            
            ShopNames = readShopNames(Path);
        }

        public List<string> readShopNames(string filePath)
        {
            List<string> shopNames = new List<string>();
            
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                
                foreach ( string line in lines)
                {
                    col = line.Split(',');
                    
                    string shop = " ";
                    for (int i=0; i<= line.Length-1; i++)
                    {
                        
                        if(line[i] != ',')
                        {
                            char c = line[i];
                            shop = shop + c.ToString();
                        }
                    }
                    shopNames.Add(shop);


                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return shopNames;
        }
    }
}
