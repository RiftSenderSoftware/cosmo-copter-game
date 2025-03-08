using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class NPCAI : MonoBehaviour
{
    private GameObject player;

    private Transform target;
    private float distanceTarget;
    public NavMeshAgent npcMeshAgent;
    public Animator npcAnimator;
    public NPCDead npcDead;
    // Start is called before the first frame update
    void Start()
    {
        // ищет позицию игрока при старте
        player = GameObject.Find("Player");
        target = player.transform;
    }

    // Update is called once per frame
    void Update()
    {

        if(npcDead.isDead != true) 
        {
            
            // бесконечно чекает расстояние до игрока
            target = player.transform;

            distanceTarget = Vector3.Distance(transform.position, target.position);
            if (distanceTarget > 50)
            {
                npcMeshAgent.enabled = false;
                npcAnimator.SetBool("IdleBool", true);
                npcAnimator.SetBool("RunBool", false);
                npcAnimator.SetBool("RunAttackBool", false);
            }

            if (distanceTarget <= 10 & distanceTarget > 2)
            {
                
                npcMeshAgent.enabled = true;
                npcMeshAgent.SetDestination(target.position);
                npcAnimator.SetBool("IdleBool", false);
                npcAnimator.SetBool("RunBool", true);
                npcAnimator.SetBool("RunAttackBool", false);
            }
            if (distanceTarget <= 2)
            {
                
                npcMeshAgent.enabled = false;
                npcAnimator.SetBool("IdleBool", false);
                npcAnimator.SetBool("RunBool", true);
                npcAnimator.SetBool("RunAttackBool", true);
            }
        }
    }


}
