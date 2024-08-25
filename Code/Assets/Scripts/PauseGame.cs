using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ContinueGame()
    {
        Time.timeScale = 1.0f;
        playerController.panel.SetActive(false);
        
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene("LevelSelectScene");

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
