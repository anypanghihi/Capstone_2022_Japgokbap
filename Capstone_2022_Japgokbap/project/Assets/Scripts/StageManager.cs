using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

    [Header ("Settings")]
    public int waitingTime;
    public int spawnerCount;
    public bool roundEnded;

    [Header ("1-1")]
    public GameObject monsters1;
    public int count1;
    public int count2;

    [Header ("1-2")]
    public GameObject monsters2;
    public int count3;
    public int count4;
    public int count5;

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

    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    void Update()
    {
        
    }

    #region "Public Methods"

    #endregion

    #region "Private Methods"
    
    private IEnumerator SpawnMonsters()
    {
        while (!roundEnded)
        {
            if (count1 > 0)
            {
                Monster monster = Instantiate(skeletons[0], enemySpawner[spawnerCount++ % 3].transform.position, Quaternion.identity);
                monster.transform.parent = monsters1.transform;

                yield return new WaitForSeconds(waitingTime);

                count1--;
            }
            else if (count2 > 0)
            {
                Monster monster = Instantiate(skeletons[1], enemySpawner[spawnerCount++ % 3].transform.position, Quaternion.identity);
                monster.transform.parent = monsters2.transform;

                yield return new WaitForSeconds(waitingTime);

                count2--;
            }
            else
            {
                yield return null;
            }
        }
    }

    #endregion

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
