﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudardecor : MonoBehaviour
{
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        rend.material.SetColor("_Color", Random.ColorHSV());

    }
}
