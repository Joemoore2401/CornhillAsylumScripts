using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio8 : MonoBehaviour
{
    public GameObject Radio;
    public GameObject ShowUi;
    public GameObject player;
    public static bool KCones;
    public AudioSource Radioplay;
    public AudioSource PickedUp;
    public AudioSource Suspense;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {

            ShowUi.SetActive(true);
            KCones = true;


        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ShowUi.SetActive(false);
            KCones = false;
        }




    }
    // Update is called once per frame
    void Update()
    {
        if (KCones == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ShowUi.SetActive(false);
                PickedUp.Play();
                Radioplay.Play();
                Suspense.Play();
            }
        }
    }
}
