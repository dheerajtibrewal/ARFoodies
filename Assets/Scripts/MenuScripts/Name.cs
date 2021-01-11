using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Name : MonoBehaviour
{
    public InputField nameField;
    public Text username;
    // Start is called before the first frame update
    void Start()
    {
        //username = "hello";
       
    }

    // Update is called once per frame
    void Update()
    {
         username.text = nameField.text;
    }
}
