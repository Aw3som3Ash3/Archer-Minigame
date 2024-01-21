using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartBehavior : MonoBehaviour
{
    GameObject gM;

    void Start()
    {
        gM = GameObject.Find("GameManager");
        Destroy(gM);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}
