using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
     public float MoveSpeed = 10f;
     private Rigidbody myBody;

     /// <summary>
     /// Awake is called when the script instance is being loaded.
     /// </summary>
     void Awake()
     {
         myBody = GetComponent<Rigidbody>();
     }
    // Start is called before the first frame update
    void Start()
    {
         //transform = GetComponent<Transform>();
    }

    void MoveBall(){
        float v = Input.GetAxis("Vertical");

        myBody.AddForce(new Vector3(0,v*MoveSpeed,0));
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "wall"){
            Time.timeScale = 0f;
        }
    }


    // Update is called once per frame
    void Update()
    {
        //  if (Input.GetKeyDown("w"))
        // {
        //     print("w key was pressed");
        //     transform.Translate(0,6f*Time.deltaTime,0);
        // }
        MoveBall();
    }
}//class

