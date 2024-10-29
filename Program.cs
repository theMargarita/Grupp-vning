namespace GruppÖvning
{
	internal class Program
	{
		static void Main(string[] args)
		{
			GameConsole console = new GameConsole(
				new Processor("Intel"),
				new GraphicCard("Nvidia")
				);

		}
	}
}
