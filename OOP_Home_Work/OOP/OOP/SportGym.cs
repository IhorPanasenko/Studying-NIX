namespace OOP
{
    internal class SportGym
    {
        private Coach coach;
        private Group group;
        private string address;
        private double square;

        internal Coach Coach { get { return coach;} set { coach = value == null ? new Coach() : value; } }
        internal string Address { get { return address; } set { address = value; } }
        internal double Square { get { return square; } set { square = value>0?value:10; } }
        internal Group Group { get { return group; } set { group = value; } }

        public SportGym()
        {

        }

    }
}
