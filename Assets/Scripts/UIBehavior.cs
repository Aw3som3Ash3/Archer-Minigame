using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIBehavior : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public int score = 0;
    public int scoreToBeat = 10;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        //scoreText = GameObject.Find("Score");
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    public void ScoreUp(int scoreToAdd)
    {
        score = score + scoreToAdd;
    }
    public void StartEndGame()
    {
        if (score >= scoreToBeat)
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }
}
