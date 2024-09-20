using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class CanvasButtons : MonoBehaviour
{
    public Sprite On, Off;
    
    private void Start()
    {
        PlayerPrefs.SetString("vibration", "No");
        if (PlayerPrefs.GetString("music") == "No" && gameObject.name == "Music")
            GetComponent<Image>().sprite = Off;
        if (PlayerPrefs.GetString("vibration") == "Yes" && gameObject.name == "Vibration")
            GetComponent<Image>().sprite = On;
    }

    


public void MusicWork()
    {
        if(PlayerPrefs.GetString("music") == "No")
        {
            PlayerPrefs.SetString("music", "Yes");
            GetComponent<Image>().sprite = On;
            GetComponent<AudioSource>().Play();
        }
        else
        {
            PlayerPrefs.SetString("music", "No");
            GetComponent<Image>().sprite = Off;
        }
    }

    public void VibrationWork()
    {
        if (PlayerPrefs.GetString("vibration") == "Yes")
        {
            PlayerPrefs.SetString("vibration", "No");
            GetComponent<Image>().sprite = Off;
            
        }
        else
        {
            PlayerPrefs.SetString("vibration", "Yes");
            GetComponent<Image>().sprite = On;
            Handheld.Vibrate();
        }
    }
    public void Back()
    {
        if (PlayerPrefs.GetString("music") != "No")
            GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Main");
    }
    public void Pop1()
    {
        if (PlayerPrefs.GetString("music") != "No")
            GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Pop1");
    }
    public void Pop2()
    {
        if (PlayerPrefs.GetString("music") != "No")
            GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Pop2");
    }
    public void Pop3()
    {
        if (PlayerPrefs.GetString("music") != "No")
            GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Pop3");
    }
    public void Pop4()
    {
        if (PlayerPrefs.GetString("music") != "No")
            GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Pop4");
    }
    public void Pop5()
    {
        if (PlayerPrefs.GetString("music") != "No")
            GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Pop5");
    }
    public void Pop6()
    {
        if (PlayerPrefs.GetString("music") != "No")
            GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Pop6");
    }
}
