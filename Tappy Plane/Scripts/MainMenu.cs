using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string newGameScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NewGame()
    {
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
