using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Page
{
    public GameObject[] pageObjects;
    public bool enabled;
    
    public Page(GameObject[] pageObjects)
    {
        this.pageObjects = pageObjects;
    }
}
public class GameManager : MonoBehaviour
{
    #region Serialized Values
    [SerializeField] private TextMeshProUGUI score__;
    [SerializeField] private TextMeshProUGUI upgradecosttext_;
    [SerializeField] private TextMeshProUGUI grivnyPerClickText_;
    [SerializeField] private GameObject[] mainMenuObjects_;
    [SerializeField] private GameObject[] pidorSelectObjects_;
    [SerializeField] private GameObject[] storeMenuObjects_;
    [SerializeField] private Button UpgradeButton_;
    #endregion

    #region Static Values
    public static TextMeshProUGUI score;
    public static TextMeshProUGUI upgradecosttext;
    public static TextMeshProUGUI grivnyPerClickText;
    public static List<Page> pages = new List<Page>();
    public static Page mainPage;
    public static Page pidorSelectPage;
    public static Page storePage;
    public static Button UpgradeButton;
    #endregion
    
    private void Awake()
    {
        score = score__;
        upgradecosttext = upgradecosttext_;
        grivnyPerClickText = grivnyPerClickText_;
        mainPage = new Page(mainMenuObjects_);
        pidorSelectPage = new Page(pidorSelectObjects_);
        storePage = new Page(storeMenuObjects_);
        UpgradeButton = UpgradeButton_;
        pages.Add(mainPage);
        pages.Add(pidorSelectPage);
        pages.Add(storePage);
        MainPage();
    }
    public static void MainPage()
    {
        foreach (Page a in pages)
        {
            ClosePage(a);
        }
        OpenPage(mainPage);
    }
    public static void StorePage()
    {
        foreach (Page a in pages)
        {
            ClosePage(a);
        }
        OpenPage(storePage);
    }

    public static void ClosePage(Page a)
    {
        for (int i = 0; i < a.pageObjects.Length; i++)
        {
            a.pageObjects[i].SetActive(false);
        }
    }
    public static void OpenPage(Page a)
    {
        for (int i = 0; i < a.pageObjects.Length; i++)
        {
            a.pageObjects[i].SetActive(true);
        }
    }
}
