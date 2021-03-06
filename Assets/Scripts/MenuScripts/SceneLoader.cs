﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public string url;
    public int downloaded = 0;
    AssetBundle bundle;
    public string AssetName;
    
    public System.Object test;
    public Slider progressbar;

    public float progress;

    WWW www;
    void Update() 
    {
        progress = www.progress;
        progressbar.value = progress;
    }

    IEnumerator Start() 
    {
       // ClearCacheExample ();
        if (downloaded == 0)
        {
            using ( www = WWW.LoadFromCacheOrDownload (url, 0)) 
            {
                yield return www;
                    if (www.error != null)
                        throw new Exception("WWW download had an error:" + www.error);
                    AssetBundle bundle = www.assetBundle;
                    if (AssetName == "")
                        Instantiate(bundle.mainAsset);
                    else
                    {
                         downloaded = 1;
                string[] scenePath = bundle.GetAllScenePaths();
                Debug.Log(scenePath[0]);
                SceneManager.LoadScene(scenePath[0]);
                
                        
                        }
                    // Unload the AssetBundles compressed contents to conserve memory
                    bundle.Unload(true);
            }
            
        }
    }

    void ClearCacheExample()
    {
        Directory.CreateDirectory("Cache1");
        Directory.CreateDirectory("Cache2");
        Directory.CreateDirectory("Cache3");

        Caching.AddCache("Cache1"); 
        Caching.AddCache("Cache2"); 
        Caching.AddCache("Cache3"); 

        bool success = Caching.ClearCache();

        if (!success)
        {
            Debug.Log("Unable to clear cache");
        }
    }
}
