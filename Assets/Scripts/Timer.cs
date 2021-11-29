using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Land land;
    public int secondsleft;
    public float timerPeriod = 30f;
    public bool takingAway = false;

    private float timerCountDown;


    void Start()
    {

        //secondsleft = Mathf.FloorToInt(timerPeriod - Time.time);
        //textDisplay.GetComponent<Text>().text = "00:" + secondsleft.ToString();

    }
    private void Update()
    {
        

        if (Time.time < timerCountDown)
        {
            secondsleft = Mathf.FloorToInt(timerCountDown - Time.time);

        }
        else
        {
            secondsleft = 0;
            land.canInteract = true;

        }
    }

    public void TimerUp()
    {
        
        timerCountDown = Time.time + timerPeriod;
        Debug.Log("Timer End at: " + timerCountDown.ToString());
        secondsleft = Mathf.FloorToInt(timerPeriod - Time.time);
        
    }

}
