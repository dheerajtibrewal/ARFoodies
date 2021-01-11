using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class set : MonoBehaviour
{
public GameObject panel;
  
    void Awake()
    {
        if(PlayerPrefs.HasKey("keystest1"))
{
    // Not the first start because pref exists
    // Don't show help
    panel.SetActive(false);
}
else
{
    // First start because pref does not exist
    // Create pref
    PlayerPrefs.SetInt("keystest1",1);
    //PlayerPrefs.Save();
    // Show help
    panel.SetActive(true);
}


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
