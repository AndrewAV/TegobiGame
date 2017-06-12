using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour {

    public int playerMaxHealth;
    public static int playerHealth;
	// Use this for initialization
	void Start () {
        playerHealth = playerMaxHealth;
	}

    // Update is called once per frame
    void Update() {
        if (playerHealth <= 0) {
            
            Destroy(gameObject);
            SceneManager.LoadScene("1");
            
        }

	}
    public static void hurtPlayer(int DamageToGive) {

        playerHealth -= DamageToGive;

    }
    public  void fullHealth() {

        playerHealth = playerMaxHealth;
    }

}
