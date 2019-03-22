using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureplatedetecttrigger : MonoBehaviour
{
    public multipressurehandler handler;

    //The audioClip triggersound is being used to check if the sound needs to be played
    public AudioClip triggersound;

    //The audioSource stores the audioSource that's required to play when it's being called
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //Gets the Audio source from the component AudioSource
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        handler.enter();

        //Checks if the triggersound has an MP3 file assigned to it
        if (triggersound != null)
        {
            //Plays the soundeffect only once
            audioSource.PlayOneShot(triggersound, 0.2F);
        }
        //This gets the rendercomponent
        Renderer render = GetComponent<Renderer>();
        //Sets the color of he rendercomponent to green
        render.material.color = Color.green;
    }

    private void OnTriggerExit(Collider other)
    {
        handler.exit();
        //sets the render color back to the original color
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.white;
    }
}
