﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D : MonoBehaviour
{
	public AudioSource some;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        some.Play();
    }
}
