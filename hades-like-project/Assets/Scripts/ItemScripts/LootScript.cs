﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootScript : MonoBehaviour
{
    GameObject player;
    float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 deltaVec = (player.transform.position - transform.position).normalized;
        GetComponent<Rigidbody2D>().velocity = deltaVec * speed;
        speed += 0.1f;
    }

    public void DestroyMe(){
        Destroy(gameObject);
    }
}
