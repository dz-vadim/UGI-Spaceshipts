using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engines : MonoBehaviour
{
    private MovePlayer _engineThrust;
    void Start()
    {
        if (GetComponentInParent<MovePlayer>() != null)
        {
            _engineThrust = GetComponentInParent<MovePlayer>();
            _engineThrust.enabled = true;
            _engineThrust.Speed *= 1.5f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
