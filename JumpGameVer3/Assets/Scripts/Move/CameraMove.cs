using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject Target;

    public float cameraX1 = 0.0f; //카메라의 1인칭 X좌표
    public float cameraY1 = 0.0f; //카메라의 1인칭 Y좌표
    public float cameraZ1 = 0.0f; //카메라의 1인칭 Z좌표

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Target.transform.position + new Vector3(cameraX1, cameraY1, cameraZ1);
    }
}
