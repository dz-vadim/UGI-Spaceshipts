using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    [SerializeField] private int _speed = 10;

    [SerializeField] private float leftLimit;
    [SerializeField] private float rigthLimit;
    [SerializeField] private float bottomLimit;
    [SerializeField] private float upperLimit;



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

            transform.position = new Vector3
                (
                Mathf.Clamp(transform.position.x, leftLimit, rigthLimit),
                Mathf.Clamp(transform.position.y, bottomLimit, upperLimit),
                transform.position.z
                );
        }
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(new Vector2(leftLimit, upperLimit), new Vector2(rigthLimit, upperLimit));
        Gizmos.DrawLine(new Vector2(leftLimit, bottomLimit), new Vector2(rigthLimit, bottomLimit));
        Gizmos.DrawLine(new Vector2(leftLimit, upperLimit), new Vector2(leftLimit, bottomLimit));
        Gizmos.DrawLine(new Vector2(rigthLimit, upperLimit), new Vector2(rigthLimit, bottomLimit));
    }

#endif
}
