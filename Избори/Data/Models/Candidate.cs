using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Party { get; set; }

        private int votes;

        public int Votes
        {
            set { votes = value; }
        }

        public Candidate ()
        {
            this.votes = 0;
        }

        public void AddVote ()
        {
            this.votes++;
        }
    }
}
