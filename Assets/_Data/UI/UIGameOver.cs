using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    public Transform textGameOver;
    public Transform btnReplay;
    void Start()
    {
        this.textGameOver = transform.Find("textGameOver");
        this.btnReplay = transform.Find("btnReplay");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.ShowUIGameOver();
    }
    protected virtual void ShowUIGameOver()
    {
        if(GameManager.instance.gameOver)
        {
            this.textGameOver.gameObject.SetActive(true);
            this.btnReplay.gameObject.SetActive(true);
            Time.timeScale = 0f;
            return;
        }
        this.textGameOver.gameObject.SetActive(false);
        this.btnReplay.gameObject.SetActive(false);
    }
    public virtual void GameOver()
    {
        GameManager.instance.Replay();
    }
}
