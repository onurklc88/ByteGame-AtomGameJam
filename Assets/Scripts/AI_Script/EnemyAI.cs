using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
   
    private float timeBtwShots;
    private Animator anim;
    public float startTimeBtwShots;

    public GameObject projectile;
    private Transform player;

    private float AIhealt = 5f;

    private void Start()
    {
        //player taglý objenin konumunu bul
        player = GameObject.FindGameObjectWithTag("Player").transform;

      

        timeBtwShots = startTimeBtwShots;
    }

    private void Update()
    {

        //Player'a yaklaþma sýnýrý belirle
        if(Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }
        else if(Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;


        }
        else if(Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);

        }

        if(timeBtwShots <= 0)
        {

            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;

        }
        else
        {

            timeBtwShots -= Time.deltaTime;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            AIhealt--;
            if(AIhealt == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }


}
