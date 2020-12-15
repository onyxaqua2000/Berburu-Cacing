using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour

{
    public Rigidbody2D myRB;
    public Animator myAnim;

    public bool canMove;

    public float speed;

    // Update is called once per frame
    void Start()
    {
        canMove = false;
        myAnim = GetComponent<Animator>();
        myRB = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        myRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;

        myAnim.SetFloat("moveX", myRB.velocity.x);
        myAnim.SetFloat("moveY", myRB.velocity.y);

        if(Input.GetAxisRaw("Horizontal") ==1 || Input.GetAxisRaw("Horizontal") ==-1 || Input.GetAxisRaw("Vertical") ==1 || Input.GetAxisRaw("Vertical") ==-1)
        {
            myAnim.SetFloat("LastX", Input.GetAxisRaw("Horizontal"));
            myAnim.SetFloat("LastY", Input.GetAxisRaw("Vertical"));
        }
    }
}
