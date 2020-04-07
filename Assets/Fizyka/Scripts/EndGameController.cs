using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameController : MonoBehaviour
{
    public Text score;

    public void SetText(string text)
    {
        score.text= text;
    }

    public void ExitButtonClicked()
    {
        SceneManager.LoadScene("Menu");
    }
}
