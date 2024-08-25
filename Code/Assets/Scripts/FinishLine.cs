using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] string loadSceneName;
    [SerializeField] float waitDelay = 2f;
    [SerializeField] ParticleSystem finalParticle;
    [SerializeField] AudioClip finalSound;


    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(playerController.isGameActive == true) 
        {
            if (collision.tag == "Player")
            {

                finalParticle.Play();
                GetComponent<AudioSource>().PlayOneShot(finalSound);
                playerController.isGameActive = false;
                Invoke("LoadScene", waitDelay);

            }
        }
        
    }


    void LoadScene()
    {
        SceneManager.LoadScene(loadSceneName);
    }

    


}
