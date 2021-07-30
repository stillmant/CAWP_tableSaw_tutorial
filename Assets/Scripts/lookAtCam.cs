using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtCam : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // make text "face" the camera phone
        transform.rotation = Quaternion.LookRotation(transform.position - target.transform.position);
    }
}
