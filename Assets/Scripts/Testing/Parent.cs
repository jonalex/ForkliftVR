﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{

    public Transform player;
    public Transform car;
    public bool b;

    private void Update()
    {

       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.SetParent(car);
            b = true;
        }
      
    }


}