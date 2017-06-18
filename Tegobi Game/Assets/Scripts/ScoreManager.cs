using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public static int score;
    public static int kills;
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        score = 0;
        kills = 0;
    }
    void Update() {
        if (score < 0)
        {
            score = 0;
        }
        text.text = "" + score;

    }
    public static void addPoints(int points)
    {
        score += points;

    }
    public static void addKills(int x)
    {
        kills += x;

    }
    public static void removePoints(int points)
    {
        score -= points;

    }
    public static void resetPoints(int points)
    {
        score =0;

    }
}
