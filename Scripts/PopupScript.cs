using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupScript : MonoBehaviour
{
    public GameObject menuPopUp;
    public GameObject menuPopUp1;
    public GameObject ownMenu;
    private bool help;
    private bool second;

    // Start is called before the first frame update
    void Start()
    {
        help = false;
        second = false;
        menuPopUp.SetActive(false);
        menuPopUp1.SetActive(false);
    }

    // Update is called once per frame
    public void ShowPopUp() {
        if(!help){
            menuPopUp.SetActive(true);
            menuPopUp1.SetActive(false);
            help = true;
            ownMenu.SetActive(false);

        }
        else {
            menuPopUp.SetActive(false);
            menuPopUp1.SetActive(false);
            help = false;
            ownMenu.SetActive(true);
        }
    }
    public void ShowPopUp1() {
        if(!second){
            menuPopUp.SetActive(true);
            menuPopUp1.SetActive(true);
            second = true;
            ownMenu.SetActive(false);

        }
        else {
            menuPopUp.SetActive(false);
            menuPopUp1.SetActive(false);
            second = false;
            ownMenu.SetActive(true);
        }
    }
    
    
}
