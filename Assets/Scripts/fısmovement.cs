using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fısmovement : MonoBehaviour
{
    private float horiInput;
    private float vectInput;
    [SerializeField] private float speed = 10f;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        horiInput = Input.GetAxis("Horizontal");
        vectInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(horiInput * speed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, vectInput * speed);




    }
}
