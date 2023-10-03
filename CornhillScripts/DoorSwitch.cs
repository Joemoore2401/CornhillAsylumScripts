using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Switched = false;
    public AudioSource Creeking;
    public Animator DoorAnimation;




    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {




    }
    private void OnTriggerEnter()
    {

        
            if (Switched == true)
            {
                DoorAnimation.SetTrigger("open");
                Creeking.Play();
                Destroy(GetComponent<Collider>());
            }


        



    }
}