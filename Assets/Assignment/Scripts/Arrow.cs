using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Vector2 destination;
    Vector2 movement;
    public float speed = 2f;
    Rigidbody2D rigidbody;
    Vector2 direction = new Vector2(5, 0);

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 6f);
    }

    private void FixedUpdate()
    {
        movement = (Vector2)GameObject.Find("Hero").transform.position - (Vector2)transform.position;
        rigidbody.MovePosition(rigidbody.position + movement.normalized * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("TakeDamage", 1);
        Destroy(gameObject);
    }
}
