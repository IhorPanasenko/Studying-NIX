namespace OOP
{
    internal class Sportsman:Person
    {
        internal bool HasAbonement { get; set; }
        internal int WentToGymForMonths { get; set; }
        internal int WonCompetitions { get; set; }
        internal Coach Coach { get; set; }

        public Sportsman():base()
        {
            HasAbonement = false;
            WentToGymForMonths = 0;
            WonCompetitions = 0;
            Coach = new Coach();
        }

        public Sportsman (Person per, bool HasAbonement, int WentToGymForMonths, int WonCompetitions, Coach Coach)
        {
            this.Name = per.Name;  
            this.Age = per.Age;
            this.Phone = per.Phone;
            this.HasAbonement = HasAbonement;
            this.WentToGymForMonths = WentToGymForMonths;
            this.WonCompetitions = WonCompetitions;
            this.Coach = Coach;
        }

        public void GiveAbonement()
        {
            if (HasAbonement)
            {
                Console.WriteLine("Sportsman "+Name+" already has abonement\n\n");
            }
            else
            {
                HasAbonement=true;
                Console.WriteLine("Abonement was given to " + Name + "\n\n");
            }
        }

        new public void ShowInfo()
        {
            if (IsMale)
            {
                Console.WriteLine(Name+" is sportsman he is"+Age+" years old \nHe has been gone to gym for "+WentToGymForMonths+" months and won "+WonCompetitions+" competitions\nHe training at coach "+Coach.Name+"\nHe has abonement "+HasAbonement+"Contact phone"+Phone);
            }
            else
            {
                Console.WriteLine(Name + " is sportsman she is" + Age + " years old \nShe has been gone to gym for " + WentToGymForMonths + " months and won " + WonCompetitions + " competitions\nShe training at coach " + Coach.Name + "\nShe has abonement " + HasAbonement + "Contact phone" + Phone);
            }
        }

    }
}
