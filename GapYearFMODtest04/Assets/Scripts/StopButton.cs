// To use this example, attach this script to an empty GameObject.
// Create three buttons (Create>UI>Button). Next, select your
// empty GameObject in the Hierarchy and click and drag each of your
// Buttons from the Hierarchy to the Your First Button, Your Second Button
// and Your Third Button fields in the Inspector.
// Click each Button in Play Mode to output their message to the console.
// Note that click means press down and then release.

using UnityEngine;
using UnityEngine.UI;

public class StopButton : MonoBehaviour
{
    public Button m_Stop;

    void Start()
    {
        m_Stop.onClick.AddListener(StopOnClick);     
    }

    void StopOnClick()
    {
        Debug.Log("Stopping!");

         // FMODUnity.RuntimeManager.PlayOneShot(soundEvent);
    }

}
