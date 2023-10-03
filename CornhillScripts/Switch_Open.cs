using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Open : MonoBehaviour
{


    public AudioSource _sound;
    public Animator _doorAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _doorAnim.SetTrigger("RightDoor");
            _sound.Play();
            Destroy(GetComponent<Collider>());

        }
    }
}
