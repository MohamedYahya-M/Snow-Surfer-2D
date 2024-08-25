using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    
    public bool isGameActive = false;

    public GameObject panel;
    private Rigidbody2D playerRb;
    public SurfaceEffector2D surfaceEffector;
    [SerializeField] float torqueForce = 3f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        isGameActive = true;
        playerRb = GetComponent<Rigidbody2D>(); 
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();

       
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            RotateMethod();
            RespondToBoost();
            PauseGame();
        }
      


    }
    private void PauseGame()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
        }


    }

    private void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow)) 
        {
            surfaceEffector.speed = boostSpeed;
        }
        else
        {
            surfaceEffector.speed = baseSpeed;
        }
       
    }

    private void RotateMethod()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb.AddTorque(torqueForce);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRb.AddTorque(-torqueForce);
        }
    }

  
}
