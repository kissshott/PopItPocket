using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Sprite In, Out;
    private Image image;
    public AudioSource popIn, popOut;

    private void Start()
    {
        image = GetComponent<Image>();
        if (image == null)
        {
            image.sprite = Out;

        }
    }



    public void PopIt()
    {
        if (image.sprite == Out)
        {
            image.sprite = In;
            if(PlayerPrefs.GetString("music") != "No")
                {
                   popIn.Play();
                }
            if (PlayerPrefs.GetString("vibration") != "No")
            {
                Handheld.Vibrate();
            }

        }
        else
        {
            image.sprite = Out;
            if(PlayerPrefs.GetString("music") != "No")
                {
                popOut.Play();
            }
        }
    }

}
