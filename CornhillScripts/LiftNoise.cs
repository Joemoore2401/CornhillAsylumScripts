using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftNoise : MonoBehaviour
{
    public GameObject Noise;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Noise.SetActive(true);
            StartCoroutine (Finish());

            IEnumerator Finish()
            {
                yield return new WaitForSeconds(10);
                Destroy(this.Noise);

            }
        }
    }
}
