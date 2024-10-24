using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float left;
    public bool on = false;
    public TextMeshProUGUI study;
    public TextMeshProUGUI break1;
    public TMP_InputField StudyInput;
    public TMP_InputField BreakInput;
    private bool breakOn = false;
    public float left1;
    // Start is called before the first frame update
    void Start () {
        on = false; 
    }
        
    
    public void StartTimer() {
        if (on) {
            on = false;
        } else {
            on = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(on) {
            if(left > 0) {
                left -= Time.deltaTime;
                UpdateTimer(left);
            }
            else {
                left = 0;
                breakOn = true;
                on = false;
            }
        }
        if (breakOn) {
            if(left1 > 0) {
                left1 -= Time.deltaTime;
                UpdateTimer1(left1);
            }
            else {
                left1 = 0;
                breakOn = false;
            }
        }
    }

    void UpdateTimer(float current) {
        current += 1;
        float min = Mathf.FloorToInt(current / 60);
        float sec = Mathf.FloorToInt(current % 60);
        if (sec < 10)
        {
            study.text = min + ":0" + sec;
        }
        else
        {
            study.text = min + ":" + sec;
        }
    }
    void UpdateTimer1(float current) {
        current += 1;
        float min = Mathf.FloorToInt(current / 60);
        float sec = Mathf.FloorToInt(current % 60);
        if (sec < 10)
        {
            break1.text = min + ":0" + sec;
        }
        else
        {
            break1.text = min + ":" + sec;
        }
    }
}
