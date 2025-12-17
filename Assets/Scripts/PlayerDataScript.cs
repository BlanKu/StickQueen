using UnityEngine;
using System.IO;
using UnityEditor.Overlays;
using UnityEngine.UI;

[System.Serializable]
public class PlayerData
{
    public float masterVolume;
}

public class PlayerDataScript : MonoBehaviour
{
    string savePath;

    public Slider masterVolumeSlider;

    private void Start()
    {
        LoadData();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F5))
        {
            SaveData();
        }
    }

    void Awake()
    {
        savePath = Application.persistentDataPath + "/save.json";
    }

    public void SaveData()
    {
        PlayerData data = new PlayerData();

        data.masterVolume = masterVolumeSlider.value;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(savePath, json);

        Debug.Log("Gra zapisana: " + savePath);
    }

    public PlayerData LoadData()
    {
        if(!File.Exists(savePath))
        {
            Debug.Log("Braz pliku zapisu");
            return null;
        }

        string json = File.ReadAllText(savePath);
        PlayerData data = JsonUtility.FromJson<PlayerData>(json);

        //Update masterVolume
        AudioListener.volume = data.masterVolume;
        masterVolumeSlider.value = data.masterVolume;

        Debug.Log("Zapis wczytany");
        return data;
    }
}
