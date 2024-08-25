using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustTrail;
    // Start is called before the first frame update
    private PlayerController playerController;

    private void Start()
    {
        playerController = GetComponent<PlayerController>();
    }
    private void Update()
    {
            
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" && playerController.isGameActive == true)
        {
            dustTrail.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        dustTrail.Stop();
    }
}
