using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Plant : MonoBehaviour
{
    public GameObject[] plantList;
    private int selected;
    private Vector2 pos;
    private float wid = 20f;
    private float height = 20f;
    private TextMeshProUGUI coinText;
    private int money;
    
    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("money");
        coinText = GameObject.FindGameObjectWithTag("Coin").GetComponent<TextMeshProUGUI>();
    }

    public void InsertPlant() {
        for (int i = 0; i < 4; i++) {
            if (i == selected) {
                pos = new Vector2(
                    Random.Range(-wid / 2, wid / 2),
                    Random.Range(-height / 2, height / 2)
                );
                Instantiate(plantList[i], pos, Quaternion.identity);
                money -= 10;
                coinText.text = "" + money;
                PlayerPrefs.SetInt("money", money);
            }
        }
    } 
    public void PlantSelected(int x) {
        selected = x;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
