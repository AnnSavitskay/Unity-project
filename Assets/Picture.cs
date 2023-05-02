using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]
public class Picture : MonoBehaviour{
	 private Vector3 screenPoint;
 	private Vector3 offset;
  
     void Start () {
     }
     
     // Update is called once per frame
     void Update () {
     }
     
 void OnMouseDown()
 {
   
 
    offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
 
 }
 
 void OnMouseDrag()
 {
     Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
 
 Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
 transform.position = curPosition;
 
 }
}
