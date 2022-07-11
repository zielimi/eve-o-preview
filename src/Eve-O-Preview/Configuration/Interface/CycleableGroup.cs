using System.Collections.Generic;

namespace EveOPreview.Configuration
{
	public class CycleableGroup
	{
		public CycleableGroup(string hotkey, List<string> clients)
		{
			this.hotkey = hotkey;
			this.clients = clients;
		}

		public string hotkey { get; set; }

		public List<string> clients { get; set; }
	}
}