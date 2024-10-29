using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppÖvning
{
	internal class GameConsole
	{
		public Processor ConsoleProcessor { get; set; }
		public GraphicCard ConsoleGraphicCard { get; set; }

		public GameConsole(Processor initialProcessor, GraphicCard initalGraphicCard)
		{
			ConsoleProcessor = initialProcessor;
			ConsoleGraphicCard = initalGraphicCard;
		}
	}
}
