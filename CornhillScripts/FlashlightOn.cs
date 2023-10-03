using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightOn : MonoBehaviour
{
    
    public bool Activate = false;
    
    
    public GameObject Flashlight;
    public GameObject PickUp;
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
        
        
        
        if (Activate == true)
        {
            
            Flashlight.SetActive(true);
            
            Destroy(PickUp);
            
        }
        else
        {
            Flashlight.SetActive(false);
        }

       
    }
   



}
