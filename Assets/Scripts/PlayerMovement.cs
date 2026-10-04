using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    private Collider2D collider;
    private Rigidbody2D rb;

    [SerializeField] private PlayerStats playerStats;

    [Header("Movement")]
    public Vector2 moveInput;

    public bool left;
    public bool right;

    [Tooltip("Adjust movement speed of character")] public int moveSpeed;
    #endregion

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>(); 
    }

    void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;      
        LastDirection();
    }

    void OnMove(InputValue moveValue)
    {
        moveInput = moveValue.Get<Vector2>();
    }

    public void LastDirection()
    {
        if (moveInput.x == -1f)
        {
            right = false;
            left = true;
        }
        else if (moveInput.x == 1f)
        {
            left = false;            
            right = true;
        }
    }
} 