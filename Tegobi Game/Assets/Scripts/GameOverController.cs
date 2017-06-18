using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOverController : MonoBehaviour {

    public Text points;
    public Text kills;
    public Text time;
    public static float timePlayed;
    public void loadScene(string name)
    {
        SceneManager.LoadScene(name);
        
    }



    // Use this for initialization
    void Start () {
        points.text = "" + ScoreManager.score;
        kills.text = "" + ScoreManager.kills;
        
    }
	
	// Update is called once per frame
	void Update () {
       
        points.text = "" + ScoreManager.score;
        kills.text = "" + ScoreManager.kills;
        time.text = "" + String.Format("{0:0}:{1:00}", Mathf.Floor(timePlayed / 60), timePlayed % 60); 
        
    }

}
