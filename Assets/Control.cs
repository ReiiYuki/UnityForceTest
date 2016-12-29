using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    private Rigidbody2D physic2D;
    private bool isPress;

    void Awake()
    {
        physic2D = GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	void Update () {
        if (!isPress&&Input.GetKeyDown(KeyCode.Space))
            physic2D.AddForce(new Vector2(0f, 30f));
    }


}
