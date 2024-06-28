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

    [SerializeField] private Button PlayTicTakToe;
    [SerializeField] private Button Play5InRow;
    [SerializeField] private Button PlayStar;

    private void Start()
    {
        PlayTicTakToe.onClick.AddListener(() => { StartTicTakToe(); });
        Play5InRow.onClick.AddListener(() => { Start5InRow(); });
        PlayStar.onClick.AddListener(() => { StartStar(); });
    }

    private void StartStar()
    {
        Debug.Log("Donate for inspire");
    }

    private void Start5InRow()
    {
        Debug.Log("Donate for inspire");
    }

    private void StartTicTakToe()
    {
        SceneManager.LoadScene(1);
    }
}
