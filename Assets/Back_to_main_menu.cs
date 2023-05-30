using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  

public class Back_to_main_menu: MonoBehaviour {  
    public void LoadGame() {  
        SceneManager.LoadScene("MainMenu");  
    } 
    void Update()
    {if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    } 
    }
