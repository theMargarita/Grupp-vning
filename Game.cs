namespace GruppÖvning
{
    public class Game
    {
        string Title;
        public List<Level> levels { get; set; }

        public Game(string title)
        {
            Title = title;
            levels = new List<Level>();
        }

    }
}
