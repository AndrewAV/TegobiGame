using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Hole : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {

            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Player"))
        {

            Destroy(other.gameObject);
            SceneManager.LoadScene("1");
        }

    }
}
