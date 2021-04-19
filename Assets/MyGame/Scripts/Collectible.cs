using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float speed;
    public Spawner spwnr;

    Rigidbody2D rb;

    void Awake()
    {
        spwnr = GameObject.FindWithTag("Master").GetComponent<Spawner>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        spwnr.presentsCollected++;
    }

    void Update()
    {
        rb.velocity = new Vector2(rb.velocity.x, speed);
    }
}
