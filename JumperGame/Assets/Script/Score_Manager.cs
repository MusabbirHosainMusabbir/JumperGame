using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{
    public static int score;
    public Text ScoreText;

    public Text highscoreText;

   //Awake is called befor the first frame update
    private void Awake()
    {
        ScoreText = GetComponent<Text>();
        score = 0;

    }
    // Start is called before the first frame update
    void Start()
    {
        highscoreText.text = "Best: " + PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        //score(Code)
        ScoreText.text = "" + score;

        //HighScore(Code)
        int highscore = PlayerPrefs.GetInt("highscore");
        if (score > highscore)
        {

            PlayerPrefs.SetInt("highscore", score);
            highscoreText.text = "Best: " + PlayerPrefs.GetInt("highscore");
        }
    }
}
