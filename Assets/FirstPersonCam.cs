using UnityEngine;
using System.Collections;

public class FirstPersonCam : MonoBehaviour {

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private float pitch1 = 0.0f;
    public Camera camera;

    void Update () {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        pitch1 -= speedV * Input.GetAxis("Mouse ScrollWheel");

        transform.eulerAngles = new Vector3(pitch, pitch1, yaw);
        
         if(Input.GetKey(KeyCode.W)){
        transform.position += camera.transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= camera.transform.forward * Time.deltaTime;
        }
    }
}
