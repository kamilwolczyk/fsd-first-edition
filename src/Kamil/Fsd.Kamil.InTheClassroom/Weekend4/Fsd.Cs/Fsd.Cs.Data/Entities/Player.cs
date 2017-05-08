namespace Fsd.Cs.Data.Entities
{
    public class Player
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public virtual FootballTeam FootballTeam { get; set; }
    }
}
