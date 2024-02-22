using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider slider;

    public void TakeDamage(float damage)
    {
        slider.value -= damage;
    }
}
