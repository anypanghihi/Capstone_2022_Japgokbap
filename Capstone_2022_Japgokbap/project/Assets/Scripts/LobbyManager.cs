using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour
{
    #region Private

    private static LobbyManager m_instance;

    [Header ("Panels")]
    [SerializeField] private GameObject loginPanel;
    [SerializeField] private GameObject lobbyPanel;

    #endregion

    #region Public

    public static LobbyManager instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = FindObjectOfType<LobbyManager>();
            }

            return m_instance;
        }
    }

    #endregion

    #region Public Methods

    public void ActivePanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void DeativePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void Gamestart()
    {
        LoadingSceneManager.LoadScene("SpawnTestScene");
    }

    #endregion
}