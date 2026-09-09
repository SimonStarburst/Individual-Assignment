using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerMovement : MonoBehaviour
{
    private Collider2D collider;
    private Rigidbody2D rb;

    [Header("Movement")]
    private Vector2 moveInput;
    [Tooltip ("Adjust movement speed of character")] public int moveSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
    }

    void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }

    void OnMove(InputValue moveValue)
    {
        moveInput = moveValue.Get<Vector2>();
    }
} 