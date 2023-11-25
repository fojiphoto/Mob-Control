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
        Invoke(nameof(showBanner), 4.5f);
       
    }
    public void showBanner()
    {
        //nadeem
       AdsManager.instance?.ShowBanner();
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
    public void LoadGamePlay()
    {
        SceneManager.LoadScene(1);
        AudioManager.Instance.PlaySFX("click");
    }
}
