using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    Transform transform;
    Vector3 start;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        start = transform.position;
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "rightwall"){
             transform.position = start;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(2f*Time.deltaTime,0,0);
        
    }
}
