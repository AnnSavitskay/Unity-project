using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light: MonoBehaviour
{
	 public Light MyLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    	if (Input.GetKeyDown(KeyCode.T)) {
            MyLight.enabled =! MyLight.enabled;
        }
    }
}
