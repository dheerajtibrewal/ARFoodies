using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAR : MonoBehaviour
{
    public void Scene1()
	{
		SceneManager.LoadScene("ARscene1");
	}

     public void Scene2()
	{
		SceneManager.LoadScene("ARscene2");
	}
}
