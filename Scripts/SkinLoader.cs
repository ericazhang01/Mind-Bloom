using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinLoader : MonoBehaviour
{
    //public Sprite[] roverSprites;
    public GameObject chara;
    public GameObject hair;
    private SpriteRenderer spriteRenderer;
    private SpriteRenderer hairRenderer;
    private int selectedColor; 
    private int selectedColor1;
    // Start is called before the first frame update
    void Start()
    {

        selectedColor = PlayerPrefs.GetInt("selectedColor");
        selectedColor1 = PlayerPrefs.GetInt("selectedColor1");
        spriteRenderer = chara.GetComponent<SpriteRenderer>();
        hairRenderer = hair.GetComponent<SpriteRenderer>();
        Switch(selectedColor); 
        //Switch2(selectedColor1);
    }

    private void Switch(int x) {
        switch(x) {
            case(0) :
                spriteRenderer.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                hairRenderer.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            break;
            case(1) :
                spriteRenderer.color = new Color(0.98f, 0.4185f, 0.2267f, 1.0f);
                hairRenderer.color = new Color(0.98f, 0.4185f, 0.2267f, 1.0f);
            break;
            case(2) :
                spriteRenderer.color = new Color(0.528f, 0.5283f, 0.5283f, 1.0f);
                hairRenderer.color = new Color(0.528f, 0.5283f, 0.5283f, 1.0f);
            break;
            case(3) :
                spriteRenderer.color = new Color(0.66f, 0.414f, 0.23f, 1.0f);
                hairRenderer.color = new Color(0.66f, 0.414f, 0.23f, 1.0f);
            break;
            default:
                Debug.Log("ok");
                //spriteRenderer.color = new Color.White;
            break;
        }
    }
    /*private void Switch2(int x) { 
       switch(x) {
            case(0) :
                hairRenderer.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            break;
            case(1) :
                hairRenderer.color = new Color(0.9f, 0.8f, 0.4f, 1.0f);
            break;
            case(2) :
                hairRenderer.color = new Color(0.9f, 0.47f, 0.1f, 1.0f);
            break;
            case(3) :
                hairRenderer.color = new Color(0.6f, 0.4f, 0.2f, 1.0f);
            break;
            case(4) :
                hairRenderer.color = new Color(0.3f, 0.2f, 0.05f, 1.0f);
            break;
            case(5) :
                hairRenderer.color = new Color(0.1f, 0.09f, 0.07f, 1.0f);
            break;
            default:
                Debug.Log("ok");
                //spriteRenderer.color = new Color.White;
            break;
        }
    }*/
}
