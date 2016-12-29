using System.Collections;
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
        if (Input.GetKey("down"))
            print("down arrow key is held down");
    }


}
