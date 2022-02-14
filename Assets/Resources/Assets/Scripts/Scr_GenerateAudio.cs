using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_GenerateAudio : MonoBehaviour
{
    private AudioSource Audio_emitter;

    private AudioClip Snd_Coin;

    
    private float playsoundtimestart;

    [SerializeField]    //Makes private fields viewable in Unity Inspector- watch the countdown!
    private float playsoundtime_current;

    // Start is called before the first frame update
    void Start()
    {
        /*
            Load the audio file as an AudioClip using Reosurces.Load()
        */

        Snd_Coin = Resources.Load<AudioClip>("Assets/Audio/snd_Pickup_Coin");

        
        //Audio_emitter = gameObject.AddComponent<AudioSource>();

       /*
            We are setting two float variables one will be our length of time and 
            the other will be how long is left
        */

        playsoundtimestart = 2.0f;

        playsoundtime_current = playsoundtimestart;

    }

    // Update is called once per frame
    void Update()
    {
        /*
            Count down to 0 and then we will play our audio
         */
        playsoundtime_current -= Time.deltaTime;
        if (playsoundtime_current <= 0) 
        {
            /*
                Reset Timer so we can go again
            */

            playsoundtime_current = playsoundtimestart;

            /*
                Play sound using audio emitter (it is commented deliberately)
            */

            //Audio_emitter.PlayOneShot(Snd_Coin);


            /*
               Play sound at position using one time emitter 
           */
            AudioSource.PlayClipAtPoint(Snd_Coin, transform.position);
            
        }
    }
}
