using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionMenu3 : MonoBehaviour
{
    public static bool Door2Active;
    public static bool Door3Active;
    public static bool Paused;
    public static bool Mouse = false;
    public GameObject InteractionMenuUI;
    public Camera SwitchCam;
    public Camera FpsCam;
    public GameObject FpsCom;
    public Animator DoorAnim2;//Highlights which animation to assign to the variable
    public Animator DoorAnim3;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Stopped();
            FpsCom.SetActive(false);
            FpsCam.enabled = false;
            InteractionMenuUI.SetActive(true);
            SwitchCam.enabled = true;
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
        if (Mouse == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
        }

        if (Door2Active == true)
        {
            SwitchCam.enabled = false;
            FpsCam.enabled = true;
            FpsCom.SetActive(true);
            Mouse = false;
            Destroy(GetComponent<Collider>());
        }




        if (Door3Active == true)
        {
            SwitchCam.enabled = false;
            FpsCam.enabled = true;
            FpsCom.SetActive(true);
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
        Door2Active = true;
        DoorAnim2.SetTrigger("MetalOpen");
        Destroy(GetComponent<Collider>());

    }
    public void Right()
    {
        InteractionMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        Door3Active = true;
        DoorAnim3.SetTrigger("MetalOpen");
        Destroy(GetComponent<Collider>());
    }
}
