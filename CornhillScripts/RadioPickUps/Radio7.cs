using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio7 : MonoBehaviour
{
    public GameObject Radio;
    public GameObject ShowUi;
    public GameObject player;
    public Animator OpenDoor;
    public static bool KCone;
    public AudioSource Radioplay;
    public AudioSource PickedUp;
    public AudioSource Suspense;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {

            ShowUi.SetActive(true);
            KCone = true;


        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ShowUi.SetActive(false);
            KCone = false;
        }




    }
    // Update is called once per frame
    void Update()
    {
        if (KCone == true)
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
