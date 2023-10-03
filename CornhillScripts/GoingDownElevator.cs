using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingDownElevator : MonoBehaviour
{
    public Animator GoingDown;
    public Animator CloseSlider;
    public Animator Openup;
    public AudioSource Opened;
    public AudioSource Closed;
    public GameObject Noise;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CloseSlider.SetTrigger("SlideClosed");
            StartCoroutine(Closedup());


            IEnumerator Closedup()
            {

                Closed.Play();
                yield return new WaitForSeconds(2);
                GoingDown.SetTrigger("GoingDown");
                Noise.SetActive(true);
                yield return new WaitForSeconds(7);
                Noise.SetActive(false);
                Openup.SetTrigger("SlideOpened");
                Opened.Play();
            }
        }
    }
}
