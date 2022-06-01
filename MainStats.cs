using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class MainStats : MonoBehaviour
{
    public static int grivny;
    public static int grivnyperclick = 1;
    public static int upgradecost = 50;
    private void Start()
    {
        GameManager.score.text = "Гривні: 0";
        GameManager.upgradecosttext.text = "Ціна: " + upgradecost.ToString();
    }

    public void Click()
    {
        grivny = grivny + grivnyperclick;
        GameManager.score.text = "Гривні: " + grivny.ToString();
    }

    public void Upgrade()
    {
        grivnyperclick++;
        grivny = grivny - upgradecost;
        GameManager.score.text = "Гривні: " + grivny.ToString();
        upgradecost = Convert.ToInt32(upgradecost * 2);
        GameManager.upgradecosttext.text = "Ціна: " + upgradecost.ToString();
        GameManager.grivnyPerClickText.text = "Гривнів за клік: " + grivnyperclick.ToString();
    }

    private void Update()
    {
        if (grivny < upgradecost)
        {
            GameManager.UpgradeButton.interactable = false;
        }
        else
            GameManager.UpgradeButton.interactable = true;
    }
}
