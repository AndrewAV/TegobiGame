using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour {
    public GameObject GameOverUI;
    public static bool gameOver = false;
    public int playerMaxHealth;
    public static int playerHealth;
    public AudioSource death;
	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        gameOver = false;
        GameOverUI.SetActive(false);
        playerHealth = playerMaxHealth;
	}

    // Update is called once per frame
    void Update() {
        if (playerHealth <= 0) {
            if(gameOver==false)
                death.Play();
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
    public static void hurtPlayer(int DamageToGive) {
        
        playerHealth -= DamageToGive;

    }
    public  void fullHealth() {

        playerHealth = playerMaxHealth;
    }
    public static void addHealth()
    {
        if(playerHealth<100)
            playerHealth += 25;
    }

}
