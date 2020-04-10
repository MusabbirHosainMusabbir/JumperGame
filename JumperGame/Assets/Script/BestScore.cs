using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    public Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        highscoreText.text = "Best: " + PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        int highscore = PlayerPrefs.GetInt("highscore");
        if (Score_Manager.score > highscore)
        {

            PlayerPrefs.SetInt("highscore", Score_Manager.score);
            highscoreText.text = "Best: " + PlayerPrefs.GetInt("highscore");
        }
    }
}
