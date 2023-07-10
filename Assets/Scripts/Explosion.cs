using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float Radius;
    public float Force;

    public bool active;

    public GameObject ExplosionEffect;
    private void Update()
    {
        if (active)
        {
            ExplodeWithDelay();
        }
    }

    private bool _explosionDone;

    public void ExplodeWithDelay()
    {
        if (_explosionDone) return;
        _explosionDone = true;
        Invoke("Explode", 0.5f);
    }
    public void Explode()
    {
        
        Collider[] overlappedColliders = Physics.OverlapSphere(transform.position, Radius);

        for(int i = 0; i < overlappedColliders.Length; i++) 
        {

            Rigidbody rigidbody = overlappedColliders[i].attachedRigidbody;
            

            /*
            GameObject game = overlappedColliders[i].gameObject;
            if (game)
            {
                // воздействие взрыва на нпц
                //NPCHealth npcHealth = rigidbody.GetComponent<NPCHealth>();
                NPCHealth npcHealth = game.GetComponent<NPCHealth>();
                if (npcHealth)
                {
                    if (Vector3.Distance(transform.position, game.transform.position) < Radius)
                    {
                        npcHealth.NPCHealthPoint -= 100;
                    }
                    if (Vector3.Distance(transform.position, game.transform.position) < Radius / 2f)
                    {
                        npcHealth.NPCHealthPoint -= 500;
                    }
                }
            }
            */
            if (rigidbody)
            {
                rigidbody.AddExplosionForce(Force, transform.position, Radius, 1f);

                // эта хуета не толкает нижние риджидбади
                NPCHealth health = rigidbody.GetComponent<NPCHealth>();
                NPCAI ai = rigidbody.GetComponent<NPCAI>();
                NPCDead dead = rigidbody.GetComponent<NPCDead>();

                if (health)
                {
                    if (Vector3.Distance(transform.position, rigidbody.position) < Radius)
                    {
                        ai.npcMeshAgent.enabled = false;
                        dead.NPCBodyRB[0].isKinematic = false;
                        dead.NPCBodyRB[1].isKinematic = false;
                        dead.NPCBodyRB[2].isKinematic = false;
                        dead.NPCBodyRB[3].isKinematic = false;
                        dead.NPCBodyRB[4].isKinematic = false;
                        dead.NPCBodyRB[5].isKinematic = false;
                        dead.NPCBodyRB[6].isKinematic = false;
                        dead.NPCBodyRB[7].isKinematic = false;
                        dead.NPCBodyRB[8].isKinematic = false;
                        health.NPCHealthPoint -= 100;
                    }
                    if (Vector3.Distance(transform.position, rigidbody.position) < Radius / 2f)
                    {
                        ai.npcMeshAgent.enabled = false;
                        dead.NPCBodyRB[0].isKinematic = false;
                        dead.NPCBodyRB[1].isKinematic = false;
                        dead.NPCBodyRB[2].isKinematic = false;
                        dead.NPCBodyRB[3].isKinematic = false;
                        dead.NPCBodyRB[4].isKinematic = false;
                        dead.NPCBodyRB[5].isKinematic = false;
                        dead.NPCBodyRB[6].isKinematic = false;
                        dead.NPCBodyRB[7].isKinematic = false;
                        dead.NPCBodyRB[8].isKinematic = false;
                        health.NPCHealthPoint -= 500;
                    }

                    
                }
                

                // Определяет есть ли в риджитбади скрипт взрыва
                Explosion explosion = rigidbody.GetComponent<Explosion>();
                if (explosion)
                {
                    if (Vector3.Distance(transform.position, rigidbody.position) < Radius / 2f)
                    {
                        explosion.ExplodeWithDelay();
                    }
                }
            }
        }
        Destroy(gameObject);
        Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, Radius);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Radius / 2f);
    }
}
