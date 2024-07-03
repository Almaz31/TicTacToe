using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public static GameUI instance;
    [SerializeField]private Sprite Player1Sprite;
    [SerializeField]private Sprite Player2Sprite;

    [SerializeField] private TextMeshProUGUI Player1Count;
    [SerializeField] private TextMeshProUGUI Player2Count;
    [SerializeField] private TextMeshProUGUI PlayerShow;

    [SerializeField]private Image PlayerImage;

    private bool IsPlayer1;
    private bool IsWin;
    private void Start()
    {
        IsPlayer1 = true;
        instance = this;
        IsWin = false;
    }

    public void ChangePlayer()
    {
        if (IsWin)
        {
            if (IsPlayer1)
            {
                PlayerImage.sprite = Player2Sprite;
                PlayerShow.text = "Player 2";
                IsPlayer1 = false;
            }
            else
            {
                PlayerImage.sprite = Player1Sprite;
                PlayerShow.text = "Player 1";
                IsPlayer1 = true;
            }
        }
        else
        {
            IsWin = false;
        }
    }
    public void ResetGame()
    {
        IsPlayer1 = true;
        PlayerImage.sprite = Player1Sprite;
        PlayerShow.text = "Player 1";
    }
    public void ShowCounts(int p1,int p2)
    {
        Player1Count.text = p1.ToString();
        Player2Count.text = p2.ToString();
    }
    public void Win()
    {
        IsWin = true;
    }
}
