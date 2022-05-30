using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using KeyType = System.String;

[DisallowMultipleComponent]
public class MonsterPool : MonoBehaviour
{
    public KeyType key;

    /// <summary> ���ӿ�����Ʈ ���� </summary>
    public MonsterPool Clone()
    {
        GameObject go = Instantiate(gameObject);
        if (!go.TryGetComponent(out MonsterPool po))
            po = go.AddComponent<MonsterPool>();
        go.SetActive(false);

        return po;
    }

    /// <summary> ���ӿ�����Ʈ Ȱ��ȭ </summary>
    public void Activate()
    {
        gameObject.SetActive(true);
    }

    /// <summary> ���ӿ�����Ʈ ��Ȱ��ȭ </summary>
    public void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
