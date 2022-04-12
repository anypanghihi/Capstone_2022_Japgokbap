using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    public NavMeshAgent MyNavMesh { get; private set; }

    void Start()
    {
        MyNavMesh = GetComponent<NavMeshAgent>();
    }
}
