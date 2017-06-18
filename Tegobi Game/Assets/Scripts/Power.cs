using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            if (gameObject.CompareTag("Health")) {

                HealthController.addHealth();
                Destroy(gameObject);
            }
            if (gameObject.CompareTag("Points"))
            {

                ScoreManager.addPoints(25);
                Destroy(gameObject);
            }
            if (gameObject.CompareTag("Bomb"))
            {

                GameObject[] objs;
                objs = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (GameObject Enemy in objs)
                {
                    Destroy(Enemy);
                }
                Destroy(gameObject);
            }
        }

    }

}
