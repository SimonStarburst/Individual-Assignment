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

    private Vector2 direction;
    public float moveSpeed;

    [Header("Positions")]
    public Vector2 mousePosition;
    public Vector2 playerPosition;


    [Header("Boleans")]
    public bool left;
    public bool right;
    public bool mouseControl;
    public bool keyboardControl;


    #endregion

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
        mouseControl = false;
        keyboardControl = false;
    }

    void Start()
    {
        moveSpeed = playerStats.moveStat;
    }

    void Update()
    {
        playerPosition = gameObject.transform.position;
        rb.linearVelocity = moveInput * moveSpeed;
        LastDirectionKeyboard();        
        //If - sats that looks for if mouse or keyboard was most recently used to decide which move
        // controls should be used
        if (mouseControl)
        {
            MouseMovement();
        }
    }

    void OnMove(InputValue moveValue)
    {
        moveInput = moveValue.Get<Vector2>();
    }

    public void LastDirectionKeyboard()
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

    public void LastDirectionMouse()
    {
        if (mousePosition.x < playerPosition.x)
        {
            right = false;
            left = true;
        }
        else if (mousePosition.x > playerPosition.x)
        {
            left = false;
            right = true;
        }
    }

    public void OnMouseClick(InputValue clickValue)
    {
        mouseControl = true;
        mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Debug.Log(mousePosition);
    }

    public void MouseMovement()
    {      
        LastDirectionMouse();
        direction = mousePosition - rb.position;
        rb.linearVelocity = direction.normalized * moveSpeed;

        //// If Player is getting close to mousePosition, stop their movement
        if (mouseControl && Vector2.Distance(playerPosition, mousePosition) < 1f)
        {
            Debug.Log("Destination reached");            
            mouseControl = false;
        }
    }
}