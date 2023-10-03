using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioPickUp4 : MonoBehaviour
{
    public GameObject Radio;
    public GameObject ShowUi;
    public GameObject player;
    public Animator OpenDoor;
    public static bool KCodes;
    public AudioSource Radioplay;
    public AudioSource PickedUp;
    public AudioSource Suspense;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {

            ShowUi.SetActive(true);
            KCodes = true;


        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ShowUi.SetActive(false);
            KCodes = false;
        }




    }
    // Update is called once per frame
    void Update()
    {
        if (KCodes == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ShowUi.SetActive(false);
                PickedUp.Play();
                Radioplay.Play();
                OpenDoor.SetTrigger("MetalOpen");
                Suspense.Play();
            }
        }
    }
}
