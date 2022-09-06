namespace OOP
{
    internal class SportGym
    {
        private Coach coach;
        private Group group;
        private string address;
        private double square;

        internal Coach Coach { get { return coach;} }
        internal string Address { get { return address; } set { address = value; } }
        internal double Square { get { return square; } set { square = value>0?value:10; } }
        internal Group Group { get { return group; } set { group = value; } }

        public SportGym()
        {
            coach = new Coach();
            Group = new Group();
            Square = 10;
            Address = "Somewhere on Earth";
        }

        public SportGym(Coach Coach, Group Group, string Address, double Square)
        {
            this.coach = Coach;
            this.Group = Group;
            this.Address = Address;
            this.Square = Square;
        }

        public void ChangeCoach (Coach newCoach) 
        {
            this.coach = newCoach;
        }

        public void MoveInAnotherGym(int newSquare, string newAddress)
        {
            this.Address = newAddress;
            this.Square = newSquare;
        }

        public bool RemoveSportsmanByName(string name)
        {
           return group.DeleteSportsmanByName(name);
        }

        public void AddSportsman(Sportsman sp)
        {
            group.AddSportsman(sp);
        }

        public void GymInfo()
        {
            Console.WriteLine("Gym on address " + Address + "\nSquare: " + Square + " \nTrained by coach: \n");
            coach.ShowInfo();
            Console.WriteLine("With group:\n");
            group.GroupInfo();
        }

    }
}
