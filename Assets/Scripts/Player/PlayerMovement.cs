using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    private Rigidbody2D rb;

    [SerializeField] private PlayerStats playerStats;
    private Camera cam;

    [Header("Movement")]
    public Vector2 moveInput;
    private Vector2 mousePosition;

    public bool left;
    public bool right;

    public float moveSpeed;
    #endregion

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    void Start()
    {
        moveSpeed = playerStats.moveStat;
    }

    void Update()
    {

        rb.linearVelocity = moveInput * moveSpeed;        
        //MouseMovement();
        LastDirection();
    }

    void FixedUpdate()
    {


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
    
    //public void OnMouseClick(InputValue clickValue)
    //{
    //    mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
    //}

    //public void MouseMovement()
    //{
    //    //rb.linearVelocity = Vector2.MoveTowards(gameObject.transform.position, mousePosition, moveSpeed);
    //    Vector2 direction = mousePosition - rb.position;
    //    rb.linearVelocity = direction.normalized * moveSpeed;
    //}
}