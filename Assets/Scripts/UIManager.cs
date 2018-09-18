using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text score;
    public BallBehaviour ball;

	void Start () {
		
	}
	
	void Update () {
        score.text = ball.getNombreRebond().ToString() ;
	}
}
