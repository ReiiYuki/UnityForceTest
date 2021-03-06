﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    private Rigidbody2D physic2D;

    void Awake()
    {
        physic2D = GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow))
            physic2D.AddForce(new Vector2(0f, 15f));
        if (Input.GetKeyDown(KeyCode.RightArrow))
            physic2D.AddForce(new Vector2(5f, 0f));
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            physic2D.AddForce(new Vector2(-5f, 0f));
    }


}
