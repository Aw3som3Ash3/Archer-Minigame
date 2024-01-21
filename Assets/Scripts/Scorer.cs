using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public GameObject gM;
    public GameObject PopSFX;

    private void Start()
    {
        gM = GameObject.Find("GameManager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "1":
                Destroy(collision.gameObject);
                gM.GetComponent<UIBehavior>().ScoreUp(1);
                Instantiate((PopSFX), transform.position, Quaternion.identity);
                break;

            case "2":
                Destroy(collision.gameObject);
                gM.GetComponent<UIBehavior>().ScoreUp(3);
                Instantiate((PopSFX), transform.position, Quaternion.identity);
                break;

            case "3":
                Destroy(collision.gameObject);
                gM.GetComponent<UIBehavior>().ScoreUp(5);
                Instantiate((PopSFX), transform.position, Quaternion.identity);
                break;

            default:
                break;
        }
    }

}
