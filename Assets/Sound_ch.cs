using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_ch : MonoBehaviour
{
public AudioSource Audio;

    //Play the music
    bool m_Play;

    //Detect when you use the toggle, ensures music isn’t played multiple times

    void Start()
    {
        //Fetch the AudioSource from the GameObject
        
        //Ensure the toggle is set to true for the music to play at start-up
        m_Play = true;
        Audio = GetComponent<AudioSource>();
        Audio.Play();
    }

    void Update()
    {
        //Check to see if you just set the toggle to positive
        if (m_Play == true && Input.GetKeyDown(KeyCode.Y))
        {
            //Play the audio you attach to the AudioSource component
            Audio.Stop();
            m_Play = false;
            //Ensure audio doesn’t play more than once
        }
        //Check if you just set the toggle to false
        if (m_Play == false && Input.GetKeyDown(KeyCode.U))
        {
            //Stop the audio
            //Ensure audio doesn’t play more than once
            m_Play = true;
            Audio.Play();
        }
    }
}
