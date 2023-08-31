using System.Collections;
using System.Collections.Generic;
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
    }
  
}
