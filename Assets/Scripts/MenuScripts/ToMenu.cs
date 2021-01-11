using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToMenu : MonoBehaviour
{
    public void SceneMain()
	{
		SceneManager.LoadScene("MenuUi");
	}

    void Update()
    {
         // Check if Back was pressed this frame
        if (Input.GetKeyDown(KeyCode.Escape)) {
            
           SceneManager.LoadScene("MenuUi");
        }
    }
}//class
