using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOut : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        player.GetComponent<GameObject>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player") {
            player.transform.position = new Vector3(-12.5f, 0.6f, 12);
        }
    }
}
