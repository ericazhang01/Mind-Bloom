using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOptionToggle : MonoBehaviour
{
    // Start is called before the first frame update
    public void MathChosen(int x) {
        if(x == 0) {
            Debug.Log("addition chosen");
        }
        if(x == 1) {
            Debug.Log("subtraction chosen");
        }
        if(x == 2) {
            Debug.Log("multiplication chosen");
        }
        if(x == 3) {
            Debug.Log("division chosen");
        }
    }
}
