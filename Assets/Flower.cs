using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour{
    Vector3 a;
    Vector3 b;
    public CharacterController controller;

	public Camera camera;
    public float speed = 5f;
    //Vector3 pos;
    public Vector3 pos;
Plane plane = new Plane(Vector3.up, 0);

    // Start is called before the first frame update
    void Start()
    {
     b = transform.position;// initial value

	//camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
   	  float distance;
    	Ray ray = camera.ScreenPointToRay(Input.mousePosition);
    	if (plane.Raycast(ray, out distance))
    	{
        	pos = ray.GetPoint(distance);
    	}
  	//  Vector3 mousePos = Input.mousePosition;
 	//  mousePos.z = camera.nearClipPlane;
	//  pos = camera.ScreenToWorldPoint(mousePos);
    	//Vector3 pos = camera.ScreenToWorldPoint(Input.mousePosition);
    	//Vector3 pos = Input.mousePosition;
        a = transform.position;
        if (Input.GetKey(KeyCode.Space)){

        	if (Input.GetMouseButtonDown(0))
        	{
            		b = pos;
            
        	}
        	transform.position = Vector3.MoveTowards(a, b, speed);
        }
    }
}
