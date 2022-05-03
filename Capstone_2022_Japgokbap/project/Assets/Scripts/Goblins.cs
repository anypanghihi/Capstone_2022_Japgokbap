using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Goblins : Monster
{
    void Update() 
    {
        if(enemyHp > 0)
        {
            NavMesh.SamplePosition(GameManager.instance.GetPlayerPosition(), out NavMeshHit hit, 1f, 1);

            this.MyNavMesh.SetDestination(hit.position);
        }
        else
        {
            SpawnExpObjet();
            Destroy(this.gameObject);
        }
    }

    protected override void GetDamaged()
    {
        throw new System.NotImplementedException();
    }

    protected override void SpawnExpObjet()
    {
        throw new System.NotImplementedException();
    }
}