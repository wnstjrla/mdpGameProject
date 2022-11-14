using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    bool bgmTrig = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            if (bgmTrig == false)
            {
                GameObject.Find("FirstBgm").GetComponent<AudioSource>().Play();
                bgmTrig = true;
            }
            else {
                GameObject.Find("FirstBgm").GetComponent<AudioSource>().Stop();
                bgmTrig = false;
            }
        }
    }
}
