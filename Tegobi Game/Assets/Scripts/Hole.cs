using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Hole : MonoBehaviour {
    public GameObject GameOverUI;
    public static bool gameOver = false;
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


            GameOverController.timePlayed = Time.timeSinceLevelLoad;
            gameOver = true;
            GameOverUI.SetActive(true);

            GameObject[] objs;
            objs = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in objs)
            {
                Destroy(Enemy);
            }
            Time.timeScale = 0;
        }

    }
}
