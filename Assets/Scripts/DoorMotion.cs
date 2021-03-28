using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    private Animator anim;
    private AudioSource doorSound;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        doorSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other) // player or other characther's coliider
    {
        anim.SetBool("openning", true);
        doorSound.PlayDelayed(0.8f);
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("openning", false);
        doorSound.PlayDelayed(1.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
