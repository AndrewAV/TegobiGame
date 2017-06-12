using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public GameObject player;
    public Slider healthBar;
    // Use this for initialization
    void Start()
    {
        healthBar.value =HealthController.playerHealth;
 
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        healthBar.value = HealthController.playerHealth;
        Vector3 theScale = player.transform.localScale;
        theScale.x *= 1;
        GetComponent<RectTransform>().localScale =   theScale;
    }
}
