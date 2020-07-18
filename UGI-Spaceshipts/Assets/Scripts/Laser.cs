using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject PrefabLaser;
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
            PrefabLaser.SetActive(!PrefabLaser.activeSelf);
        }
    }
}
