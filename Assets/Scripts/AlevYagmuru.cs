using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlevYagmuru : MonoBehaviour
{
    
    [SerializeField] private GameObject Particle;
    [SerializeField] private float speed;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Vector2 newPos = new Vector2(Random.Range(360f, 451f), -21f);

        transform.position = newPos;

        rb.AddForce(new Vector2(0, -1 * speed));



    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 10f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
        GameObject newParticle = Instantiate(Particle, transform.position, Quaternion.identity);
        Destroy(newParticle, 5f);
    }
}
