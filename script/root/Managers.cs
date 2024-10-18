/*using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public interface IGamedataHandler
{
	public void UpdateGamedata(Gamedata gamedata);
}

public static class GamedataManager
{
	private static List<IGamedataHandler> handlers = new List<IGamedataHandler>();
	public static Gamedata gamedata;
	internal static void Awake()
	{
		Load();
		RefreshGamedata();
	}

	#region handlers
	public static void RegistrateHandler(IGamedataHandler handler)
	{
		handlers.Add(handler);
	}
	#endregion

	public static void RefreshGamedata()
	{
		foreach (IGamedataHandler handler in handlers)
			handler.UpdateGamedata(gamedata);
	}

	public static void Load()
	{
		Gamedata data = JsonConvert.DeserializeObject<Gamedata>(PlayerPrefs.GetString("Gamedata"));
		if (data != null)
		{
			gamedata = data;
			return;
		}
			data = new();
		SaveGamedata(data);
		gamedata = data;
	}

	public static void SaveGamedata(Gamedata data)
	{
		PlayerPrefs.SetString("Gamedata", JsonConvert.SerializeObject(data));
		PlayerPrefs.Save();
	}
}
*/
