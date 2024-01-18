using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject LevelComplete, LevelFail, SettinPanel, DefeatCanvas;
    int scene;
    private void Awake()
    {
        if (Instance==null)
        {
            Instance = this;
           
        }
        
    }
    void Start()
    {
        scene= SceneManager.GetActiveScene().buildIndex;
       AudioManager.Instance.PlayMusic("BG");
        //GameObject Water = Resources.Load("Water").GameObject;
        Instantiate(Resources.Load("Water"));
        GameObject destroyGameobject= GameObject.Find("Plane (1)");
        Destroy(destroyGameobject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelCompleted()
    {
        LevelComplete.SetActive(true);
        AudioManager.Instance.PlaySFX("win");
        AudioManager.Instance.musicsource.Stop();
    }

    public void LevelFailed()
    {
        LevelFail.SetActive(true);
        AudioManager.Instance.PlaySFX("lose");
        AudioManager.Instance.musicsource.Stop();
        DefeatCanvas.SetActive(false);

    }
    public void SettingPanelOpen()
    {
        SettinPanel.SetActive(true);
        
        AudioManager.Instance.PlaySFX("click");
        Time.timeScale = 0;
    }
    public void SettingPanelClose()
    {
        SettinPanel.SetActive(false);
        AudioManager.Instance.PlaySFX("click");
        Time.timeScale = 1;
        AudioController.instance.SaveSM();
    }

    public void Retry()
    {
        SceneManager.LoadScene(scene);
        //abdulRehman
        //AdsManager.instance.ShowInterstitialWithoutConditions();
        CASAds.instance.ShowInterstitial();
        //nadeem
        AudioManager.Instance.PlaySFX("click");
    }
    public void Next()
    {
        if (scene>=11)
        {
            int randomScene = Random.Range(2, 12);
            SceneManager.LoadScene(randomScene);
        }
        else
        {
            SceneManager.LoadScene(scene + 1);
        }
        
        AudioManager.Instance.PlaySFX("click");
        //abdulRehman
        //AdsManager.instance.ShowInterstitialWithoutConditions();
        CASAds.instance.ShowInterstitial();
       //nadeem
    }
    public void RevokeConcent()
    {
        CASAds.instance?.HideBanner();
        CASAds.instance?.HideMrecBanner();
        PlayerPrefs.SetInt("GDPR", 0);
        Application.LoadLevel("GDPR");
    }
    public void Home()
    {
        SceneManager.LoadScene(2);
        AudioManager.Instance.PlaySFX("click");
        //abdulRehman
        //AdsManager.instance.ShowInterstitialWithoutConditions();
        CASAds.instance.ShowInterstitial();
        //nadeem

    }
}
