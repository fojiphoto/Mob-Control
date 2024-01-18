using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class FillLoading : MonoBehaviour
{
    // Start is called before the first frame update
    public Image fillLoading;
    void Start()
    {
        StartCoroutine("SceneLoadingFromSplash");
    }
    IEnumerator SceneLoadingFromSplash()
    {
        fillLoading.DOFillAmount(1, 12f).SetEase(Ease.Linear);
        yield return new WaitForSeconds(12f);
        SceneManager.LoadScene("Menu");
        //yield return new WaitUntil();
    }
}
