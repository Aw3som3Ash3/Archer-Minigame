using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Timer : MonoBehaviour
{
    public int timeLeft = 10;

    GameObject gM;
    public TextMeshProUGUI timerText;

    void Start()
    {
        gM = GameObject.Find("GameManager");
        InvokeRepeating("TimerMethod", 1f, 1f);
    }

    void Update()
    {
        timerText.text = "" + timeLeft;
    }
    public void TimerMethod()
    {
        if (timeLeft > 0)
        {
            timeLeft--;
        }

        if (timeLeft <= 0)
        {
            timeLeft = 0;
            gM.GetComponent<UIBehavior>().StartEndGame();
        }
    }
}
