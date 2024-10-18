/*using Newtonsoft.Json;
using System;

public class Gamedata
{
	[JsonProperty("currentProfile")]
	internal byte currentProfile;
	[JsonProperty("havePremium")]
	internal bool havePremium;
	[JsonProperty("graficQuality")]
	internal Quality graficQuality;
	[JsonProperty("language")]
	internal Language language;
	[JsonProperty("musicLoudness")]
	internal byte musicLoudness;
	[JsonProperty("SFX_Loudness")]
	internal byte SFX_Loudness;
	[JsonProperty("players")]
	internal Player[] players = new Player[3];

	public Gamedata()
	{
		currentProfile = 0;
		havePremium = false;
		graficQuality = Quality.Average;
		language = Language.Russian;
		musicLoudness = 100;
		SFX_Loudness = 100;
		players = new Player[]{
			new(),
			new(),
			new()
		};
	}
}

internal class Profile{
	[JsonProperty("complexity")]
	internal Complexity complexity;
	[JsonProperty("startkit")]
	internal Startkit startkit;
	[JsonProperty("guideComplete")]
	internal byte guideComplete;
	[JsonProperty("player")]
	internal Player player;
}

internal class Player : Profile{
	#region positions
	[JsonProperty("chunkPosition")]
	internal PlayerPosition chunkPosition;
	[JsonProperty("playerPosition")]
	internal PlayerPosition playerPosition;
	#endregion
	#region general
	[JsonProperty("lvl")]
	internal byte lvl;
	#endregion
	#region global
	[JsonProperty("inventory")]
	internal InventoryData inventory = new InventoryData();
	#endregion

	internal Player(){
		complexity = Complexity.Average;
		startkit = Startkit.Civil;
		guideComplete = 0;
		lvl = 0;
	}
}
*/
