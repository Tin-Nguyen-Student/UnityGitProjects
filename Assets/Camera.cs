using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject thingtoFollow;
    // The things position (camera) should be the same as the car's position
    

    
    void LateUpdate()
    {
        transform.position = thingtoFollow.transform.position + new Vector3 (0, 0, -10);
       
    }
}
