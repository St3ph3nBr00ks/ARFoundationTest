using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DD_AppSystems : MonoBehaviour
{
    public DD_Object[] allARObjects; 

    public void DisableAllArObjects()
    {
        allARObjects = FindObjectsOfType<DD_Object>();

        for (int i = 0; i < allARObjects.Length; i++)
        {
            //allARObjects[i].gameObject.SetActive(false);
            Destroy(allARObjects[i].gameObject);
        }

        allARObjects = null;
    }

    public void ResetScene()
    {
        DisableAllArObjects();

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
