using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_script : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("TheWorkshopC");
        //Note!! Change this in future, like this in prototype simply for testing purposes i.e build index interaciton/logging
    }

    public void Quit()
    {
        Debug.Log("Aaron Pastor sucks balls");
        Application.Quit();
    }

    public void Volume_Settings()
    {

    }
}
