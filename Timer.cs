using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public string sceneName;
    public TextMeshProUGUI timerText;
    void Update()
    {
       if (seconds > 0)
        {
            seconds -= Time.deltaTime;
        }
        else
        {
            if (minutes >= 1)
            {
                seconds = 59;
                minutes -= 1;
            }
            else
            {
                EditorSceneManager.LoadScene(sceneName);
			}
        }
       int roundSeconds = Mathf.RoundToInt(seconds);
        timerText.text = minutes + ":" + roundSeconds;
    }
}
