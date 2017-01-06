using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TShock References
using OTAPI;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace MintakaPlugin
{
	// The Terraria Server Api version, update the numbers as necessary
	[ApiVersion(2, 0)]
	public class MintakaPlugin : TerrariaPlugin
	{
		/// <summary>
		/// The plugin author, be it an individual or an organization.
		/// </summary>
		public override string Author => "NyxStudios";

		/// <summary>
		/// (Optional) Gives a short description of what your plugin does.
		/// </summary>
		public override string Description => "A TShock Mintaka based plugin.";

		/// <summary>
		/// The plugin name property.
		/// </summary>
		public override string Name => "Mintaka Plugin";

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				// Put methods to be run when the plugin is disposed here
			}
		}

		public MintakaPlugin(Main game) : base(game)
		{
			// Plugins with a higher value will be loaded after but their hooks will be handled first
			Order = 1;
		}

		public override void Initialize()
		{
			// Put methods to be run when the plugin initializes here
		}
	}
}
