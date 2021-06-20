using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomWithMouseWheel : MonoBehaviour
{
    public float ScrollSpeed = 10;
    public Camera ZoomCamera;

    // Start is called before the first frame update
    void Start()
    {
        ZoomCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
   		
		ZoomCamera.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
     
    }
}
