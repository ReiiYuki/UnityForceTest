using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    private Rigidbody2D physic2D;

	public Vector2 upForce = new Vector2 (0f, 15f);
	public Vector2 leftForce = new Vector2 (5f, 0f);
	public Vector2 rightForce = new Vector2 (-5f, 0f);

    void Awake()
    {
        physic2D = GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow))
			physic2D.AddForce( upForce );
        if (Input.GetKeyDown(KeyCode.RightArrow))
            physic2D.AddForce( leftForce );
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            physic2D.AddForce( rightForce );
    }


}
