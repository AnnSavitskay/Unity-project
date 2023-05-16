using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
   public Rigidbody rb;
   void Update(){
   if (Input.GetKeyDown(KeyCode.X)){
   rb.AddForce(Vector3.up * forceAmount, ForceMode.Impulse);
   }
   }
	public float forceAmount = 10;
void Start()
{
  	 rb.AddForce(Vector3.up * forceAmount, ForceMode.Impulse);
}
}
