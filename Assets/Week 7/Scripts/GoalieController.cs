using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalieController : MonoBehaviour
{
    public Rigidbody2D goalieRB;
    Vector2 direction;
    float magnitude;
    public float radius = 2.4f;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.SelectedPlayer == null) return;

        direction = (Vector2)transform.position - (Vector2)GameController.SelectedPlayer.transform.position;
        magnitude = direction.magnitude;
        direction.Normalize();
    }

    private void FixedUpdate()
    {
        if(magnitude / 2 < radius)
        {
            goalieRB.position = Vector2.MoveTowards(goalieRB.position, (Vector2)transform.position - direction * magnitude / 2, speed);
        } 
        else
        {
            goalieRB.position = Vector2.MoveTowards(goalieRB.position, (Vector2)transform.position - direction * radius, speed);
        }
    }
}
