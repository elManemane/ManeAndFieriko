using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoblinMovement : BasicStats
{
    public Transform target;
    public NavMeshAgent Nav;
    public Animator Anim;

    private void Start()
    {
            Nav.speed = Speed;
    }
    void Update()
    {
        Nav.destination = target.position;
        if(target.tag == "Player")
        {
            Anim.SetBool("isRunning", true);
        }
        else
        {
            Anim.SetBool("isRunning", false);
        }
    }
}
