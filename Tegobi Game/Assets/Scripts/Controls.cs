using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {


    private float moveVelocity;
    public float speed=5f;
    public bool moveright;
    public bool moveleft;
    public bool Space;
    public bool Shoot;
    bool allowShoot=true;
    float fireRate = 0.3f;
    private float lastShot = 0.0f;
    bool facingRight = true;
    public Rigidbody2D rb;
    Animator anim;
    public AudioSource jumpAudio;


    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 700f;



    public GameObject leftBullet, rightBullet;
    public GameObject firePos;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
           

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", grounded);
        anim.SetBool("Speed", false);
     




        /*
        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(move));
        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);
        if (move > 0 && !facingRight)
        {
            Flip();
        }
        else if (move < 0 && facingRight)
            Flip();*/

    }
    void Update() {
        if (HealthController.gameOver == false)
        {
            if (grounded && Input.GetKeyDown(KeyCode.Space) || grounded && Space)
            {
                jumpAudio.Play();
                anim.SetBool("Ground", false);
                rb.AddForce(new Vector2(0, jumpForce));
                Space = false;
            }
            moveVelocity = 0f;
            if (Input.GetKey(KeyCode.LeftArrow) || moveleft)
            {
                anim.SetBool("Speed", true);
                moveVelocity = -speed;
            }
            else if (Input.GetKey(KeyCode.RightArrow) || moveright)
            {
                anim.SetBool("Speed", true);
                moveVelocity = speed;
            }
            rb.velocity = new Vector2(moveVelocity, rb.velocity.y);
            if ((Input.GetKey(KeyCode.RightArrow) || moveright) && !facingRight)
            {
                Flip();
            }
            else if ((Input.GetKey(KeyCode.LeftArrow) || moveleft) && facingRight)
                Flip();

            if ((Input.GetKeyDown(KeyCode.C) || Shoot) && allowShoot)
            {
                Fire();

            }
        }
    }

    private void Fire()
    {
        if (Time.time > fireRate + lastShot)
        {
            if (facingRight)
                Instantiate(rightBullet,firePos.transform.position, Quaternion.identity);
            else if(!facingRight)
                Instantiate(leftBullet, firePos.transform.position, Quaternion.identity);
         lastShot = Time.time;
        }

    }

    void Flip() {

        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;



    }
}
