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
    public int initialObjectCount = INITIAL_COUNT; // ������Ʈ �ʱ� ���� ����
    public int maxObjectCount = MAX_COUNT;     // ť ���� ������ �� �ִ� ������Ʈ �ִ� ����
}
