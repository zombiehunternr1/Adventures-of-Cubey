using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputtrigger : MonoBehaviour
{
    //The audioClip triggersound is being used to check if the sound needs to be played
    public AudioClip triggersound;

    //The audioSource stores the audioSource that's required to play when it's being called
    AudioSource audioSource;

    //Created a boolean called triggered and set it to false
    public bool trigger = false;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the Audio source from the component AudioSource
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerStay(Collider other)
    {
        //Detect when the E arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Set the trigger boolean to true
            trigger = true;
        }
          
        
        if (Input.GetKeyUp(KeyCode.E))
        {
            //Checks if the triggersound has an MP3 file assigned to it
            if (triggersound != null)
            {
                //Plays the soundeffect only once
                audioSource.PlayOneShot(triggersound, 0.2F);
                trigger = false;
            }
        }  
    }
}
