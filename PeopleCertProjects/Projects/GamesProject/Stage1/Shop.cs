using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1
{
    class Shop
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Game> Games { get; set; }

        private Game _cheapestGame; 
        public Game CheapestGame
        {
            get
            {
                _cheapestGame = Games[0];

                foreach (Game game in Games)
                {
                    if (game.Price < _cheapestGame.Price)
                    {
                        _cheapestGame = game;
                    }
                }

                return _cheapestGame;
            }
        }

        // we should do it private and pass it in get 
        public Game GetCheapestGame()
        {
            Game cheapestGame = Games[0];

            foreach(Game game in Games)
            {
                if(game.Price < cheapestGame.Price)
                {
                    cheapestGame = game;
                }
            }

            return cheapestGame;
        }
    }
}
