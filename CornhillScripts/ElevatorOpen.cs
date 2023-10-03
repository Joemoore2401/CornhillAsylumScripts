using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorOpen : MonoBehaviour
{
    public AudioSource Opening;
    public Animator Opened;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Opened.SetTrigger("SlideOpened");
            Opening.Play();
            Destroy(GetComponent<Collider>());
        }
    }
}
