using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    
    public int selectedColor = 0;
    public GameObject character;
    public GameObject ears;
    private SpriteRenderer spriteRenderer;
    private SpriteRenderer spriteRenderer2;
    private int[] index = {0,1,2,3};
    
    void Start() { 

        //colors[0] = new Color(0.706f, 0.4705f, 0.353f, 1.0f);
        spriteRenderer = character.GetComponent<SpriteRenderer>();
        spriteRenderer2 = ears.GetComponent<SpriteRenderer>();
        Switch(0);
        selectedColor = 0; 
        //spriteRenderer.color = colors[0];//new Color(0.706f, 0.4705f, 0.353f, 1.0f);
        //for (int i = 1; i < colors.Length; i++) {
                //characters[i].SetActive(false);// goes through and sets all the characters unactive except the first one. 
       //}
    }



    private void Switch(int x) {
        switch(x) {
            case(0) :
                spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                spriteRenderer2.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            break;
            case(1) :
                spriteRenderer.color = new Color(0.98f, 0.4185f, 0.2267f, 1.0f);
                spriteRenderer2.color = new Color(0.98f, 0.4185f, 0.2267f, 1.0f);
            break;
            case(2) :
                spriteRenderer.color = new Color(0.528f, 0.5283f, 0.5283f, 1.0f);
                spriteRenderer2.color = new Color(0.528f, 0.5283f, 0.5283f, 1.0f);
            break;
            case(3) :
                spriteRenderer.color = new Color(0.66f, 0.414f, 0.23f, 1.0f);
                spriteRenderer2.color = new Color(0.66f, 0.414f, 0.23f, 1.0f);
            break;
            default:
                Debug.Log("ok");
                //spriteRenderer.color = new Color.White;
            break;
        }
    }

    public void NextSkin() {
        selectedColor = (selectedColor + 1) % index.Length;
        Switch(selectedColor);
    }
    public void PreviousSkin() {
        selectedColor--; 
        if (selectedColor < 0)
        {
            selectedColor += index.Length;
        }
        Switch(selectedColor);
    }

    public void StartGame() // put on start button
    {
        PlayerPrefs.SetInt("selectedColor", selectedColor); // sets the selected character to an int that won't change in between scenes. 
       // SceneManager.LoadScene(4, LoadSceneMode.Single);  <-------- // commented out line that is supposed to move you to the next scene, however I find that it is easier just to use the ChangeScene Class at the same time. 
       
    }

   
}







/*

 void Start() {
        for (int i = 1; i < characters.Length; i++) {
                characters[i].SetActive(false);// goes through and sets all the characters unactive except the first one. 
        }
    }

    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);// sets the character that was previously loaded to false.
        selectedCharacter = (selectedCharacter + 1) % characters.Length;// moves on in the array to the next option, unless you're at the end 
        characters[selectedCharacter].SetActive(true);// Sets new character to true.
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false); // Same thing as the NextCharacter() method, except backwards. 
        selectedCharacter--; 
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);

    }


    public void StartGame() // put on start button
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter); // sets the selected character to an int that won't change in between scenes. 
       // SceneManager.LoadScene(4, LoadSceneMode.Single);  <-------- // commented out line that is supposed to move you to the next scene, however I find that it is easier just to use the ChangeScene Class at the same time. 
       
    }



*/
