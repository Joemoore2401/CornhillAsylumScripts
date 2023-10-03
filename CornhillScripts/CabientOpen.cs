using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabientOpen : MonoBehaviour
{
    public static bool buttonPressed = false;
    public Animator Cabinetopen;
    public GameObject Key;
    public GameObject showUI;
    public AudioSource cabinetOpened;
    public AudioSource KeyPressed;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            buttonPressed = true;
            showUI.SetActive(true);
        }
  
        
    }


    void Update()
    {
        if (buttonPressed == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Cabinetopen.SetTrigger("cabinet");
                Key.SetActive(true);
                showUI.SetActive(false);
                cabinetOpened.Play();
                KeyPressed.Play();
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            showUI.SetActive(false);
        }
    }
}
