using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class EnemyGFX : MonoBehaviour
{
    public AIPath aiPath;
    public Animator animator;
    public Rigidbody2D rb;

    // Start is called before the first frame update

    public void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        if (aiPath.desiredVelocity.x > 0.01f)
        {
            animator.Play("enemy_kanan");
        }
    }

    // Update is called once per frame
}
