using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindBranch : MonoBehaviour
{
    public Text text1;
    public Text text2;

    public int remainBranch = 8;

    // Update is called once per frame
    void Update() {
        text1.text = "Branch : " + remainBranch;
        if (remainBranch == 0)
        {
            off();
            remainBranch--;
        }
        if (remainBranch > 0) clear(remainBranch);
    }

    private void off() {
        GameObject.Find("Remain").SetActive(false);
        GameObject.Find("System").SetActive(false);
        GameObject.Find("Quest").SetActive(false);
        GameObject.Find("Point").transform.Find("End").gameObject.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Branch") {
            remainBranch--;
            collision.gameObject.SetActive(false);
        }
    }

    public void clear(int count) {
        if (count == 0)
        {
            text2.text = "You cleared Find, Congratulations!!";
        }
        else {
            text2.text = "Good Luck.";
        }
    }
}
