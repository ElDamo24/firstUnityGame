﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireScript : MonoBehaviour
{
    private playerScript player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.life -= 10;
        }
    }
}
