using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public Vector2 speed;
    Rigidbody2D rg;
    public int damage;
	// Use this for initialization
	void Start ()
    {
        rg = GetComponent<Rigidbody2D>();
        rg.velocity = speed;
    }
	
	// Update is called once per frame
	void Update ()
    {
        rg.velocity = speed;
    }
    void OnCollisionEnter2D(Collision2D other) {

        if (other.gameObject.CompareTag("Enemy")) {
            other.gameObject.GetComponent<EnemyHealthController>().hurtEnemy(damage);
            Destroy(gameObject);
        }

    }
}
