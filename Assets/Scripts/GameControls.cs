using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControls: MonoBehaviour
{
    //timer text object
    private Text timerText;
    //timer counter for adding score
    private int timerCount;

    // Start is called before the first frame update
    void Start()
    {
        //game is @ a running state
        Time.timeScale = 1f;
    }


}
