using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookUI : MonoBehaviour
{
    public static bool Paused;
    public GameObject BookUi;
    public GameObject ShowBook;
    public GameObject BookCam;
    public static bool BookDown = false;
    public static bool mouse;
    public static bool KCodeActive;
    public Camera fpscam;
    public Camera bookcam;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ShowBook.SetActive(true);
            KCodeActive = true;


        }

    }


    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ShowBook.SetActive(false);
            KCodeActive = false; 
        }




    }


    void Update()
    {
       
        if(KCodeActive == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (BookDown == true)
                {
                    Stopped();
                }
               
                if(BookDown == false)
                {
                    Down();
                }



            }
           
        }



       


        if (mouse == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (mouse == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
        }

    }



    public void Down()
    {
        BookUi.SetActive(false);
        BookCam.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        mouse = false;
        BookDown = true;
        ShowBook.SetActive(true);
        bookcam.enabled = false;
        fpscam.enabled = true;
    }

    



 






    public void Stopped()
    {
        Time.timeScale = 0f;
        ShowBook.SetActive(false);
        BookCam.SetActive(true);
        BookUi.SetActive(true);
        fpscam.enabled = false;
        bookcam.enabled = true;
        Paused = true;
        mouse = true;
    }





   
}
