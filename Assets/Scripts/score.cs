using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public Text scoreText;
    public static double previous_gamescore;
    public static double current_gamescore;
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level01")
        {
            previous_gamescore = 0;
            current_gamescore = Time.timeSinceLevelLoad * 10;
            scoreText.text = (previous_gamescore + current_gamescore).ToString("0");
        }
        else if (SceneManager.GetActiveScene().name == "Level02")
        {
            if (Time.timeSinceLevelLoad == 0)
            {
                previous_gamescore = current_gamescore;
            }
            current_gamescore = Time.timeSinceLevelLoad * 12;
            scoreText.text = (previous_gamescore + current_gamescore).ToString("0");
        }
        else if (SceneManager.GetActiveScene().name == "Level03")
        {
            if (Time.timeSinceLevelLoad == 0)
            {
                previous_gamescore = previous_gamescore + current_gamescore;
            }
            current_gamescore = Time.timeSinceLevelLoad * 15;
            scoreText.text = (previous_gamescore + current_gamescore).ToString("0");
        }
        else if (SceneManager.GetActiveScene().name == "Level04")
        {
            if (Time.timeSinceLevelLoad == 0)
            {
                previous_gamescore = previous_gamescore + current_gamescore;
            }
            current_gamescore = Time.timeSinceLevelLoad * 17;
            scoreText.text = (previous_gamescore + current_gamescore).ToString("0");
        }
        else if (SceneManager.GetActiveScene().name == "Level05")
        {
            if (Time.timeSinceLevelLoad == 0)
            {
                previous_gamescore = previous_gamescore + current_gamescore;
            }
            current_gamescore = Time.timeSinceLevelLoad * 20;
            scoreText.text = (previous_gamescore + current_gamescore).ToString("0");
        }
        else if (SceneManager.GetActiveScene().name == "Credits")
        {

            if (Time.timeSinceLevelLoad == 0)
            {
                //previous_gamescore = previous_gamescore + current_gamescore;
                previous_gamescore = current_gamescore;
            }
            scoreText.text = (previous_gamescore).ToString("0");
        }
        else
        {

        }
        
    }
}
