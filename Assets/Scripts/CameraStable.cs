using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour
{
    public GameObject carGameObject;
    public float carX;
    public float carY;
    public float carZ;

    // Update is called once per frame
    void Update()
    {
        carX = carGameObject.transform.eulerAngles.x;
        carY = carGameObject.transform.eulerAngles.y;
        carZ = carGameObject.transform.eulerAngles.z;



        transform.eulerAngles = new Vector3(carX - carX, carY, carZ - carZ);
    }
}
