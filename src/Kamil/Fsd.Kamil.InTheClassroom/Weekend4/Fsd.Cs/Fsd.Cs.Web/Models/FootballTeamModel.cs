using System.ComponentModel;

namespace Fsd.Cs.Web.Models
{
    public class FootballTeamModel
    {
        public int Id { get; set; }

        [DisplayName("Nazwa")]
        public string Name { get; set; }
    }
}