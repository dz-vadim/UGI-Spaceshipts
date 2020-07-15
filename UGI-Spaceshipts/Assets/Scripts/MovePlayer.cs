using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    [SerializeField] private int _speed = 10;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if ((horizontal != 0)||((vertical != 0)))
        {
            _rigidbody2D.AddForce(new Vector2(horizontal,vertical)*_speed);
        }
    }
}
