using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioPickUp : MonoBehaviour
{
    public GameObject Radio;
    public GameObject ShowUi;
    public static bool KCode;
    public AudioSource Radioplay;
    public AudioSource PickedUp;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
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

            }
        }
    }
}
