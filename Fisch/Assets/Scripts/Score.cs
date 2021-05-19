using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreDisplay;
    public bool shouldReset = false;
    private static int scoreValue = 0;
    public int transitionScore;
    public string nextScene;

    private void Start()
    {
        if (shouldReset == true)
        {
            scoreValue = 0;
        }
        scoreDisplay.text = scoreValue.ToString();
    }


    public void AddScore(int toAdd)
    {
        scoreValue = scoreValue + toAdd;

        scoreDisplay.text = scoreValue.ToString();

        //check if socre is bigger than the score needed to transition between scenes
        if (scoreValue >= transitionScore)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
