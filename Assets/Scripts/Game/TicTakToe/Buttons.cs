using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject UpperLeft;
    [SerializeField] private GameObject UpperCenter;
    [SerializeField] private GameObject UpperRight;
    [SerializeField] private GameObject CenterLeft;
    [SerializeField] private GameObject CenterCenter;
    [SerializeField] private GameObject CenterRight;
    [SerializeField] private GameObject BottonLeft;
    [SerializeField] private GameObject BottonCenter;
    [SerializeField] private GameObject BottonRight;
    private int[,] field;
    [SerializeField] private Sprite Chrest;
    [SerializeField] private Sprite Zero;
    [SerializeField] private Sprite Empty;
    private GameObject[,] cells;
    private bool IsWin;
    void Start()
    {
        RestartLevel();
    }
    public void RestartLevel()
    {
        field = new int[3, 3];
        cells = new GameObject[3, 3];
        IsWin = false;
        SetField();
        SetCells();
        UpdateField();
        InitiateCellClick();
    }
    private void UpdateCell(int x, int y)
    {
        if (!IsWin)
        {
            Debug.Log(GameManager.Instance.Player);
            if (GameManager.Instance.Player == 1 && field[x, y] == 0)
            {
                field[x, y] = 1;
            }
            else if (GameManager.Instance.Player == 2 && field[x, y] == 0)
            { field[x, y] = 2; }
            GameManager.Instance.ChangePlayer();
            UpdateField();
        }    
    }

    private void UpdateField()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if ((field[i, j] == 0))
                {
                    cells[i,j].GetComponent<Image>().sprite = Empty;
                }
                else if ((field[i, j] == 1))
                {
                    cells[i, j].GetComponent<Image>().sprite = Chrest;
                }else if ((field[i, j] == 2))
                {
                    cells[i, j].GetComponent<Image>().sprite = Zero;
                }
            }
        }
        ShowWinner();
        
    }

    private void ShowWinner()
    {
        var result = CheckWin();
        if (result.Item1 != -1)
        {
            IsWin = true;
            WinUI.Instance.ShowWinLine(result.Item1, result.Item2, result.Item3);
        }
    }

    private (int, int, int) CheckWin()
    {
        for (int i = 0; i < 3; i++)
        {
            if (field[i, 0] != 0 && field[i, 0] == field[i, 1] && field[i, 1] == field[i, 2])
            {
                return (field[i, 0], 0, i);
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (field[0, i] != 0 && field[0, i] == field[1, i] && field[1, i] == field[2, i])
            {
                return (field[0, i], 1, i);
            }
        }
        if (field[0, 0] != 0 && field[0, 0] == field[1, 1] && field[1, 1] == field[2, 2])
        {
            return (field[0, 0], 2, 2);
        }
        if (field[0, 2] != 0 && field[0, 2] == field[1, 1] && field[1, 1] == field[2, 0])
        {
            return (field[0, 2], 3, 3);
        }

        return (-1, -1, -1);
    }
    private void SetField()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                field[i, j] = 0;
            }
        }
    }
    private void InitiateCellClick()
    {
        UpperLeft.GetComponent<Button>().onClick.AddListener(() => {
            UpdateCell(0, 0);
        });
        UpperCenter.GetComponent<Button>().onClick.AddListener(() => {
            UpdateCell(0, 1);
        });
        UpperRight.GetComponent<Button>().onClick.AddListener(() => {
            UpdateCell(0, 2);
        });
        CenterLeft.GetComponent<Button>().onClick.AddListener(() => {
            UpdateCell(1, 0);
        });
        CenterCenter.GetComponent<Button>().onClick.AddListener(() => {
            UpdateCell(1, 1);
        });
        CenterRight.GetComponent<Button>().onClick.AddListener(() => {
            UpdateCell(1, 2);
        });
        BottonLeft.GetComponent<Button>().onClick.AddListener(() => {
            UpdateCell(2, 0);
        });
        BottonCenter.GetComponent<Button>().onClick.AddListener(() => {
            UpdateCell(2, 1);
        });
        BottonRight.GetComponent<Button>().onClick.AddListener(() => {
            UpdateCell(2, 2);
        });
    }
    private void SetCells()
    {
        cells[0, 0] = UpperLeft;
        cells[0, 1] = UpperCenter;
        cells[0, 2] = UpperRight;
        cells[1, 0] = CenterLeft;
        cells[1, 1] = CenterCenter;
        cells[1, 2] = CenterRight;
        cells[2, 0] = BottonLeft;
        cells[2, 1] = BottonCenter;
        cells[2, 2] = BottonRight;
    }

}
