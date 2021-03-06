using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoStage1.Domain;
using KinoStage1.Services;

namespace KinoStage1.Services
{
    class PlayerService
    {
        private List<Player> _players;

        public List<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }

        private List<Lottery> _Lotteries;

        public List<Lottery> Lotteries
        {
            get { return _Lotteries; }
            set { _Lotteries = value; }
        }


        private Lottery _lottery;

        public Lottery Lottery
        {
            get { return _lottery; }
            set { _lottery = value; }
        }



        public PlayerService(int numOfPlayers, bool kinoBonus)
        {
            Lottery = new Lottery();
            Players = GeneratePlayers(numOfPlayers, kinoBonus, Lottery);
           
        }

       public PlayerService(int numOfPlayers, bool kinoBonus, int numOfLotteries)
        {
            Lotteries = GenerateLotteries(numOfLotteries);
            for(int i=0; i<=Lotteries.Count-1; i++)
            {
                PrintService.PrintLineSeperatorLotteryStart();
                Lottery = new Lottery();
                
                Players = GeneratePlayers(numOfPlayers, kinoBonus, Lottery);
            }
        }

        public List<Lottery> GenerateLotteries(int numOfLotteries)
        {
            List<Lottery> lotteries = new List<Lottery>();
            for (int i = 0; i <= numOfLotteries-1; i++)
            {
                Lottery lottery = new Lottery();
                lotteries.Add(lottery);
            }
            return lotteries;
        }

        public List<Player> GeneratePlayers(int numOfPlayers, bool kinoBonus, Lottery lottery)
        {
            List<Player> players = new List<Player>();
            PrintService.PrintLottery(lottery);
            for (int i=0; i<= numOfPlayers-1; i++)
            {
                Player player = new Player(kinoBonus);
                if (kinoBonus)
                {
                    GeneratePlayersWithKinoBonus(player, lottery, kinoBonus);
                    players.Add(player);
                }
                else
                {
                    GeneratePlayersWithoutKinoBonus(player, lottery);
                    players.Add(player);
                }
                
            }
            return players;
        }

        private void GeneratePlayersWithKinoBonus(Player player, Lottery lottery, bool kinoBonus)
        {
           
            EvaluationService evaluationService = new EvaluationService(player, lottery, kinoBonus);
            int count = evaluationService.Count;
            bool kinoBonusss = evaluationService.CatchKinoBonusNumber;
            PrintService.PrintLineSeperator();
            PrintService.PrintPlayer(player);
            PrintService.PrintMessageAboutWinsAndKinoBonus(count, kinoBonusss);
            PrintService.PrintLineSeperator();
        }

        private void GeneratePlayersWithoutKinoBonus(Player player, Lottery lottery)
        {
            EvaluationService evaluationService = new EvaluationService(player, lottery);
            int count = evaluationService.Count;
            PrintService.PrintLineSeperator();
            PrintService.PrintPlayer(player);
            PrintService.PrintMessageAboutWins(count);
            PrintService.PrintLineSeperator();
        }
    }
}
