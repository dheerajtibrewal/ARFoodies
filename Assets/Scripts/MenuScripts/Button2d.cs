using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button2d : MonoBehaviour
{
   public void Scene1()
	{
		SceneManager.LoadScene("2DScene");
	}

     public void Scene2()
	{
		SceneManager.LoadScene("2DScene2");
	}
}
