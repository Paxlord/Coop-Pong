using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBall : MonoBehaviour {

    public AudioSource hit_Sound;
    bool isPlaying = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (isPlaying)
        {
            hit_Sound.Play();
            isPlaying = false;
        }   
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        isPlaying = true;

        
    }
}
