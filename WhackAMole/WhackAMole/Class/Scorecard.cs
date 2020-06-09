using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhackAMole.Class
{
    class Scorecard
    {

        private int score;

        private String userName;

        public Scorecard(int score, string userName)
        {
            this.score = score;
            this.userName = userName;
        }

        public int Score { get => score; set => score = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}
