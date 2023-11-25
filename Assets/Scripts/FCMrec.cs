using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FCMrec : MonoBehaviour
{
    private void OnEnable()
    {
        AdsManager.instance?.ShowMRec();
    }

    private void OnDisable()
    {
        AdsManager.instance?.HideMRec();
    }
}
