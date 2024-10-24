using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinButton : MonoBehaviour
{
    public GameObject can;
    public GameObject otherCan;
    // Start is called before the first frame update
    void Start()
    {
        can.SetActive(false);
    }

    // Update is called once per frame
    public void OpenCanvas() {
        can.SetActive(true);
        otherCan.SetActive(false);
    }
    public void CloseCanvas() {
        can.SetActive(false);
    }
}
