using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChanger : MonoBehaviour
{
    public GameObject MusicOff;
    public GameObject MusicOn;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MusicOff.SetActive(false);
            MusicOn.SetActive(true);
        }
    }
}
