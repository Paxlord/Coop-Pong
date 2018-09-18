using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPostProcessManager : MonoBehaviour {

    ScreenShake ss;



	// Use this for initialization
	void Start () {
        ss = Camera.main.GetComponent<ScreenShake>();


	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
       ss.StartShake(.2f, 20, .5f);

        if(collision.transform.tag == "Player")
        {
            StopAllCoroutines();
            IEnumerator timefr = timeFreeze(.05f);
            StartCoroutine(timefr);
        }
    }

    IEnumerator timeFreeze(float duration)
    {
      
        float targetTime = Time.unscaledTime + duration;

        while(targetTime > Time.unscaledTime)
        {
            Time.timeScale = 0;
            yield return null;
        }
       

        Time.timeScale = 1;
    }
}
