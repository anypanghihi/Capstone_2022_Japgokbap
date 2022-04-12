using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Skeletons : Monster
{
    void Update() 
    {
        NavMesh.SamplePosition(GameManager.instance.GetPlayerPosition(), out NavMeshHit hit, 1f, 1);

        this.MyNavMesh.SetDestination(hit.position);
    }
}