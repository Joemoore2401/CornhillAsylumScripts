using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorUp : MonoBehaviour
{
    public Animator Up;



    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Up.SetTrigger("Up");
        }
    }
}
