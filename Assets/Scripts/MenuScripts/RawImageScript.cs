using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class RawImageScript : MonoBehaviour
{
    public UnityEvent OnClick = new UnityEvent();
    public RawImage image1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
       
         
         if (Input.GetMouseButtonDown(0))
         {
             
             
                 Debug.Log("Button Clicked");
                // image1.enabled = false;
                 image1.gameObject.SetActive(false);
                
                 OnClick.Invoke();
             
         }    
     }
}
