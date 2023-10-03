using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource PlaySound;
    public bool playerInteracted = false;
    void Start()
    {
        GameObject.FindGameObjectsWithTag("Player");
    }
    void OnTriggerEnter(Collider other)
    
    
    {
        if (other.tag == "Player")
        {
            PlaySound.Play();
            Destroy(GetComponent<Collider>());
        }
        

    }





}
