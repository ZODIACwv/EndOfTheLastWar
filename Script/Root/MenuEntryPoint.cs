using UnityEngine;

public class MenuEntryPoint : MonoBehaviour
{
    void Awake()
    {
        GamedataManager.Awake();
        GamedataManager.SaveGamedata(GamedataManager.gamedata);
    }
}
