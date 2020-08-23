using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] GameObject OptionMenu, MainMenu;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentscene = SceneManager.GetActiveScene();
        sceneName = currentscene.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Game()
    {
        SceneManager.LoadScene("Intro");
    }
    public void Options()
    {
        MainMenu.SetActive(false);
        OptionMenu.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
