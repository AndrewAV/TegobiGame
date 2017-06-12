using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour {

    public GameObject enemy;
    public Slider healthBar;
    // Use this for initialization
    void Start()
    {
        healthBar.value = enemy.GetComponent<EnemyHealthController>().getHealth();


    }

    // Update is called once per frame
    void LateUpdate()
    {
        healthBar.value = enemy.GetComponent<EnemyHealthController>().getHealth();
        Vector3 theScale = enemy.transform.localScale;
        theScale.x *= 1;
        GetComponent<RectTransform>().localScale = theScale;
    }
}
