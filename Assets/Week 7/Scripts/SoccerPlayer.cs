using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoccerPlayer : MonoBehaviour
{
    bool selected = false;
    public SpriteRenderer sprite;
    
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = Color.red;
        Selected(false);
    }

    
    void Update()
    {
         if (selected == true)
        {
            Selected(true);
        }
    }

    public void Selected(bool isSelected)
    {
        if (isSelected)
        {
            sprite.color = Color.yellow;
        }
        else
        {
            sprite.color = Color.red;
        }
    }

    private void OnMouseDown()
    {
        GameController.SetSelectedPlayer(this);
    }
}
