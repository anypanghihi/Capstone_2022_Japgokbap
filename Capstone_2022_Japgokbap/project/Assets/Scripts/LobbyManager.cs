using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour
{
    #region Private

    private GameObject loginpanel;
    private GameObject lobbypanel;

    #endregion

    #region Public

    [Header("Scenes")]
    public Scene samplescene;

    [Header("UI")]
    public Text sample;

    #endregion 

    void Start()
    {
        loginpanel = GameObject.Find("LoginPanel");
        lobbypanel = GameObject.Find("LobbyPanel");
    }

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
        SceneManager.LoadScene("GameScene");
    }
}