using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private enum State
    {
        Idle,
        Walk
    }
    [SerializeField] private Animator animator_;
    [SerializeField] private SpriteRenderer playerSprite;

    [SerializeField] private Rigidbody2D body;

    private const float Speed = 5.0f;

    private Vector2 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        body.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        body.MovePosition(body.position + movement * Speed * Time.deltaTime);
    }
}
