using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour {

    
    public int enemyHealth;
    public int PointsWhenKilled;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            ScoreManager.addPoints(PointsWhenKilled);
            Destroy(gameObject);
        }

    }
    public void hurtEnemy(int DamageToGive)
    {

        enemyHealth -= DamageToGive;

    }
    public int getHealth() {
        return enemyHealth;
    }
}
