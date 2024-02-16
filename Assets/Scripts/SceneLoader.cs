using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    void Update()
    {
        InstantQuit();
    }

    public void InstantQuit()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quit");
            Application.Quit();
        }
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("Server");
       // SceneManager.LoadScene("Client");
    }



    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }


}
