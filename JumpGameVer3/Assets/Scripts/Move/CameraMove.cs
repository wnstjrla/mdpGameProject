using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject Target;

    public float cameraX1 = 0.0f; //ī�޶��� 1��Ī X��ǥ
    public float cameraY1 = 0.0f; //ī�޶��� 1��Ī Y��ǥ
    public float cameraZ1 = 0.0f; //ī�޶��� 1��Ī Z��ǥ

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
