using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public Button m_Button;
    public string soundString;
    FMOD.Studio.EventInstance soundEvent;


    void Start()
    {
        m_Button.onClick.AddListener(PlayOnClick);     
    }

    void PlayOnClick()
    {
        Debug.Log("Now playing: " + soundString);
        soundEvent = FMODUnity.RuntimeManager.CreateInstance(soundString);
        soundEvent.start();
        //FMODUnity.RuntimeManager.PlayOneShot(soundString);
    }

}


