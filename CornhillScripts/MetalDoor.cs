using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalDoor : MonoBehaviour
{
    public AudioSource _sound;
    public Animator _doorAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _doorAnim.SetTrigger("MetalOpen");
            _sound.Play();
            Destroy(GetComponent<Collider>());

        }
    }
}
