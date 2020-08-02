using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01Track : MonoBehaviour
{

    public GameObject mark01;
    public GameObject mark02;
    public GameObject mark03;
    public GameObject mark04;
    public GameObject mark05;
    public GameObject mark06;
    public GameObject mark07;
    public GameObject mark08;
    public GameObject mark09;
    public GameObject mark10;
    public GameObject mark11;
    public GameObject mark12;
    public GameObject mark13;
    public GameObject mark14;
    public GameObject mark15;
    public GameObject mark16;
    public int markTracker;
    void Update()
    {
        switch (markTracker) {
            case 0: gameObject.transform.position = mark01.transform.position;
            break;

            case 1: gameObject.transform.position = mark02.transform.position;
            break;

            case 2: gameObject.transform.position = mark03.transform.position;
            break;

            case 3: gameObject.transform.position = mark04.transform.position;
            break;

            case 4: gameObject.transform.position = mark05.transform.position;
            break;

            case 5: gameObject.transform.position = mark06.transform.position;
            break;

            case 6: gameObject.transform.position = mark07.transform.position;
            break;
            
            case 7: gameObject.transform.position = mark08.transform.position;
            break;

            case 8: gameObject.transform.position = mark09.transform.position;
            break;

            case 9: gameObject.transform.position = mark10.transform.position;
            break;

            case 10: gameObject.transform.position = mark11.transform.position;
            break;

            case 11: gameObject.transform.position = mark12.transform.position;
            break;

            case 12: gameObject.transform.position = mark13.transform.position;
            break;

            case 13: gameObject.transform.position = mark14.transform.position;
            break;

            case 14: gameObject.transform.position = mark15.transform.position;
            break;

            case 15: gameObject.transform.position = mark16.transform.position;
            break;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "Dreamcar01") {
            this.GetComponent<BoxCollider>().enabled = false;
            markTracker += 1;
            if (markTracker == 15) {
                markTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
