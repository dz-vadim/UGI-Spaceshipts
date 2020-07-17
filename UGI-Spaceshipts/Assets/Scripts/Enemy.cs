using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<MovePlayer>())
        {
            //Destroy(collision.gameObject);
            Time.timeScale = 0f;
        }
        Destroy(gameObject);
    }
}
