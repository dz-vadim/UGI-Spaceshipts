using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float RateOfFire = 1.0f;
    

    void Start()
    {
        StartCoroutine(Fire(RateOfFire));
    }

    IEnumerator Fire(float RateOfFire)
    {
        while (true)
        {
            yield return new WaitForSeconds(RateOfFire);
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(projectile, transform);
    }
}
