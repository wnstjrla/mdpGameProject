using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Portal") //��Ż�� ������ �������������� �̵�
        {
            SceneManager.LoadScene("FirstStage");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
