using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Button2DScript : MonoBehaviour
{
     public UnityEvent OnClick = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit Hit;
         
         if (Input.GetMouseButtonDown(0))
         {
             if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
             {
                 Debug.Log("Button Clicked");
                 transform.gameObject.SetActive(false);
                
                 OnClick.Invoke();
             }
         }    
     }
    }//class

