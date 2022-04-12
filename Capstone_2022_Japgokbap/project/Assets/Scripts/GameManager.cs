using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region "Pulbic"

    public GameObject player;
    //싱글톤
    public static GameManager instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = FindObjectOfType<GameManager>();
            }

            return m_instance;
        }
    }
    #endregion

    #region "Private"
    private static GameManager m_instance;

    #endregion

    #region "Public Methods"

    public Vector3 GetPlayerPosition()
    {
        return player.transform.position;
    }

    #endregion
}