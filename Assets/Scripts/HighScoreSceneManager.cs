using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreSceneManager : MonoBehaviour {

    public Text highScoreMessage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        highScoreMessage.text = "Votre score est de " + PlayerScore.getScore().ToString();

        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(0);
        }
	}
}
