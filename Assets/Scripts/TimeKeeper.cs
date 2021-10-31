using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeKeeper : MonoBehaviour
{
    private float time;
    private Text txt;
    // Start is called before the first frame update
    void Start()
    {
        time = 60;
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        txt.text = FormatTime(time*1000);
        if (time <= 0) {
            endGame();
        }
    }

    private string FormatTime(float time)
    {
        int minutes = (int)time / 60000;
        int seconds = (int)time / 1000 - 60 * minutes;
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    
    private void endGame() 
    {
        Time.timeScale = 0;
        //pause the game
        
        //spawn the menu
    }
}
