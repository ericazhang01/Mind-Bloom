using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairColorChanger : MonoBehaviour
{
    public int selectedColor1 = 0;
    public GameObject character1;
    private SpriteRenderer spriteRenderer;
    private int[] index = {0,1,2,3,4,5};
    
    void Start() { 

        //colors[0] = new Color(0.706f, 0.4705f, 0.353f, 1.0f);
        spriteRenderer = character1.GetComponent<SpriteRenderer>();
        Switch(0);
        selectedColor1 = 0; 
        //spriteRenderer.color = colors[0];//new Color(0.706f, 0.4705f, 0.353f, 1.0f);
        //for (int i = 1; i < colors.Length; i++) {
                //characters[i].SetActive(false);// goes through and sets all the characters unactive except the first one. 
       //}
    }



    private void Switch(int x) {
        switch(x) {
            case(0) :
                spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            break;
            case(1) :
                spriteRenderer.color = new Color(0.9f, 0.8f, 0.4f, 1.0f);
            break;
            case(2) :
                spriteRenderer.color = new Color(0.9f, 0.47f, 0.1f, 1.0f);
            break;
            case(3) :
                spriteRenderer.color = new Color(0.6f, 0.4f, 0.2f, 1.0f);
            break;
            case(4) :
                spriteRenderer.color = new Color(0.3f, 0.2f, 0.05f, 1.0f);
            break;
            case(5) :
                spriteRenderer.color = new Color(0.1f, 0.09f, 0.07f, 1.0f);
            break;
            default:
                Debug.Log("ok");
                //spriteRenderer.color = new Color.White;
            break;
        }
    }

    public void NextSkin() {
        selectedColor1 = (selectedColor1 + 1) % index.Length;
        Switch(selectedColor1);
    }
    public void PreviousSkin() {
        selectedColor1--; 
        if (selectedColor1 < 0)
        {
            selectedColor1 += index.Length;
        }
        Switch(selectedColor1);
    }

    public void StartGame() // put on start button
    {
        PlayerPrefs.SetInt("selectedColor1", selectedColor1); // sets the selected character to an int that won't change in between scenes. 
       // SceneManager.LoadScene(4, LoadSceneMode.Single);  <-------- // commented out line that is supposed to move you to the next scene, however I find that it is easier just to use the ChangeScene Class at the same time. 
       
    }
}
