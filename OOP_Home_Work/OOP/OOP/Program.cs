// See https://aka.ms/new-console-template for more information
namespace OOP
{
    internal class Program 
    {
        internal static void Main()
        {
            Person Oleg = new Person("Oleg", 33, "09977777", true);
            Person Nikita = new Person("Nikita", 90, "066555555", true);
            Person Maria = new Person("Maria", 19, "069696969", false);
            Coach coach1 = new Coach(Oleg, 10, "Swimming", 26);
            Sportsman sportsman1 = new Sportsman(Nikita, false, 10, 3,coach1);
            Sportsman sportsman2 = new(Maria, true, 33, 13, coach1);
            Sportsman sportsman3 = new Sportsman();
            sportsman3.Name = "Anastasiia";
            sportsman3.Coach = new Coach();
            sportsman3.WonCompetitions = 78;
            sportsman3.Phone = "02222222";
            sportsman3.Age = 25;
            sportsman3.HasAbonement = true;
            sportsman3.WentToGymForMonths = 69;
            Coach Super = new Coach(sportsman3, 14, "Running", 45);
            sportsman3.Coach = Super;
            Group group13 = new Group(sportsman1, 13, "Swimming under water");
            group13.AddSportsman(sportsman2);
            group13.AddSportsman(sportsman3);
            SportGym sportGym1 = new SportGym(coach1, group13, "Globus street", 190);
            sportGym1.GymInfo();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            sportGym1.MoveInAnotherGym(450000000, "Kharkiv");
            sportGym1.AddSportsman(new Sportsman(new Person("bot1", 13000, "xxxxxxx", false), true, 12, 6, Super));
            sportGym1.ChangeCoach(Super);
            sportGym1.RemoveSportsmanByName("Nikita");
            sportGym1.GymInfo();
        }
    }
}





