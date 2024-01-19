using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update\
    public GameObject SettingPanel, MainMenu;
    private void Awake()
    {
        
    }
    void Start()
    {
        MainMenu.SetActive(true);
        SettingPanel.SetActive(false);
        Invoke(nameof(showBanner), 0.1f);
       
    }
    public void showBanner()
    {
        //nadeem
        //abdulRehman
        //AdsManager.instance?.ShowBanner();
        CASAds.instance.ShowBanner(CAS.AdPosition.BottomCenter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSetting()
    {
        
        SettingPanel.SetActive(true);
        MainMenu.SetActive(false);
        AudioManager.Instance.PlaySFX("click");
    }
    public void CloseSetting()
    {
        SettingPanel.SetActive(false);
        MainMenu.SetActive(true);
        AudioManager.Instance.PlaySFX("click");
    }
    public void PrivacyPolicy()
    {
         string privacyurl = "https://orbitgamesglobal-privacy-policy.blogspot.com/";
         Application.OpenURL(privacyurl);
    }
    public void MoreGames()
    {
        string moreGamesurl = "https://play.google.com/store/apps/developer?id=Orbit+Games+Global";
        Application.OpenURL(moreGamesurl);
    }
    public void RateUs()
    {
        string Rateurl = "https://play.google.com/store/apps/details?id="+Application.identifier;
        Application.OpenURL(Rateurl);
    }
    public void RevokeConcent()
    {
        CASAds.instance?.HideBanner();
        CASAds.instance?.HideMrecBanner();
        PlayerPrefs.SetInt("GDPR", 0);
        Application.LoadLevel("GDPR");
    }
    public void LoadGamePlay()
    {
        
        SceneManager.LoadScene(2);
        AudioManager.Instance.PlaySFX("click");
    }
   
}
