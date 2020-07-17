using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[RequireComponent(typeof(Rigidbody2D))]
public class EnemyShoot : MonoBehaviour
{
    public float yOffset;
    public GameObject bullet;

    public float speedShoot;


    private void Start()
    {
        InvokeRepeating("Shoot", speedShoot, speedShoot);
    }

    private void Shoot()
    {

        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y - yOffset, 0), Quaternion.identity);

    }

}
