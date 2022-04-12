using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;

[Serializable]
public class StageData
{
    // 2-1 이면 2가 stage 1이 level
    public int stage;
    public int level;
    // 해당 스테이지에 나오는 몬스터 리스트
    public int[] monsterCount;
}

public class StageManager : MonoBehaviour
{
    #region "Pulbic"

    //싱글톤
    public static StageManager instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = FindObjectOfType<StageManager>();
            }

            return m_instance;
        }
    }
    public int testCount1;
    public int testCount2;
    public bool testBoolean;
    public float timer;
    public int waitingTime;
    public int testI;

    #endregion

    #region "Private"

    private static StageManager m_instance;

    [Header ("Spawners")]
    [SerializeField] private GameObject[] enemySpawner;

    [Header ("Monsters")]
    [SerializeField] private Monster[] skeletons;
    [SerializeField] private Monster[] goblins;
    [SerializeField] private Monster[] orcs;

    #endregion

    #region "Public Methods"

    public void SpawnMonsters()
    {

    }

    #endregion

    void Start()
    {
        Invoke("SpawnMonsters", 3f);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (testCount1 == 0)
        {
            testBoolean = true;
        }

        if (!testBoolean && timer > waitingTime && testCount1 > 0)
        {
            Instantiate(skeletons[0], enemySpawner[testI++ % 3].transform.position, Quaternion.identity);

            testCount1--;
            timer = 0f;
        }

        if (testBoolean && timer > waitingTime && testCount2 > 0)
        {
            Instantiate(skeletons[1], enemySpawner[testI++ % 3].transform.position, Quaternion.identity);

            testCount2--;
            timer = 0f;
        }
    }

    /*
    void Start() 
    {
        StageData stageData = new StageData();
        stageData.stage = 1;
        stageData.level = 1;
        stageData.monsterCount = new int[2] { 40, 10 };

        string json = JsonUtility.ToJson(stageData);
        Debug.Log("ToJson : " + json);

        string fileName = "1-1";
        string path = Application.dataPath + "/" + fileName + ".Json";

        FileStream fileStream = new FileStream(path, FileMode.Create);
        byte[] data = Encoding.UTF8.GetBytes(json);
        fileStream.Write(data, 0, data.Length);
        fileStream.Close();
    }*/
}
