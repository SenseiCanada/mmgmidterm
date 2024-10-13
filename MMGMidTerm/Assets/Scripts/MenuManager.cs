using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public string menuSceneName = "StartMenu";
    public string gameSceneName = "GameLevel";
    public string recapSceneName = "RecapScene";

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            LoadStartMenu();
        }
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(menuSceneName);
    }
    public void LoadMainGame()
    {
        SceneManager.LoadScene("GameLevel");

    }
    public void LoadRecap()
    {
        SceneManager.LoadScene(recapSceneName);
    }
}
