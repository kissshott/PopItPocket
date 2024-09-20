using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class Ads : MonoBehaviour
{
    private string gameId = "4286223", type = "Interstitial_Android";
    private bool testMode = false;

    private void Start()
    {
        Advertisement.Initialize(gameId, true);
        //StartCoroutine(ShowAd());
    }
    public void ShowAd()
    {
        if (Advertisement.IsReady(type))
           {
             Advertisement.Show(type);
           }
    }
    //  IEnumerator ShowAd()
    //  {
    //   while (true)
    //   {
    //       if (Advertisement.IsReady(type))
    //       {
    //           Advertisement.Show(type);
    //       }
    //        yield return new WaitForSeconds(1f);
    //     }
    //  }
}
