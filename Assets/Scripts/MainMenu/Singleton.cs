using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance;

   // public TMP_InputField inputField;

    public string playerName;
    public string bestScorePlayer;
    //public TextMeshProUGUI bestScoreText;
    public int score = 0;
    public int highScore;

    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadHighScore();
    }

    [System.Serializable]
    class SaveData
    {
        public string bestScorePlayer;

    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.bestScorePlayer = bestScorePlayer;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestScorePlayer = data.bestScorePlayer;
        }
    }
}
