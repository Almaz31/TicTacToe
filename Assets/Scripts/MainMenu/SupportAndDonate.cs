using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SupportAndDonate : MonoBehaviour
{
    [SerializeField] private Button RateBut;
    [SerializeField] private Button DonateBut;
    [SerializeField] private Button CloseBut;
    // Start is called before the first frame update
    void Start()
    {
        RateBut.onClick.AddListener(() => { RateMe(); });
        RateBut.onClick.AddListener(() => { Donate(); });
        CloseBut.onClick.AddListener(() => { Hide(); });
        Hide();
    }

    private void Hide()
    {
        this.gameObject.SetActive(false);
    }

    private void Donate()
    {
        throw new NotImplementedException();
    }

    private void RateMe()
    {
        throw new NotImplementedException();
    }


}
