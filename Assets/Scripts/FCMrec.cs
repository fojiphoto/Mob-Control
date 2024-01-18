using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FCMrec : MonoBehaviour
{
    private void OnEnable()
    {
        //abdulRehman
        //AdsManager.instance?.ShowMRec();
        CASAds.instance?.ShowMrecBanner(CAS.AdPosition.TopCenter);
    }

    private void OnDisable()
    {   //abdulRehman
        //AdsManager.instance?.HideMRec();
        CASAds.instance?.HideMrecBanner();
    }
}
