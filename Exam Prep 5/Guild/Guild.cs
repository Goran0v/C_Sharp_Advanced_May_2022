using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => this.roster.Count;

        public Guild(string name, int capacity)
        {
            this.roster = new List<Player>();
            this.Name = name;
            this.Capacity = capacity;
        }

        public void AddPlayer(Player player)
        {
            if (this.roster.Count + 1 <= Capacity)
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            if (this.roster.Count > 0)
            {
                foreach (var player in this.roster)
                {
                    if (player.Name == name)
                    {
                        return this.roster.Remove(player);
                    }
                }
            }
            
            return false;
        }

        public void PromotePlayer(string name)
        {
            if (this.roster.Count > 0)
            {
                Player player = this.roster.Where(p => p.Name == name).First();
                if (player.Rank != "Member")
                {
                    player.Rank = "Member";
                }
            }
        }

        public void DemotePlayer(string name)
        {
            if (this.roster.Count > 0)
            {
                Player player = this.roster.Where(p => p.Name == name).First();
                if (player.Rank != "Trial")
                {
                    player.Rank = "Trial";
                }
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            List<Player> players = new List<Player>();
            foreach (var player in this.roster)
            {
                if (player.Class == @class)
                {
                    players.Add(player); 
                }
            }

            foreach (var pl in players)
            {
                this.roster.Remove(pl);
            }

            return players.ToArray();
        }

        public string Report()
        {
            return $"Players in the guild: {this.Name}" + Environment.NewLine + $"{string.Join(Environment.NewLine, this.roster)}";
        }
    }
}
