﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    bool isOpen;
    Color openColor = Color.green;
    Color closedColor = Color.red;
    RoomManager roomManager;
    // Start is called before the first frame update
    void Start()
    {
        closeDoor();
        roomManager = GameObject.FindGameObjectWithTag("Floor").GetComponent<RoomManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openDoor(){
        gameObject.GetComponentInChildren<SpriteRenderer>().color = openColor;
        isOpen = true;
    }

    public void closeDoor(){
        gameObject.GetComponentInChildren<SpriteRenderer>().color = closedColor;
        isOpen = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player" && isOpen){
            roomManager.playerExitDoor();
        }
    }
}
