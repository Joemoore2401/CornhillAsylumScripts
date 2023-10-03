using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionMenu : MonoBehaviour
{
    public static bool Door1Active;
    public static bool Door2Active;
    public static bool Paused;
    public static bool Mouse = false;
    public GameObject LeftDoor; // Highlights which Object in the game will be assign to which variable.
    public GameObject RightDoor;
    public GameObject InteractionMenuUI;
    public GameObject ChoiceCam;
    public Camera fpscam;//Highlights which cameras to switch to in the function.
    public Camera choicecam;
    public Animator DoorAnim1;//Highlights which animation to assign to the variable
    public Animator DoorAnim2;
 
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Stopped();
            InteractionMenuUI.SetActive(true);
            fpscam.enabled = false;
            ChoiceCam.SetActive(true);
            choicecam.enabled = true;
            Mouse = true;
        }
        
        


    }


    void Update()
    {
        if (Mouse == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if(Mouse == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
        }

        if (Door1Active == true)
        {


            fpscam.enabled = true;
            ChoiceCam.SetActive(false);
            choicecam.enabled = false;
            Mouse = false;
            Destroy(GetComponent<Collider>());
        }




        if (Door2Active == true)
        {
            
            
            fpscam.enabled = true;
            ChoiceCam.SetActive(false);
            choicecam.enabled = false;
            Mouse = false;
            Destroy(GetComponent<Collider>());
        }
    }
    
        


    


   


    
   

    public void Stopped()
    {
        InteractionMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }
    
    public void Left()
    {
        InteractionMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        Door1Active = true;
        DoorAnim1.SetTrigger("MetalOpen");
        Destroy(GetComponent<Collider>());

    }
    public void Right()
    {
        InteractionMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        Door2Active = true;
        DoorAnim2.SetTrigger("MetalOpen");
        Destroy(GetComponent<Collider>());
    }

}
