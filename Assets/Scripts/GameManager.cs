using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public BallBehaviour ball;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       if (ball.restartScene())
       {
            SceneManager.LoadScene(1);
       }
	}

    
}
