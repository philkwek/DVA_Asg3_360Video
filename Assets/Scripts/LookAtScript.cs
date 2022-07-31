using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour
{
    public Transform cameraObj;

    // Start is called before the first frame update
    void Start()
    {
        cameraObj = FindObjectOfType<Camera>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraObj)
        {
            transform.LookAt(cameraObj);
            transform.Rotate(180, 0, 180);
        }
    }
}
