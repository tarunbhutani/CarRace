using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject halfCompleteTrig;
    public GameObject minuteDisplay;
    public GameObject secondDisplay;
    public GameObject milliSecondDisply;

    public GameObject lapTimeBox;

    private void OnTriggerEnter(Collider collider) {
        if (LapTimeManager.secondCount <= 9) {
            secondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.secondCount + ".";
        } else {
            secondDisplay.GetComponent<Text>().text = + LapTimeManager.secondCount + ".";
        }

        if (LapTimeManager.minCount <= 9) {
            minuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.minCount + ":";
        } else {
            minuteDisplay.GetComponent<Text>().text = + LapTimeManager.minCount + ":";
        }

        milliSecondDisply.GetComponent<Text>().text = "" + LapTimeManager.milliCount;

        LapTimeManager.minCount = 0;
        LapTimeManager.secondCount = 0;
        LapTimeManager.milliCount = 0;

        halfCompleteTrig.SetActive(true);
        gameObject.SetActive(false);
    }
}
