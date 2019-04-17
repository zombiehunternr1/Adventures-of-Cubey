using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public Transform Player; //the enemy's target
    public float moveSpeed = 3; //move speed
    public float rotationSpeed = 3; //speed of turning
    public float range = 10f; //Range within target will be detected
    public float stop = 0;
    private Transform myTransform; //current transform data of this enemy
    public NavMeshAgent agent;

    void Awake()
    {
        Player = GameObject.FindWithTag("Player").transform; //target the player
        myTransform = transform; //cache transform data for easy access/preformance
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {    //rotate to look at the player
        var distance = Vector3.Distance(myTransform.position, Player.position);
        if (distance <= range)
        {
            agent.SetDestination(Player.position);
            ////look
            //myTransform.rotation = Quaternion.Lerp(myTransform.rotation,
            //Quaternion.LookRotation(Player.position - myTransform.position), rotationSpeed * Time.deltaTime);
            ////move
            //if (distance > stop)
            //{
            //    myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
            //}
            //if (transform.position.y < 0)
            //{
            //    transform.position = new Vector3(transform.position.x, 0, transform.position.z);
            //}
        }
    }
}
