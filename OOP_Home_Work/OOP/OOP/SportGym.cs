namespace OOP
{
    internal class SportGym
    {
        private Coach coach;
        private Sportsman[] sportsmen;
        private string address;
        private double square;

        internal Coach Coach { get { return coach;} set { coach = value == null ? new Coach() : value; } }
        public string Address { get { return address; } set { address = value; } }
        public double Square { get { return square; } set { square = value>0?value:10; } }

        public SportGym()
        {

        }

    }
}
