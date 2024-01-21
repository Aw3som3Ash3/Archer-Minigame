using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateSpawns : MonoBehaviour
{
    public GameObject gM;

    private void Awake()
    {
        gM = GameObject.Find("GameManager");

        gM.GetComponent<Spawner>().CancelSpawns();
        gM.GetComponent<Spawner>().enabled = false;
    }
}
