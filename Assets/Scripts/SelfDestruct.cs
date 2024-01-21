using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float deathTime = 5f;

    void Start()
    {
        Destroy(this.gameObject, deathTime);
    }
}
