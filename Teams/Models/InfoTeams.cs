using System.ComponentModel.DataAnnotations;

namespace Teams.Models
{
    public class InfoTeams
    {
        [Key]
        public int Team_Id { get; set; }

        public string Team_name { get; set; }

        public string Coach_name { get; set; }

        public int Maches_Played { get; set; }

        public int Maches_Lost { get; set; }

        public int Maches_Won { get; set; }
    }
}
