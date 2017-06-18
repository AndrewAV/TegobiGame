using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpawn : MonoBehaviour {

    public GameObject HealthPower;
    public GameObject PointsPower;
    public GameObject BombPower;
    float randX;
    Vector2 WhereToSpam;
    public float spawnRate = 2f;
    public float NextSpawn = 0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > NextSpawn)
        {
            NextSpawn = Time.time + spawnRate;
            randX = Random.Range(-33f, 28f);
            WhereToSpam = new Vector2(randX, transform.position.y);

            int num = Random.Range(0, 100);
         
           
            if (num >= 0 && num <60) {
                Instantiate(PointsPower, WhereToSpam, Quaternion.identity);
            }
            else if (num >= 60 && num <90)
            {
                Instantiate(HealthPower, WhereToSpam, Quaternion.identity);
            }
            else if(num >= 90 && num <=100)
                Instantiate(BombPower, WhereToSpam, Quaternion.identity);
        }
    }
}
