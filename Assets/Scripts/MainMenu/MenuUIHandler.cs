using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField textName;
    public TextMeshProUGUI HighScore;

    // Start is called before the first frame update
    void Start()
    {
        HighScore.text = Singleton.Instance.bestScorePlayer;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartNew()
    {
       Singleton.Instance.playerName = textName.text;

        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
