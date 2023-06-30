using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresistenciaData.Entities
{
    public class Team
    {
        private string ? idTeam;
        private string ? nameTeam;
        private List<Player>  players = new List<Player>();

        public string? IdTeam { get => idTeam; set => idTeam = value; }
        public string? NameTeam { get => nameTeam; set => nameTeam = value; }
        public List<Player> Players { get => players; set => players = value; }
    }
}