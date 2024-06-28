using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public static GameOverUI instance;
    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] private Button Restart;
    [SerializeField] private Button Home;
    // Start is called before the first frame update
    void Start()
    {
        Restart.onClick.AddListener(() => { RestartGame(); });
        Home.onClick.AddListener(() => {GoHome(); });
        instance = this;
        GameOverPanel.SetActive(false);
    }

    private void RestartGame()
    {
        GameManager.Instance.RestartGame();
        GameManager.Instance.RestartGame();
        GameOverPanel.SetActive(false);
    }
    private void GoHome()
    {
        SceneManager.LoadScene(0);
        GameOverPanel.SetActive(false);
    }
    public void ShowGameOverUI()
    {
        GameOverPanel.SetActive(true);
    }

}
