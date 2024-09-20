using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class GameADS : MonoBehaviour, IUnityAdsListener
{
    private string gameId = "4286223"; // идентификатор приложени€
    public Button myButton; // кнопка, котора€ будет показывать ролик
    public string myPlacementId = "rewardedVideo"; // идентификатор видео, по умолчанию 'rewardedVideo'

    void Start()
    {
        myButton.interactable = Advertisement.IsReady(myPlacementId);
        if (myButton) myButton.onClick.AddListener(ShowRewardedVideo);
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, true);
    }

    void ShowRewardedVideo()
    {
        Advertisement.Show(myPlacementId);
    }

    void IUnityAdsListener.OnUnityAdsReady(string placementId)
    {
        if (placementId == myPlacementId)
        {
            myButton.interactable = true;
        }
    }

    void IUnityAdsListener.OnUnityAdsDidError(string message)
    {
        // ошибка
    }

    void IUnityAdsListener.OnUnityAdsDidStart(string placementId)
    {
        // дополнительные действи€, которые необходимо предприн€ть, когда конечные пользователи запускают объ€вление.
    }

    void IUnityAdsListener.OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            // награда дл€ пользовател€ за то, что посмотрел ролик.
        }
        else if (showResult == ShowResult.Skipped)
        {
            // не вознаграждайте пользовател€ за пропуск объ€влени€.
        }
        else if (showResult == ShowResult.Failed)
        {
            // объ€вление не было завершено из-за ошибки.
        }
    }
}