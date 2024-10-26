namespace IGME201_week09_class_structs_oop
{
    public class Character
    {
        public string name;
        public int exp = 0;

        //basic Character constructor
        public Character()
        {
            name = "Not assigned";
        }
            //example of constructor overloading:
        //Character constructor to take string param
        public Character(string name)
        {
            this.name = name;
        }
        public void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare default Character instance
            Character hero = new Character();
            //Console.WriteLine("Hero: " + hero.name + " - " + hero.exp + " EXP");
            hero.PrintStatsInfo();
            
            //Declare Character instance that's a girl
            Character heroine = new Character("Agatha");
            //Console.WriteLine("Hero: " + heroine.name + " - " + heroine.exp + " EXP");
            heroine.PrintStatsInfo();
        }
    }
    }