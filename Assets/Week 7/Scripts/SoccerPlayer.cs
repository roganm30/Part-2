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
        sprite.color = Color.yellow;
    }

    private void OnMouseDown()
    {
        selected = true;
    }
}
