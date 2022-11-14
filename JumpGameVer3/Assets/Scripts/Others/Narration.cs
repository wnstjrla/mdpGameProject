using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Narration : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Text1.SetActive(true);
            Text2.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
