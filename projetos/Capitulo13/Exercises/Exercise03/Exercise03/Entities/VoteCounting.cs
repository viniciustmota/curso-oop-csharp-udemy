using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03.Entities
{
    internal class VoteCounting
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public void AddUpVotes(int votes) {
           Votes += votes;
        }

        public override bool Equals(object? obj)
        {
            if(obj is not VoteCounting other)
            {
                return false;
            }
            return Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
