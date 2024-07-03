using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject PlayUI;
    [SerializeField] private GameObject ChooseGameUI;
    [SerializeField] private GameObject DonateUI;

    [SerializeField] private Button PlayTicTakToe;
    [SerializeField] private Button Play5InRow;
    [SerializeField] private Button PlayStar;

    [SerializeField] private Button PlayButton;
    [SerializeField] private Button BackButton;
    [SerializeField] private Button SupportButton;
    [SerializeField] private Button QuitButton;

    private void Start()
    {
        PlayTicTakToe.onClick.AddListener(() => { StartTicTakToe(); });
        Play5InRow.onClick.AddListener(() => { Start5InRow(); });
        PlayStar.onClick.AddListener(() => { StartStar(); });

        PlayButton.onClick.AddListener(() => { ShowChooseGameUI(); });
        BackButton.onClick.AddListener(() => { BackToMenuUI(); });
        SupportButton.onClick.AddListener(() => { ShowDonateUI(); });
        QuitButton.onClick.AddListener(() => { QuitGame(); });

        BackToMenuUI();
    }

    private void QuitGame()
    {
       Application.Quit();
    }

    private void BackToMenuUI()
    {
        PlayUI.SetActive(true);
        ChooseGameUI.SetActive(false);
    }

    private void ShowChooseGameUI()
    {
        PlayUI.SetActive(false);
        ChooseGameUI.SetActive(true);
    }
    private void ShowDonateUI()
    {
        DonateUI.SetActive(true);
    }

    private void StartStar()
    {
        ShowDonateUI();
    }

    private void Start5InRow()
    {
        ShowDonateUI();
    }

    private void StartTicTakToe()
    {
        SceneManager.LoadScene(1);
    }
}
