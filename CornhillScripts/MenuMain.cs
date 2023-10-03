using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMain : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }


    public void OnTriggerEnter(Collider other)
    {
        
        SceneManager.LoadScene("GameOver");
    }

    public void EasyLevel()
   {
        SceneManager.LoadScene("SampleScene");
   }

   public void MediumLevel()
   {
       SceneManager.LoadScene("WarningLevel");
   }
   public void HardLevel()
   {
       SceneManager.LoadScene("HardLevel");
   }

    public void QuitGame()
    {
        Application.Quit();
    }
}
