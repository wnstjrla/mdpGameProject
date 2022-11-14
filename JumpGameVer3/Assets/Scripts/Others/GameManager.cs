using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text text; // Canvas�� text�� �ٲٱ����� ����

    public GameObject menuSet; // �޴�â ������Ʈ
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // ----Sub Menu----
        if (Input.GetButtonDown("Cancel"))
        { //esc�� ������ ��
            if (menuSet.activeSelf) {
                Time.timeScale = 1f;
                menuSet.SetActive(false); //���������� ����
            }
            else {
                Time.timeScale = 0f;
                menuSet.SetActive(true); //���������� �Ҵ�
            }
        }

        if (!menuSet.activeSelf) Time.timeScale = 1f;
    }

    // -----Go Home-----
    public void Home() {
        SceneManager.LoadScene("OtherMain");
    }

    // -----Game Exit-----
    public void GameExit() {
        Application.Quit();
    }

    // -----Go Tuto-----
    public void Tuto() {
        SceneManager.LoadScene("Tutor");
    }

    // -----Music Change-----
    int BgmCount = 0;
    public void MusicChange() {
        BgmCount++;
        if(BgmCount > 5) BgmCount = 0;
        switch (BgmCount) {
            case 0:
                GameObject.Find("FirstBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("SecondBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("ThirdBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("FourBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("LastBgm").GetComponent<AudioSource>().Stop();
                text.text = "BMG - None";
                break;

            case 1:
                GameObject.Find("FirstBgm").GetComponent<AudioSource>().Play();
                GameObject.Find("SecondBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("ThirdBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("FourBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("LastBgm").GetComponent<AudioSource>().Stop();
                text.text = "BGM - Adventue";
                break;

            case 2:
                GameObject.Find("FirstBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("SecondBgm").GetComponent<AudioSource>().Play();
                GameObject.Find("ThirdBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("FourBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("LastBgm").GetComponent<AudioSource>().Stop();
                text.text = "BGM - Carefree";
                break;

            case 3:
                GameObject.Find("FirstBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("SecondBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("ThirdBgm").GetComponent<AudioSource>().Play();
                GameObject.Find("FourBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("LastBgm").GetComponent<AudioSource>().Stop();
                text.text = "BGM - Lobby";
                break;

            case 4:
                GameObject.Find("FirstBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("SecondBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("ThirdBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("FourBgm").GetComponent<AudioSource>().Play();
                GameObject.Find("LastBgm").GetComponent<AudioSource>().Stop();
                text.text = "BGM - Loyalty_Freak_Music";
                break;

            case 5:
                GameObject.Find("FirstBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("SecondBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("ThirdBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("FourBgm").GetComponent<AudioSource>().Stop();
                GameObject.Find("LastBgm").GetComponent<AudioSource>().Play();
                text.text = "BGM - Monkeys-Spinning";
                break;
        }
    }
}
