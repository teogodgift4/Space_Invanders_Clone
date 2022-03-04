using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rigidbody;
    public float speed = 10f;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);
        rigidbody.velocity = dir.normalized * speed ;

        animator.SetBool("isFlyingLeft", h<0);
        animator.SetBool("isFlyingTop", v > 0);
        animator.SetBool("isFlyingRight", h > 0);
    }
}
