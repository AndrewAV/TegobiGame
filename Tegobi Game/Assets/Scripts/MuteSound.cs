using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteSound : MonoBehaviour {


    bool pressed;
    Toggle muteButton;
    void Start() {

        muteButton=GetComponent<Toggle>();
        if (AudioListener.pause == false)
        {
            muteButton.isOn = true;

        }
        else
        {
            muteButton.isOn = false;
        }
    }
    public void Mute(bool a) {

        if (a == true)
        {
            AudioListener.pause = false;
        }
        else
        {
            AudioListener.pause = true;
        }

    }

}
