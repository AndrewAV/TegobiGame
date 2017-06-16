using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy;
    float randX;
    Vector2 WhereToSpam;
    public float spawnRate=2f;
    public float NextSpawn = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > NextSpawn)
        {
            NextSpawn = Time.time + spawnRate;
            randX = Random.Range(-33f, 28f);
            WhereToSpam = new Vector2(randX, transform.position.y);
            Instantiate(enemy, WhereToSpam,Quaternion.identity);
        }
	}
}
