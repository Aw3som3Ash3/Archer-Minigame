using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMBehavior : MonoBehaviour
{
    public static BGMBehavior instance;

    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
