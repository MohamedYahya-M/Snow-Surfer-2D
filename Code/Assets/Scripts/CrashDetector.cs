using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] float waitDelay = 1.0f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSound;

    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "Ground")
        {
           
            PlaySoundOnce();
            playerController.isGameActive = false;
            playerController.surfaceEffector.speed = 5f;
            Invoke("SceneWait", waitDelay);
        }
                   
    }

    void SceneWait()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void PlaySoundOnce()
    {
        if(playerController.isGameActive) 
        
        {
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSound);
        }
        
        
    }
}
