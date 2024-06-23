using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private Buttons buttonsCode;
    public int Player { get; private set; }
    private void Awake()
    {
        Instance = this;
        Player = 1;
    }
    public void ChangePlayer()
    {
        if(Player == 1) { Player = 2; }else { Player = 1; }
        
    }
    public void RestartGame()
    {
        buttonsCode.RestartLevel();
        WinUI.Instance.HideLines();
        Player = 1;
    }

}
