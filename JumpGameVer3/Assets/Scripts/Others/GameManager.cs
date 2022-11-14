using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text text; // Canvas의 text를 바꾸기위해 선언

    public GameObject menuSet; // 메뉴창 컴포넌트
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // ----Sub Menu----
        if (Input.GetButtonDown("Cancel"))
        { //esc를 눌렀을 때
            if (menuSet.activeSelf) {
                Time.timeScale = 1f;
                menuSet.SetActive(false); //켜져있으면 끈다
            }
            else {
                Time.timeScale = 0f;
                menuSet.SetActive(true); //꺼져있으면 켠다
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
