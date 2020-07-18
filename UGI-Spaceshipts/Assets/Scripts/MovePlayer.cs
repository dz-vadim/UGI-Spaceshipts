using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float Speed = 10;

    [SerializeField] private float leftLimit;
    [SerializeField] private float rigthLimit;
    [SerializeField] private float bottomLimit;
    [SerializeField] private float upperLimit;

    private MovePlayer _engineThrust;

    void Awake()
    {
        if (GetComponent<MovePlayer>() != null)
        {
            _engineThrust = GetComponent<MovePlayer>();
            _engineThrust.enabled = false;
        }
    }

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();        
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if ((horizontal != 0)||((vertical != 0)))
        {
            _rigidbody2D.AddForce(new Vector2(horizontal,vertical)*Speed);

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
