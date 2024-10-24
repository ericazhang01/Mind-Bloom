using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasClickThrough : MonoBehaviour
{
    public GameObject popupPanel; // Reference to the popup panel
    public Transform roverTransform; // Reference to the rover's transform
    public float proximityDistance = 1f; // Distance within which the popup will stay open

    private bool isPopupOpen = false;

    void Start()
    {
        ClosePopup();
    }

    void WhenClicked()//OnMouseDown()
    {
        if (isPopupOpen)
        {
            ClosePopup();
        }
        else
        {
            OpenPopup();
        }
    }

    void OpenPopup()
    {
        popupPanel.SetActive(true);
        isPopupOpen = true;
        // You can add additional logic here based on the specific rock prefab
    }

    void ClosePopup()
    {
        popupPanel.SetActive(false);
        isPopupOpen = false;
    }
}
