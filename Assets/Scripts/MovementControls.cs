using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour {
    public float speed = 5;
    public bool onground = true;
    BoxCollider2D groundCollider;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
        gravity();
        
	}

    void Movement() {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onground)
            {
                this.GetComponent<Rigidbody2D>().velocity += new Vector2(0f, 10f);
                onground = false;
           
            }
        }
    }
    void gravity()
    {
        this.GetComponent<Rigidbody2D>().velocity += new Vector2(0f, -1f);
    }

}
