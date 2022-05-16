using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoStage1.Domain;
namespace KinoStage1.Services
{
    class PrintService
    {

        public static void PrintMessageAboutWinsAndKinoBonus(int count, bool KinoBonus)
        {
            if (KinoBonus)
            {
                Console.WriteLine($"\t\t\t\tUser catch {count} / 6 numbers and win Kino Bonus");
            }
            else
            {
                Console.WriteLine($"\t\t\t\tUser catch {count} / 6 numbers and lost Kino Bonus");
            }
        }

        public static void PrintMessageAboutWins(int count)
        {
            Console.WriteLine($"\t\t\t\tUser catch {count} / 6 numbers");
        }

        public static void PrintPlayer(Player player)
        {
            Console.WriteLine(player);
        }

        public static void PrintLottery(Lottery lottery)
        {
            Console.WriteLine(lottery);
        }

        public static void PrintLineSeperator()
        {
            Console.WriteLine("--------------------------------------------------------");
        }
        
        public static void PrintLineSeperatorLotteryStart()
        {
            Console.WriteLine("------------------Lottery--------------------------------");
            Console.WriteLine("---------------------------------------------------------");
        }

        public static void PrintLineSeperatorLotteryEnd()
        {
            Console.WriteLine("-----------------------Lottery End--------------------------");
        }
    }
}
