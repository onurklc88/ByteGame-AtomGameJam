using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement PM;

    private Rigidbody2D rb;
    private CapsuleCollider2D coll;
    private SpriteRenderer sprite;
    public int currentHealth = 4;
    
    [HideInInspector] public Animator anim;

    [SerializeField] private GameObject ESCPanel;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpSpeed = 12f;
    [SerializeField] private LayerMask JumpableGro;
    [SerializeField] private GameObject mainCame;
    [SerializeField] private AudioClip jump;
    [SerializeField] private AudioClip hurt;
    
    

    public bool bozuk2 = false;
    [SerializeField] private GameObject bozuksil2;
    [SerializeField] private GameObject silinecekler;
    public bool bozuk = false;
    [SerializeField] private GameObject bozuksil;
    private float MoveInput;

    private void Awake()
    {
        PM = this;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<CapsuleCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    
    private void Update()
    {

        if(bozuk == true)
        {
            Move2();
        }
        else
        {
            Move();
        }

        if(bozuk2 == false)
        {
            Jump();
        }
        else
        {

        }
        
        
        ESC();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bozukdegil")
        {
            bozuk = false;
        }
        if (collision.gameObject.tag == "Bozuk")
        {
            bozuk = true;

            Destroy(bozuksil.gameObject);
        }
        if (collision.gameObject.tag == "Bozuk2")
        {
            bozuk2 = true;
            Destroy(silinecekler.gameObject);
            Destroy(bozuksil2.gameObject);
        }


        if (collision.gameObject.tag == "AIbullet")
        {
            anim.Play("damage");
            Camera.main.GetComponent<AudioSource>().PlayOneShot(hurt, 1f);
            currentHealth--;
            HealtBar.HB.SetHealth(currentHealth);
            if (currentHealth <= 0)
            {
                Death();
            }
        }

        if (collision.gameObject.tag == "Lav")
        {
            Death();
        }

        if(collision.gameObject.tag == "AI")
        {
            currentHealth--;
            HealtBar.HB.SetHealth(currentHealth);
            if (currentHealth <= 0)
            {
                Death();
            }
        }
        if(collision.gameObject.tag == "AlevTopu")
        {
            currentHealth--;
            anim.Play("damage");
            HealtBar.HB.SetHealth(currentHealth);
            if (currentHealth <= 0)
            {
                Death();
            }
        }

    }

    private void Move()
    {
        MoveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MoveInput * moveSpeed, rb.velocity.y);
        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

        if (MoveInput > 0.1f)
        {
            sprite.flipX = false;
            
        }
        else if (MoveInput < -0.1f)
        {
            sprite.flipX = true;
            
        }
    }
    private void Move2()
    {
        MoveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MoveInput * -moveSpeed, rb.velocity.y);
        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

        if (MoveInput > 0.1f)
        {
            sprite.flipX = false;

        }
        else if (MoveInput < -0.1f)
        {
            sprite.flipX = true;

        }
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            anim.SetBool("isJump", true);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(jump, 1f);
        }
        if (anim.GetBool("isJump") && (rb.velocity.y <= 0.1f))
        {
            anim.SetBool("isJump", false);
        }

    }


   

    private void Death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("death");
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, JumpableGro);
    }

    private void ESC()
    {
        if (Input.GetButtonDown("Cancel") && Time.timeScale == 1.0f)
        {
            Time.timeScale = 0.0f;
            ESCPanel.SetActive(true);

        }
        else if (Input.GetButtonDown("Cancel") && Time.timeScale == 0.0f)
        {
            Time.timeScale = 1.0f;
            ESCPanel.SetActive(false);

        }
    }


}
