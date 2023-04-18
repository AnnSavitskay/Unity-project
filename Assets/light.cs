using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light: MonoBehaviour
{
	public GameObject Light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
        	GetComponent<Light>().intensity = 0;
        }
    }
}
