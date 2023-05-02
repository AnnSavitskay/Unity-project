using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
	public void Move_X(float x){
		Vector3 move = new Vector3(1, 0, 0);
		transform.Translate(move*x*Time.deltaTime);
	}
	
	public void Move_Y(float y){
		Vector3 move = new Vector3(0, 1, 0);
		transform.Translate(move*y*Time.deltaTime);
		}
	
	public void Move_Z(float z){
		Vector3 move = new Vector3(0, 0, 1);
		transform.Translate(move*z*Time.deltaTime);
		}
	
	public void diagonal(float x, float y, float z)
	{
		Vector3 move = new Vector3(x, y, z);
		transform.Translate(move*Time.deltaTime);
	}
	
	public void Rotate_up(float x){
		transform.rotation = Quaternion.Euler(0, 90*x, 0);
	}
	
	public void Rotate_right(float x){
		transform.rotation = Quaternion.Euler(0, 0, 90*x);
	}
	
	public void Rotate_forward(float x){
		transform.rotation = Quaternion.Euler(90*x, 0, 0);
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P)){
    		Move_X(1);
    	}
    	 if(Input.GetKey(KeyCode.O)){
    		Move_X(-1);
    	}
    	if(Input.GetKey(KeyCode.K)){
    		Move_Y(1);
    	}
    	if(Input.GetKey(KeyCode.L)){
    		Move_Y(-1);
    	}
    	if(Input.GetKey(KeyCode.N)){
    		Move_Z(1);
    	}
    	if(Input.GetKey(KeyCode.M)){
    		Move_Z(-1);
    	}
    //	if(Input.GetKey(KeyCode.Up)){
    	//	Rotate_up(0.1f);
    //	}
    	transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Horizontal"), 0);
    	transform.rotation *= Quaternion.Euler(Input.GetAxis("Vertical"), 0, 0);
    /*	if(Input.GetKeyDown(KeyCode.Left)){
    		Rotate_right(0.1f);
    	}
    	if(Input.GetKeyDown(KeyCode.Right)){
    		Rotate_right(-0.1f);
    	}
   */ }
}
