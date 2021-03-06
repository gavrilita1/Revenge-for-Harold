﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBull_Run : StateMachineBehaviour
{
    public float speed = 2.0f;
<<<<<<< HEAD
    public float attackRange = 6.5f;
    private bool playerFinded = false;
    private float distanceToPlayer = 35.0f;

    Transform player;
    BossBullM bossBull;
    Rigidbody2D rb;

=======
    public float attackRange = 3.5f;
     
    Transform player;
    BossBullM bossBull;
    Rigidbody2D rb;
>>>>>>> parent of 594c6a3... Semifinal


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        bossBull = animator.GetComponent<BossBullM>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        bossBull.LookAtPlayer();
        Vector2 target = new Vector2(player.position.x, rb.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
<<<<<<< HEAD

        if ((Vector2.Distance(player.position, rb.position) <= distanceToPlayer) || playerFinded == true)
        {
            playerFinded = true;
            rb.MovePosition(newPos);
        }
=======
        rb.MovePosition(newPos);
>>>>>>> parent of 594c6a3... Semifinal

        if (Vector2.Distance(player.position, rb.position) <= attackRange)
        {
            animator.SetTrigger("Attack");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
    }

}
