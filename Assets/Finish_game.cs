using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  

public class Finish_game: MonoBehaviour {  
    public void LoadGame() {  
        SceneManager.LoadScene("MainMenu");  
    }  
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.Escape)){
     SceneManager.LoadScene("MainMenu"); 
     }
    }
    }
