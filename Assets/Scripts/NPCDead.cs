using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDead : MonoBehaviour
{
    public GameObject[] NPCBodyGM;
    public Rigidbody[] NPCBodyRB;
    public Collider[] NPCBodyCollider;
    public NPCHealth NPCHealthScript;
    public NPCAI NPCAiScript;
    public Animator animator;

    public AudioSource panchHand;

    public bool isDead = false;

    private void Update()
    {
        if (NPCHealthScript.NPCHealthPoint < 0)
        {
            isDead = true;
            NPCAiScript.npcMeshAgent.enabled = false;
            animator.enabled = false;
            NPCBodyRB[0].isKinematic = false;
            NPCBodyRB[1].isKinematic = false;
            NPCBodyRB[2].isKinematic = false;
            NPCBodyRB[3].isKinematic = false;
            NPCBodyRB[4].isKinematic = false;
            NPCBodyRB[5].isKinematic = false;
            NPCBodyRB[6].isKinematic = false;
            NPCBodyRB[7].isKinematic = false;
            NPCBodyRB[8].isKinematic = false;
        }
    }
    public void EmenyDead(GameObject other)
    {
        
        if (other.gameObject.tag == "Hands")
        {
            NPCHealthScript.NPCHealthPoint -= 30;
            panchHand.Play();
            if (NPCHealthScript.NPCHealthPoint < 0)
            {
                isDead = true;
                NPCAiScript.npcMeshAgent.enabled = false;
                animator.enabled = false;
                NPCBodyRB[0].isKinematic = false;
                NPCBodyRB[1].isKinematic = false;
                NPCBodyRB[2].isKinematic = false;
                NPCBodyRB[3].isKinematic = false;
                NPCBodyRB[4].isKinematic = false;
                NPCBodyRB[5].isKinematic = false;
                NPCBodyRB[6].isKinematic = false;
                NPCBodyRB[7].isKinematic = false;
                NPCBodyRB[8].isKinematic = false;
            }
        }
    }
}
