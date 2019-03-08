using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public DefaultTrackableEventHandler tracker;
    public Text text;


    public void toggleModel()
    {
        if (tracker.wolf.activeSelf)
        {
            tracker.wolf.SetActive(false);
            tracker.phoenix.SetActive(true);
            text.text = "Phoenix Activated";
        }

        else
        {
            tracker.phoenix.SetActive(false);
            tracker.wolf.SetActive(true);
            text.text = "Wolf Activated";
        }
    }
}
