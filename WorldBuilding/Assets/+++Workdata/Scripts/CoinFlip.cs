using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinFlip : MonoBehaviour
{
    [SerializeField] private Button buttonStartFlip;
    [SerializeField] private Button buttonFinishedFlip;
    [SerializeField] private GameObject head;
    [SerializeField] private GameObject number;
    [SerializeField] private GameObject panelStartFlipPanel;
    [SerializeField] private GameObject panelFinishedFlipPanel;
    // Start is called before the first frame update
    void Start()
    {
        buttonStartFlip.onClick.AddListener(StartPanel);
        buttonFinishedFlip.onClick.AddListener(FinishedPanel);
        
        panelFinishedFlipPanel.SetActive(false);
        panelStartFlipPanel.SetActive(true);
        number.SetActive(false);
        head.SetActive(false);
        
    }

    void StartPanel()
    {
        panelStartFlipPanel.SetActive(true);
        panelFinishedFlipPanel.SetActive(false);
    }
    void FinishedPanel()
    {
        panelStartFlipPanel.SetActive(false);
        panelFinishedFlipPanel.SetActive(true);
    }
}
