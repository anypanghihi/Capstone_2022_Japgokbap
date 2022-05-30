using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using KeyType = System.String;

[Serializable]
public class MonsterPoolData
{
    public const int INITIAL_COUNT = 10;
    public const int MAX_COUNT = 50;

    public KeyType key;
    public GameObject prefab;
    public int initialObjectCount = INITIAL_COUNT; // 오브젝트 초기 생성 개수
    public int maxObjectCount = MAX_COUNT;     // 큐 내에 보관할 수 있는 오브젝트 최대 개수
}
