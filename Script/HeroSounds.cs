using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSounds : MonoBehaviour
{
    public AudioSource jumpAudio;
    public AudioSource crashAudio;
    public AudioSource scoreAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playJumpSound()
    {
        jumpAudio.Play();   
    }

    public void playCrashSound()
    {
        crashAudio.Play();
    }

    public void playScoreSound()
    {
        scoreAudio.Play();
    }

}
