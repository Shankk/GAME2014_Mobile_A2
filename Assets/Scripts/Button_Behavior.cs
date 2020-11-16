using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void LoadInstructions()
    {
        SceneManager.LoadScene("InstructionScene");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
