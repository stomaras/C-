using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateIndustry.Services
{
    class InputServiceShopEntity
    {
        public List<string> ShopNames { get; set; }

        public List<string> StreetNames { get; set; }
        public List<string> Areas { get; set; }
        public string[] lines { get; set; }

        public string[] col { get; set; }

        public string Path = @"C:\Users\spyros\source\repos\ChocolateIndustry\ChocolateIndustry\ExternalSources\ShopNames.txt";
        public string StreetPath = @"C:\Users\spyros\source\repos\ChocolateIndustry\ChocolateIndustry\ExternalSources\ShopStreets.txt";
        public string AreaPath = @"C:\Users\spyros\source\repos\ChocolateIndustry\ChocolateIndustry\ExternalSources\Areas.txt";
        public InputServiceShopEntity()
        {
            
            ShopNames = readShopNames(Path);
            StreetNames = readStreetNames(StreetPath);
            Areas = readAreaNames(AreaPath);
        }

        public List<string> readStreetNames(string filePath)
        {
            List<string> streetNames = new List<string>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    col = line.Split(' ');
                    
                    string street = " ";
                    for (int i = 0; i <= line.Length - 1; i++)
                    {

                        if (line[i] != ',')
                        {
                            char c = line[i];
                            street = street + c.ToString();
                        }
                    }
                    streetNames.Add(street);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return streetNames;
        }

      

        public List<string> readAreaNames(string AreaPath)
        {
            List<string> areaNames = new List<string>();

            try
            {
                string[] lines = File.ReadAllLines(AreaPath);

                foreach (string line in lines)
                {
                    col = line.Split(' ');

                    string area = " ";
                    for (int i = 0; i <= line.Length - 1; i++)
                    {

                        if (line[i] != ',')
                        {
                            char c = line[i];
                            area = area + c.ToString();
                        }
                    }
                    areaNames.Add(area);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return areaNames;
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
                    
                    string shopName = " ";
                    for (int i=0; i<= line.Length-1; i++)
                    {
                        
                        if(line[i] != ',')
                        {
                            char c = line[i];
                            shopName = shopName + c.ToString();
                        }
                    }
                    shopNames.Add(shopName);


                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return shopNames;
        }
    }
}
