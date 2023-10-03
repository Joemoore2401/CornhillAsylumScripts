using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch2 : MonoBehaviour
{
    public bool hasKey2 = false;
    public GameObject NeedKeyUI;
    public GameObject UIOff;
    public Animator _door;
    public AudioSource _sound;


    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject player = collision.GetComponent<GameObject>();
            if (hasKey2 == true)
            {
                _door.SetTrigger("MetalOpen");
                UIOff.SetActive(false);
                _sound.Play();
                Destroy(GetComponent<Collider>());
                StartCoroutine(TextOff());
                IEnumerator TextOff()
                {
                    yield return new WaitForSeconds(2);
                }


            }
            else
            {
                NeedKeyUI.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        NeedKeyUI.SetActive(false);
    }

}
