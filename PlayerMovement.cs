using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;

    private int direccion = 1;
    Animator anim;
    private bool hasControl;
    private bool walk;

    private Vector2 velocity;

    private Rigidbody2D rb;

	void Start ()
    {
        hasControl = true;
        rb = GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
	}

    void Update()
    {
        if (!hasControl) return;
        walk = Input.GetKey(KeyCode.Space);
        if(Input.GetKeyDown(KeyCode.Space)== true)
        {
            anim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(KeyCode.Space)==true)
        {
            anim.SetBool("Walk", false);

        }
    }

    void FixedUpdate ()
    {
        if (walk)
        {
            velocity = rb.velocity;
            velocity.x = direccion * speed;
            rb.velocity = velocity;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
	}

    public void SetHasControl(bool condition)
    {
        if (!condition) walk = false;

        hasControl = condition;
    }

    public void Move()
    {
        walk = true;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        EventLuncher myEventType = col.gameObject.GetComponent<EventLuncher>();

        myEventType.Lunch();
    }
}
