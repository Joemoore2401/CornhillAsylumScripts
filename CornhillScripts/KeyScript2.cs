using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript2 : MonoBehaviour
{
    public bool hasKey2 = false;
    public GameObject player;
    public GameObject KeyUI;
    public DoorScript doorScript;
    public AudioSource PickedUp;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))



        {

            player = collision.GetComponent<GameObject>();
            hasKey2 = true;
            doorScript.hasKey = true;
            KeyUI.SetActive(true);
            PickedUp.Play();
            Destroy(this.gameObject);
            StartCoroutine(TextGone());
            IEnumerator TextGone()
            {
                yield return new WaitForSeconds(2);

            }

        }


    }
}
