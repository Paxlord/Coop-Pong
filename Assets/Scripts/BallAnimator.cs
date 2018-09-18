using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAnimator : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = this.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Mur")
        {
            anim.Play("Bounce animation");
        }
        else if(collision.transform.tag == "Player")
        {

            anim.Play("Bounce animation y");

        }
    }
}
