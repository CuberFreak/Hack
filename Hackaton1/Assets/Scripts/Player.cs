using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Vector2 moveVelocity;

    private 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.deltaTime);
        sprite.flipX = moveVelocity.x < 0.0f;
    }
}
