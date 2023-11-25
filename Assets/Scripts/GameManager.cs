using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject LevelComplete,LevelFail,SettinPanel;
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
        AdsManager.instance.ShowInterstitialWithoutConditions();
        //nadeem
        AudioManager.Instance.PlaySFX("click");
    }
    public void Next()
    {
        if (scene>=10)
        {
            int randomScene = Random.Range(0, 10);
            SceneManager.LoadScene(randomScene);
        }
        else
        {
            SceneManager.LoadScene(scene + 1);
        }
        
        AudioManager.Instance.PlaySFX("click");
        AdsManager.instance.ShowInterstitialWithoutConditions();
       //nadeem
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
        AudioManager.Instance.PlaySFX("click");
         AdsManager.instance.ShowInterstitialWithoutConditions();
        //nadeem

    }
}
