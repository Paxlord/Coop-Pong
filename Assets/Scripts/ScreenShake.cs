using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour {

    private float speed;
    private float magnitude;


	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
    }

    IEnumerator Shake(float duration, float speed, float magnitude)
    {
        float startTime = Time.time;
        float endTime = startTime + duration;

        while(endTime > Time.time)
        {
            this.transform.position = new Vector3((Mathf.PerlinNoise(Time.time * speed, 0) - 0.5f) * magnitude, (Mathf.PerlinNoise(0, Time.time * speed) - 0.5f) * magnitude, -10);
            yield return null;
        }

        this.transform.position = new Vector3(0, 0, -10);
    }

    public void StartShake(float duration, float speed, float magnitude)
    {
        StopAllCoroutines();
        IEnumerator coroutine = Shake(duration, speed, magnitude);
        StartCoroutine(coroutine);

    }
}
