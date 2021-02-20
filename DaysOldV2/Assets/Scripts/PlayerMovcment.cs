using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovcment : MonoBehaviour
{
    public float MovementSpeed = 10.0f;
    public Rigidbody2D Rigidbody;
    private Vector2 MovementDirection;

    // Update is called once per frame
    void Update()
    {
        InputProcessing();
    }

    void FixedUpdate()
    {
        Movement();   
    }

    void InputProcessing()
    {
        float MoveX = Input.GetAxisRaw("Horizontal");
        float MoveY = Input.GetAxisRaw("Vertical");

        MovementDirection = new Vector2(MoveX, MoveY).normalized;
    }

    void Movement()
    {
        Rigidbody.velocity = new Vector2(MovementDirection.x * MovementSpeed, MovementDirection.y * MovementSpeed);
    }
}
