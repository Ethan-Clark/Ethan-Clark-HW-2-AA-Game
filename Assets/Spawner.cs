﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject PinPrefab;
    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
        }
    }
    void SpawnPin()
    {
        Instantiate(PinPrefab, transform.position, transform.rotation);
    }
}
