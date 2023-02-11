using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravitate : MonoBehaviour
{
    [SerializeField]
    float gravitateSpeed;
    [SerializeField]
    GameObject gravitateCenter;
    [SerializeField]
    Vector3 offset = new Vector3(0,0,0);

    void Update()
    {
      transform.position += offset;
      transform.RotateAround(gravitateCenter.transform.position, new Vector3(0, 1, 0), gravitateSpeed * Time.deltaTime);
    }
}
