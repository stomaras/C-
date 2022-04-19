using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage2
{
    class Shop
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Game> Games { get; set; }

        private Game _cheapestGame;
        private Game _newestGame;
        private double _averageRating;
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

        public Game NewestGame
        {
            get
            {
                _newestGame = Games[0];

                foreach (Game game in Games)
                {
                    if (game.ReleaseDate.Year > _newestGame.ReleaseDate.Year)
                    {
                        _newestGame = game;
                    }
                }
                return _newestGame;
            }
        }

        public double AverageRating
        {
            get
            {
                double sum = 0;
                foreach (Game game in Games)
                {
                    sum += game.Rating;
                }

                _averageRating = sum / Games.Count;
                return _averageRating;
            }
        }

        // we should do it private and pass it in get 
        public Game GetCheapestGame()
        {
            Game cheapestGame = Games[0];

            foreach (Game game in Games)
            {
                if (game.Price < cheapestGame.Price)
                {
                    cheapestGame = game;
                }
            }

            return cheapestGame;
        }
    }
}
