using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public GameObject arrow;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        arrow.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void WeaponSpawn()
    {
        Instantiate(arrow, spawn.position, spawn.rotation);
    }
}
