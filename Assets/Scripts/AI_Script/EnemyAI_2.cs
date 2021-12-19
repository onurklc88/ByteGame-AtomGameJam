using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI_2 : MonoBehaviour
{
    public float speed;
    public float distance;
    private bool movingRight = true;
    public Transform groundDetection;
    private float AIhealt = 3f;
    private Animator animat;

    private void Start()
    {
        animat = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(groundInfo.collider == false)
        {
            if (movingRight == true) 
            {

                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            animat.Play("Yuruyen_attack");
            AIhealt--;
            if (AIhealt == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
