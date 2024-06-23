using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinUI : MonoBehaviour
{
    public static WinUI Instance;
    [Header("Rows"), Space(5)]
    [SerializeField] private GameObject FirstRow;
    [SerializeField] private GameObject SecondRow;
    [SerializeField] private GameObject ThirdRow;
    [Header("Columns"),Space(5)]
    [SerializeField] private GameObject FirstColumn;
    [SerializeField] private GameObject SecondColumn;
    [SerializeField] private GameObject ThirdColumn;
    [Header("Diagonals"), Space(5)]
    [SerializeField] private GameObject FirstDiagonal;
    [SerializeField] private GameObject SecondDiagonal;
    [Header("PlayerText"), Space(5)]
    [SerializeField] private GameObject PlayerWinText;
    private void Awake()
    {
        Instance = this;
        HideLines();
    }
    public void ShowWinLine(int player,int type, int line)
    {
        if (type == 0)
        {
            if (line == 0)
            {
                FirstRow.SetActive(true);
            }
            else if (line == 1)
            {
                SecondRow.SetActive(true);
            }
            else if (line == 2)
            {
                ThirdRow.SetActive(true);
            }
        }
        else if (type == 1)
        {
            if (line == 0)
            {
                FirstColumn.SetActive(true);
            }
            else if (line == 1)
            {
                SecondColumn.SetActive(true);
            }
            else if (line == 2)
            {
                ThirdColumn.SetActive(true);
            }
        }
        else if (type == 2)
        {

            FirstDiagonal.SetActive(true);
        }
        else if (type == 3)
        {
            SecondDiagonal.SetActive(true);
        }   
        GameOverUI.instance.ShowGameOverUI();
        PlayerWinText.GetComponent<TextMeshProUGUI>().text = "Player " + player + " wins";
        PlayerWinText.SetActive(true);
    }
    public void HideLines()
    {
        FirstRow.SetActive(false);
        SecondRow.SetActive(false);
        ThirdRow.SetActive(false);
        FirstColumn.SetActive(false);
        SecondColumn.SetActive(false);
        ThirdColumn.SetActive(false);
        FirstDiagonal.SetActive(false);
        SecondDiagonal.SetActive(false);

        PlayerWinText.SetActive(false);
    }
}
