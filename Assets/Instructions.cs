using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  

public class Instructions: MonoBehaviour {  
    public void LoadGame() {  
        SceneManager.LoadScene("Instructions");  
    }  
     void Update()
    {if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    } 
    }
