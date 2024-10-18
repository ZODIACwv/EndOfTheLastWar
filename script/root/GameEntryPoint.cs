/*using UnityEngine;

public class GameEntryPoint : MonoBehaviour
{
	[SerializeField] private GameObject inventory;
	private void Awake()
	{
		Debug.Log(PlayerPrefs.GetString("Gamedata"));
		InventorySetting.SetVeriables(inventory);
		GamedataManager.RegistrateHandler(new InventorySetting());
		GamedataManager.Awake();
		InventorySetting.CreateHandlers();
		InventorySetting.UpdateInventoryUI();
		GamedataManager.SaveGamedata(GamedataManager.gamedata);
	}
}
*/
