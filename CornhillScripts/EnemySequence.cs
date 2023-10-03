using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySequence : MonoBehaviour
{
    public GameObject Explosion;
    public GameObject Enemy;
    public GameObject EnemySpawned;
    public AudioSource EnemyDisappeared;



    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Enemy.SetActive(true);
            EnemySpawned.SetActive(true);
            Destroy(GetComponent<Collider>());
            StartCoroutine(NotCatched());


            IEnumerator NotCatched()
            {
                yield return new WaitForSeconds(4);
                Enemy.SetActive(false);
                EnemySpawned.SetActive(false);
                Explosion.SetActive(true);
                EnemyDisappeared.Play();
                yield return new WaitForSeconds(2);
                Explosion.SetActive(false);

            }
        }
    }
}
