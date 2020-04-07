using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsController : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameWinUI;
    public MouseLook mouseLookScript;
    public PlayerMovement playerMovementScript;
    public Text pointsText;
    public Text targetsText;
    private int score = 100;
    private float time = 0;
    private int targetsShoot = 0;

    private bool isPlay = true;
    private void Update()
    {
        if(isPlay)
        {
            if(score < 0)
            {
                gameOverUI.SetActive(true);
                EndGame();
            }
            else if(Target.amount <= targetsShoot)
            {
                gameWinUI.SetActive(true);
                gameWinUI.GetComponent<EndGameController>().SetText(score.ToString());
                EndGame();
            }

            if(time > 1)
            {
                AddScore(-1);
                time = 0;
            }

            time+= Time.deltaTime;
        }
    }

    private void EndGame()
    {
        Cursor.lockState = CursorLockMode.None;
        mouseLookScript.enabled = false;
        playerMovementScript.enabled = false;
        isPlay = false;
    }

    public void AddScore(int value)
    {
        score += value;
        SetScoreText(score.ToString());
    }

    public void AddTargetShoot()
    {
        targetsShoot++;
        SetTargetsText(targetsShoot.ToString());
    }

    private void SetScoreText(string text)
    {
        pointsText.text = text;
    }

    private void SetTargetsText(string text)
    {
        targetsText.text = text;
    }
}
