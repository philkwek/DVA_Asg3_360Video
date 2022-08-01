using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAroundScript : MonoBehaviour
{
    public float speed = 3;
    public float zoomSensitivity = 1.5f;
    public Camera mainCamera;

    private void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //Camera Look around
        if (Input.GetMouseButton(0))
            {
                transform.RotateAround(transform.position, -Vector3.up, speed * Input.GetAxis("Mouse X"));
                transform.RotateAround(transform.position, transform.right, speed * Input.GetAxis("Mouse Y"));
            };

        //Camera zooming 
        mainCamera.fieldOfView += zoomSensitivity * Input.mouseScrollDelta.y;
        if (mainCamera.fieldOfView > 100)
        {
            mainCamera.fieldOfView = 100;
        };
        if (mainCamera.fieldOfView < 10)
        {
            mainCamera.fieldOfView = 10;
        }
    }
}
