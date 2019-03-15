using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class presureplatetrigger : MonoBehaviour
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

    //activates when player enters the trigger area
    private void OnTriggerEnter(Collider collider)
    {
        //Set the trigger boolean to true
        trigger = true;
        //This gets the rendercomponent
        Renderer render = GetComponent<Renderer>();
        //Sets the color of he rendercomponent to green
        render.material.color = Color.green;

        //Checks if the triggersound has an MP3 file assigned to it
        if(triggersound != null)
        {
            //Plays the soundeffect only once
            audioSource.PlayOneShot(triggersound, 0.2F);
        }
    }

    //deactivates when the player leaves the trigger area
    private void OnTriggerExit(Collider other)
    {
        trigger = false;
        //sets the render color back to the original color
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.white;
    }
}
