using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHealth : MonoBehaviour
{
    public float NPCHealthPoint = 90;
    public NPCDead deadScript;
    // Триггер коллайдера бота при прикасновении к нему объекта с тэгом "Hands"
    // Берет функцию из скрипта "NPCDead" и воспроизводит её
    
    private void OnTriggerEnter(Collider other)
    {
        deadScript.EmenyDead(other.gameObject);
    }
}
