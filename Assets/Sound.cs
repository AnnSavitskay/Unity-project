using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

	public AudioSource MyAudio;

    //Play the music
    bool m_Play;
    //Detect when you use the toggle, ensures music isn’t played multiple times

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        MyAudio = GetComponent<AudioSource>();
        //Ensure the toggle is set to true for the music to play at start-up
        m_Play = true;
    }

    void Update()
    {
        //Check to see if you just set the toggle to positive
        if (m_Play == true && Input.GetKeyDown(KeyCode.M))
        {
            //Play the audio you attach to the AudioSource component
            MyAudio.Play();
            m_Play = false;
            //Ensure audio doesn’t play more than once
        }
        //Check if you just set the toggle to false
        if (m_Play == false && Input.GetKeyDown(KeyCode.U))
        {
            //Stop the audio
            MyAudio.Stop();
            //Ensure audio doesn’t play more than once
            m_Play = true;
        }
    }
    
    
	/*public GameObject sound;
	public AudioClip din;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(this.name == "din" && Input.GetKeyDown(KeyCode.M)) {
            GetComponent<AudioSource>().Play(din);
      }
    }*/
}
