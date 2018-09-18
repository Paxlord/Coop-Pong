using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

    Rigidbody2D rb;
    Vector2 move;
    Collider2D col;

    float Maxspeed = 6f;
    float currentSpeed;

    int nbRebond;

    float speedX;
    float speedY;
    int results;

    bool isDead;

    RaycastHit2D[] hits;

    int collisionCount;
    Vector2 initialPosition;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
        initialPosition = transform.position;

        int randX = (int)Random.value * 2 - 1;
        float randY = Random.value;

        speedX = randX;
        speedY = randY;

        isDead = false;

	}

    private void Update()
    {

        hits = new RaycastHit2D[10];

        results = col.Cast(move.normalized, hits, 0.1f);
    

    }


    // Update is called once per frame
    void FixedUpdate () {
       

        move = new Vector2(speedX, speedY);
        move = move.normalized * Maxspeed;
        move = transform.TransformDirection(move);

        rb.velocity = move;

	}

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.tag == "Player")
        {
            //Si il est à la moitié de la raquette a +- 5 on rebondit tout droit
            float upperBound = collision.transform.position.y + .1f;
            float lowerBound = collision.transform.position.y - .1f;

            if (Maxspeed % 5 == 0)
            {
                Maxspeed += 3;

            }
            else
            {
                Maxspeed++;
            }


            nbRebond++;

            float distToCenter = this.transform.position.y - collision.transform.position.y;

            float yPos = this.transform.position.y;

            if (yPos < upperBound && yPos > lowerBound)
            {
                speedX *= -1;
                speedY *= -1;

            }
            else
            {
                speedX *= -1;
                speedY = distToCenter * 1.5f;
            }

        }

        if (collision.transform.tag == "Mur")
        {
            speedY *= -1;
        }
    }

    public void resetPos()
    {
        this.transform.position = initialPosition;
    }

    public int getNombreRebond()
    {
        return nbRebond;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerScore.setScore(nbRebond);
        isDead = true;
    }

    public bool restartScene()
    {
        return isDead;
    }
}

