using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float targetSpeed = 0.5f;
    public int randomNumber;

    private void Start()
    {
        GenerateRandomNumber();
    }

    void FixedUpdate()
    {
        transform.Translate (new Vector2 (1, 0) * targetSpeed * randomNumber);
    }
    void GenerateRandomNumber()
    {
        randomNumber = Random.Range(-1, 2);

        if (randomNumber == 0)
        {
            GenerateRandomNumber();
        }
    }
}
