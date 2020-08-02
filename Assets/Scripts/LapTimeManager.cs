using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapTimeManager : MonoBehaviour
{
    public static int minCount;
    public static int secondCount;
    public static float milliCount;
    public static string milliDisplay;

    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject milliSecondBox;

    void Update() {
        milliCount += Time.deltaTime * 10;
        milliDisplay = milliCount.ToString("F0");

        var milliSecondText = milliSecondBox.GetComponent<Text>();
        var secondText = secondBox.GetComponent<Text>();
        var minText = minuteBox.GetComponent<Text>();

        milliSecondText.text = "" + milliDisplay;

        if (milliCount >= 10) {
            milliCount = 0;
            secondCount += 1;
        }

        if (secondCount <= 9) {
            secondText.text = "0" + secondCount + ".";
        } else {
            
            secondText.text = secondCount + ".";
        }

        if (secondCount >= 60) {
            secondCount = 0;
            minCount += 1;
        }

        if (minCount <= 9){
            minText.text = "0" + minCount + ":";
        } else {
            minText.text = minCount + ":";
        }
    }
}
