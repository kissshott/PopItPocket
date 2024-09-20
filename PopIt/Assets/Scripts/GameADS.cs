using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class GameADS : MonoBehaviour, IUnityAdsListener
{
    private string gameId = "4286223"; // ������������� ����������
    public Button myButton; // ������, ������� ����� ���������� �����
    public string myPlacementId = "rewardedVideo"; // ������������� �����, �� ��������� 'rewardedVideo'

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
        // ������
    }

    void IUnityAdsListener.OnUnityAdsDidStart(string placementId)
    {
        // �������������� ��������, ������� ���������� �����������, ����� �������� ������������ ��������� ����������.
    }

    void IUnityAdsListener.OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            // ������� ��� ������������ �� ��, ��� ��������� �����.
        }
        else if (showResult == ShowResult.Skipped)
        {
            // �� �������������� ������������ �� ������� ����������.
        }
        else if (showResult == ShowResult.Failed)
        {
            // ���������� �� ���� ��������� ��-�� ������.
        }
    }
}