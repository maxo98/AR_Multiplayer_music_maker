using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    [SerializeField] Transform myCam;

    private void Update()
    {
        transform.LookAt(myCam);
    }
}
