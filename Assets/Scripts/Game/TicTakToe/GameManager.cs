using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private Buttons buttonsCode;
    public int Player { get; private set; }

    private int Player1Count;
    private int Player2Count;
    private void Awake()
    {
        Instance = this;
        Player = 1;
    }
    private void Start()
    {
        Player1Count = 0;
        Player2Count = 0;
        GameUI.instance.ShowCounts(Player1Count, Player2Count);
    }
    public void ChangePlayer()
    {
        if(Player == 1) { Player = 2; }else { Player = 1; }
        GameUI.instance.ChangePlayer();
        
    }
    public void RestartGame()
    {
        buttonsCode.RestartLevel();
        WinUI.Instance.HideLines();
        Player = 1;
        GameUI.instance.ResetGame();
    }
    public void QiutGame()
    {
        Player1Count = 0;
        Player2Count = 0;
    }
    public void PlayerWin(int Player)
    {
        if (Player == 1) { Player1Count++; }
        else { Player2Count++; }
        GameUI.instance.ShowCounts(Player1Count, Player2Count);
    }

}
