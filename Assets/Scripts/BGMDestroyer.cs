using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMDestroyer : MonoBehaviour
{
    void OnAwake()
    {
        
    }

    void Start()
    {
        Destroy(GameObject.Find("BGM"));
    }

    void Update()
    {
        
    }
}
