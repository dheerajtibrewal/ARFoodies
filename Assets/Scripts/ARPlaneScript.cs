using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARPlaneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;


    
    void Start()
    {
        
        cube.layer = LayerMask.NameToLayer("ARTestPlane");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
