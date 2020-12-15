using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CacingPatrol : MonoBehaviour
{

    public Animator animator;

    public float speed;

     Rigidbody2D rb;

    private float waitTime;

    public float startWaitTime;

    public Transform moveSpots;

    public float minX;

    public float maxX;

    public float minY;

    public float maxY;

    void Start(){
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        waitTime = startWaitTime;
        moveSpots.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }
    
    void Update(){
        transform.position = Vector2.MoveTowards(transform.position, moveSpots.position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, moveSpots.position) < 0.2f){
            if(waitTime <= 0)
            {
                moveSpots.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                waitTime = startWaitTime;
            }   else
                {
                        waitTime -= Time.deltaTime;
                }
        }
    }
    public void anim(){
        transform.position = Vector2.MoveTowards(transform.position, moveSpots.position, speed * Time.deltaTime);
        animator.SetFloat("moveX", transform.position.x);
        animator.SetFloat("moveY", transform.position.y);
    }
}