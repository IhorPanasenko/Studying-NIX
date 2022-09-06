namespace OOP
{
    internal class Coach:Person
    {
        internal int YearExperience { get; set; }
        internal string Specialization { get; set; }
        internal int NumberOfDiploms { get; set; }
            
        public Coach():base()
        {
            YearExperience = 0;
            Specialization = "Loser";
            NumberOfDiploms = 0;
        }

        public Coach(Person per, int YearExperience, string Specialization, int NumberOfDiloms)
        {
            this.Name = per.Name;
            this.Age = per.Age;
            this.Phone = per.Phone;
            this.IsMale = per.IsMale;
            this.YearExperience = YearExperience;
            this.Specialization = Specialization;
            this.NumberOfDiploms = NumberOfDiloms;
        }

        new public void ShowInfo()
        {
            if (IsMale)
            {
                Console.WriteLine(Name + " is coach he is " + Age + " years old and has" + YearExperience + " years experience \nHe specilized at: " + Specialization + " And has " + NumberOfDiploms + "\nContact Number: " + Phone + "\n\n");
            }
            else
            {
                Console.WriteLine(Name + " is coach she is " + Age + " years old and has" + YearExperience + " years experience \nShe specilized at: " + Specialization + " And has " + NumberOfDiploms + "\nContact Number: " + Phone + "\n\n");
            }
        }

    }
}
