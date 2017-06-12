using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowIA : MonoBehaviour {

    Transform Player;
    public float speed = 3f;
  


    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {

        
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);

    }
}
