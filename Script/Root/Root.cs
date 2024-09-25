using UnityEngine;

internal class Root : MonoBehaviour
{
    [SerializeField] private bool clearSave;
    [SerializeField] private byte FPS;

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = FPS;
        if (clearSave)
            PlayerPrefs.DeleteAll();
    }
}