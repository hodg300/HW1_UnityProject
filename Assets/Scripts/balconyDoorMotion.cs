using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balconyDoorMotion : MonoBehaviour
{
    private Animator balconyAnim;
    private AudioSource balconyDoorSound;
    // Start is called before the first frame update
    void Start()
    {
        balconyAnim = GetComponent<Animator>();
        balconyDoorSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other) // player or other characther's coliider
    {
        balconyAnim.SetBool("balconyOpenning", true);
        balconyDoorSound.PlayDelayed(0.5f);
    }

    private void OnTriggerExit(Collider other)
    {
        balconyAnim.SetBool("balconyOpenning", false);
        balconyDoorSound.PlayDelayed(1.1f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
