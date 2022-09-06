namespace OOP
{
    internal class Group
    {
        private List<Sportsman> sportsmen;
        public int Id { get; set; }
        public string Name { get; set; }

        public Group()
        {
            sportsmen = new List<Sportsman>();
            Id = 0;
            Name = "Choose Name";
        }

        public Group (Sportsman sportsman, int id, string name)
        {
            this.sportsmen = new List<Sportsman>();
            sportsmen.Add(sportsman);
            Id = id;
            Name = name;
        }

        public void AddSportsman(Sportsman sportsman)
        {
            if (sportsman != null)
            {
                sportsmen.Add(sportsman);
            }
            else
            {
                Console.WriteLine("Sportsman must be someone");
            }
        }

        public bool DeleteSportsmanByName(string name)
        {
            bool result = false;

            foreach(Sportsman sp in sportsmen)
            {
                if(sp.Name == name)
                {
                    sportsmen.Remove(sp);
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}
