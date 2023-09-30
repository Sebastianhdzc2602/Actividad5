using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class CarMovement : MonoBehaviour
{
    public PlayerController Movement;

    Vector2 moveDirection = Vector2.zero;
    private InputAction move;


    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    private void Awake()
    {
        Movement = new PlayerController();
    }

    private void OnEnable()
    {
        move = Movement.Player.Move;
        move.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
    }

    void Update()
    {
        moveDirection = move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

  
}
