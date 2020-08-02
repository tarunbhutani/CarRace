using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject lapCompleteTrigger;

    private void OnTriggerEnter(Collider other) {
        lapCompleteTrigger.SetActive(true);
        gameObject.SetActive(false);
    }
}
