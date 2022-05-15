using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoStage1.Domain;
using KinoStage1.Services;

namespace KinoStage1
{
    class Kino
    {

        private List<Game> _games;

        public List<Game> Games
        {
            get { return _games; }
            set { _games = value; }
        }

        private List<Player> _players;

        public List<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }

        private Lottery _lottery;

        public Lottery Lottery
        {
            get { return _lottery; }
            set { _lottery = value; }
        }

        private Player _player;

        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }



        private int _numOfGames;

        public int NumOfGames
        {
            get { return _numOfGames; }
            set { _numOfGames = value; }
        }

        private int _numOfPlayers;

        public int NumOfPlayers
        {
            get { return _numOfPlayers; }
            set { _numOfPlayers = value; }
        }

        public Kino()
        {

        }

       

        public void Start()
        {
            //Player player = new Player();
            
            //Console.WriteLine(player.ToString());

            //Lottery lottery = new Lottery();
            //Console.WriteLine(lottery.ToString());

            //EvaluationService evaluationService = new EvaluationService(player, lottery, player.Ticket.KinoBonus);
            //int count = evaluationService.Count;
            //bool catchKinoBonus = evaluationService.CatchKinoBonusNumber;
            //Console.WriteLine($"Player catch {count}/6 numbers and kino bonus {catchKinoBonus}");


           
        }

       public void Start(int numOfPlayers, bool KinoBonus)
        {
            
            PlayerService playerService = new PlayerService(numOfPlayers, KinoBonus);
            
        }
    }
}
