namespace OOP
{
    internal class Sportsman:Person
    {
        internal bool HasAbonement { get; set; }
        internal int WentToGymForMonths { get; set; }
        internal int WonCompetitions { get; set; }
        internal Coach? Coach { get; set; }

        public Sportsman():base()
        {
            HasAbonement = false;
            WentToGymForMonths = 0;
            WonCompetitions = 0;
            Coach = null;
        }

        public Sportsman (Person per, bool HasAbonement, int WentToGymForMonths, int WonCompetitions, Coach? Coach)
        {
            this.Name = per.Name;  
            this.Age = per.Age;
            this.Phone = per.Phone;
            this.HasAbonement = HasAbonement;
            this.WentToGymForMonths = WentToGymForMonths;
            this.WonCompetitions = WonCompetitions;
            this.Coach = Coach;
        }
    }
}
