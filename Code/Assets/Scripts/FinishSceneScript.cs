using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishSceneScript : MonoBehaviour
{
    
    private int completedLevelIndex;
      // Start is called before the first frame update
    void Start()
    {

        completedLevelIndex = PlayerPrefs.GetInt("completedLevelIndex", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void ReplayButton()
    {
        SceneManager.LoadScene(completedLevelIndex);
    }

   public void NextButton()
    {
        int nextLevelIndex = completedLevelIndex + 1;
        SceneManager.LoadScene(nextLevelIndex);
    }
}
