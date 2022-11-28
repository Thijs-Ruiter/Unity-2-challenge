﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldown = 2;
    private float timeStamp = 0;
    private float currentCooldown;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeStamp <= Time.time){
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeStamp = Time.time + cooldown;
        }
    }
}
