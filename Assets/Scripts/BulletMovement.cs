using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed = 0.25f;

    void FixedUpdate()
    {
        transform.Translate(new Vector2(0, bulletSpeed));
    }
}
