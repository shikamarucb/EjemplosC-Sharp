namespace Interfaces
{
    interface Animal
    {
        string HacerRuido(string Name);
    }

    class Tigre : Animal
    {
        public string HacerRuido(string Name)
        {
            return Name + " : Grrrr!!";
        }
    }

    class Perro : Animal
    {
        public string HacerRuido(string Name)
        {
            return Name + " : Woof Woof!!";
        }
    }
}