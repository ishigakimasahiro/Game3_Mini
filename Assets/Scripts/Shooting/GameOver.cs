using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public static bool isGameOver;

    [SerializeField] GameObject playerObj;

    private void Start()
    {
        isGameOver = false;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Gameover"))
        {
            Debug.Log("GameOver");
            isGameOver = true;

            playerObj.SetActive(false);
        }
    }
}
