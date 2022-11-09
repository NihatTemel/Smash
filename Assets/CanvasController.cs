using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class CanvasController : MonoBehaviour
{
    [SerializeField] TMP_Text BallText;
    [SerializeField] GameObject PlayerBall;
    [SerializeField] GameObject Boy;
    [SerializeField] GameObject Panel;

    [SerializeField] int TotalBall = 25;

    void Start()
    {
        PlayerPrefs.SetInt("ball", TotalBall);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        BallText.text = "" + PlayerPrefs.GetInt("ball");
    }


    public void ResGame() 
    {
        SceneManager.LoadScene(0);
    }

    public void PlayGame() 
    {
        Debug.Log("play game");
        Boy.GetComponent<BoyController>().enabled = true;
        PlayerBall.GetComponent<PlayerController>().enabled = true;
        Panel.SetActive(false);
    }


}
