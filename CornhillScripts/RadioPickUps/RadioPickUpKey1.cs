using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioPickUpKey1 : MonoBehaviour
{
    public GameObject Radio;
    public GameObject ShowUi;
    public GameObject player;
    public static bool KCode;
    public bool RadioActive1;
    public AudioSource Radioplay;
    public AudioSource PickedUp;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {

            ShowUi.SetActive(true);
            KCode = true;


        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ShowUi.SetActive(false);
            KCode = false;
        }




    }
    // Update is called once per frame
    void Update()
    {
        if (KCode == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                ShowUi.SetActive(false);
                PickedUp.Play();
                Radioplay.Play();
                RadioActive1 = true;

            }
        }
    }
}
