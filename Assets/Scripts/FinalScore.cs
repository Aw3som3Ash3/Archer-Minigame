using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public GameObject gM;
    public TextMeshProUGUI scoreText;

    public int score;

    void Start()
    {
        gM = GameObject.Find("GameManager");
        score = gM.GetComponent<UIBehavior>().score;
    }

    void Update()
    {
        scoreText.text = "Score:\n" + score + "/10";
    }
}
