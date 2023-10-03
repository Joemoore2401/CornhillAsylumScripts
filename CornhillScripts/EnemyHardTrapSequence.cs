using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHardTrapSequence : MonoBehaviour
{
    public static bool Sequence = false;
    public GameObject key;
    public GameObject showUI;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject doorSlam;
    public GameObject sequenceStarted;
    public GameObject fog;
    public GameObject explosion1;
    public GameObject explosion2;
    public GameObject explosion3;
    public GameObject explosion4;
    public GameObject explosion5;
    public GameObject explosion6;
    public GameObject explosion7;
    public GameObject sequenceEnded;
    public Animator Cabinetopen;
    public Animator doorClose;
    public Animator doorOpen;
    public Animator TriMoved;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            showUI.SetActive(true);
            Sequence = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            showUI.SetActive(false);
            Sequence = false;
        }
    }


    private void Update()
    {
        if (Sequence == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                showUI.SetActive(false);
                TriMoved.SetTrigger("TriggerMoved");
                doorClose.SetTrigger("MetalClose");
                doorSlam.SetActive(true);
                sequenceStarted.SetActive(true);
                fog.SetActive(true);
                StartCoroutine(EnemySpawn());

                IEnumerator EnemySpawn()
                {
                    yield return new WaitForSeconds(5);
                    enemy1.SetActive(true);
                    yield return new WaitForSeconds(2);
                    enemy1.SetActive(false);
                    explosion1.SetActive(true);
                    yield return new WaitForSeconds(2);
                    explosion1.SetActive(false);




                    yield return new WaitForSeconds(2);
                    enemy2.SetActive(true);
                    yield return new WaitForSeconds(2);
                    enemy2.SetActive(false);
                    explosion2.SetActive(true);
                    yield return new WaitForSeconds(2);
                    explosion2.SetActive(false);



                    yield return new WaitForSeconds(2);
                    enemy3.SetActive(true);
                    yield return new WaitForSeconds(2);
                    enemy3.SetActive(false);
                    explosion3.SetActive(true);
                    yield return new WaitForSeconds(2);
                    explosion3.SetActive(false);



                    yield return new WaitForSeconds(2);
                    enemy4.SetActive(true);
                    yield return new WaitForSeconds(2);
                    enemy4.SetActive(false);
                    explosion4.SetActive(true);
                    yield return new WaitForSeconds(2);
                    explosion4.SetActive(false);

                    yield return new WaitForSeconds(2);
                    enemy5.SetActive(true);
                    yield return new WaitForSeconds(2);
                    enemy5.SetActive(false);
                    explosion5.SetActive(true);
                    yield return new WaitForSeconds(2);
                    explosion5.SetActive(false);

                    yield return new WaitForSeconds(2);
                    enemy6.SetActive(true);
                    yield return new WaitForSeconds(2);
                    enemy6.SetActive(false);
                    explosion6.SetActive(true);
                    yield return new WaitForSeconds(2);
                    explosion6.SetActive(false);

                    yield return new WaitForSeconds(2);
                    enemy7.SetActive(true);
                    yield return new WaitForSeconds(2);
                    enemy7.SetActive(false);
                    explosion7.SetActive(true);
                    yield return new WaitForSeconds(2);
                    explosion7.SetActive(false);



                    yield return new WaitForSeconds(2);
                    sequenceStarted.SetActive(false);
                    fog.SetActive(false);
                    sequenceEnded.SetActive(true);
                    Cabinetopen.SetTrigger("cabinet");
                    key.SetActive(true);
                    doorOpen.SetTrigger("MetalOpen");
                }

            }
        }
    }
}
