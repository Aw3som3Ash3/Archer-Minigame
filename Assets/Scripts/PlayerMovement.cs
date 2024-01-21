using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float xMove;
    public float playerSpeed = 0.5f;
    private float horizontalScreenLimit = 8.4f;

    public GameObject bulletPrefab;
    public GameObject gM;

    private void Start()
    {
        ResetScore();
    }

    void FixedUpdate()
    {
        Move();
    }
    private void Update()
    {
        xMove = (Input.GetAxis("Horizontal"));

        Shoot();
    }

    void Move()
    {
        transform.Translate (new Vector2 (xMove, 0) * playerSpeed);

        if (transform.position.x > horizontalScreenLimit)
        {
            transform.position = new Vector2(horizontalScreenLimit, -4.5f);
        }
        else if (transform.position.x <= -horizontalScreenLimit)
        {
            transform.position = new Vector2(-horizontalScreenLimit, -4.5f);
        }
    }
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position + new Vector3 (0,1,0), Quaternion.identity); 
        }
    }

    void ResetScore()
    {
        gM = GameObject.Find("GameManager");

        gM.GetComponent<UIBehavior>().score = 0;
    }
}
