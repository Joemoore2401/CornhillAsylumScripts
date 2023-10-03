using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownElevator : MonoBehaviour
{
    public Animator Down;
    public Animator CloseSlider;
    public Animator Openup;
    public AudioSource Opened;
    public AudioSource Closed;


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
                Down.SetTrigger("Down");
                yield return new WaitForSeconds(10);
                Openup.SetTrigger("SlideOpened");
                Opened.Play();
            }

        }
    }
}
