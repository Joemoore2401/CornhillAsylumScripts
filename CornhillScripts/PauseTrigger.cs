using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseTrigger : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuInterface;
    public GameObject Controls;
    public GameObject Menu;
  
    
    // Start is called before the first frame update


    void Start()
    {
        
       
    }


    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            

            if (GameIsPaused)
            {
                Resume();
             
                
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                
                
                

            }
            else
            {
                Pause();
                
                
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;



                if (Controls == true)
                {

                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }

                if (Menu == true)
                {

                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }




            }
        }

       
    }

    

    public void Resume()
    {
        pauseMenuInterface.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
       
    }
    void Pause()
    {
        pauseMenuInterface.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
       
    }
    public void MainMenu()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        
    }
    public void Quit()
    {
        Application.Quit();
    }

    
   
}
