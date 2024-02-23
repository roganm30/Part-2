using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Hero : MonoBehaviour
{
    Vector2 destination;
    Vector2 movement;
    public float speed = 3.0f;
    Rigidbody2D rb;
    Animator animator;
    public float health;
    public float maxHealth = 5.0f;

    // using code from in-class assignment for assistance, with changes made //

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        health = maxHealth;
    }

    private void FixedUpdate()
    {
        movement = destination - (Vector2)transform.position;

        if (movement.magnitude < 0.1 || EventSystem.current.IsPointerOverGameObject())
        {
            movement = Vector2.zero;
        }

        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButtonDown(1) && health > 0)
        {
            Attack();
        }
        animator.SetFloat("Movement", movement.magnitude);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, maxHealth);
        if (health == 0)
        {
            animator.SetTrigger("Death");
            SceneManager.LoadScene(1);
        }
        else
        {
            animator.SetTrigger("TakeDamage");
        }
    }

    public void Attack()
    {
        animator.SetTrigger("Attack");
    }

}
