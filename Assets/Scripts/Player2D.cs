using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player2D : MonoBehaviour
{
    Rigidbody2D rigidbody;
    Vector2 velocity;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * 10;
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + velocity * Time.fixedDeltaTime);
    }
}
