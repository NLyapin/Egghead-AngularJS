using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo2.Models
{
    public class Board
    {
        private List<Card> pieces = new List<Card>();

        public List<Card> Pieces
        {
            get { return pieces; }
            set { pieces = value; }
        }

        public Board()
        {
            int imgIndex = 1;
            for (int i = 1; i <= 30; i ++)
            {
                if (IsOdd(i))
                    pieces.Add(new Card()
                        {
                            Id = i,
                            Pair = i + 1,
                            Name = "card" + i.ToString(),
                            Image = string.Format("/content/img/{0}.png", imgIndex)
                        });
                else
                {
                    pieces.Add(new Card()
                        {
                            Id = i,
                            Pair = i + 1,
                            Name = "card" + i.ToString(),
                            Image = string.Format("/content/img/{0}.png", imgIndex)
                        });
                    imgIndex++;
                }
            }

            pieces.Shuffle();
        }

        private bool IsOdd(int i)
        {
            return i%2 != 0;
        }
    }
}