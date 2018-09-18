using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float vSpeed;
    public float accelerationFactor = .7f;
    public float deccelerationFactor = 1f;
    public string vAxis;
    public float currentSpeed = 0;

    

    int id;
    float lastSign;
    Vector2 Move;
    float axis;

    private Rigidbody2D rb;
    Vector2 initialPosition;

	// Use this for initialization
	void Start () {

        rb = this.GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

        axis = Input.GetAxisRaw(vAxis);

    }

    public void FixedUpdate()
    {

        if (axis == 0)
        {
            currentSpeed -= (accelerationFactor);
        }
        else
        {
            currentSpeed += accelerationFactor;
            lastSign = Mathf.Sign(axis);

        }

        currentSpeed = Mathf.Clamp(currentSpeed, 0, vSpeed);

        Move = new Vector2(0, lastSign * currentSpeed);


        rb.velocity = Move;
    }

    public void resetPos()
    {
        this.transform.position = initialPosition;
    }

}
