﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField]
    private GameObject bluObj;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(redObj, new Vector3(2.0f, 0.0f, 0.0f), Quaternion.identity);
        Instantiate(bluObj, new Vector3(-2.0f, 0.0f, 0.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
