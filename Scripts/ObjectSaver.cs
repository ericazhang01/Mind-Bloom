using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectSaver : MonoBehaviour
{
    //public GameObject mainMenu;
    public GameObject coin;
    public TextMeshProUGUI coinAmount;
    public GameObject thisObject;
    private int money;
    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("money");
        //money = 0;
        DontDestroyOnLoad(coin);
        DontDestroyOnLoad(thisObject);
        coinAmount.text = "" + money;
        //DontDestroyOnLoad(mainMenu);
    }

    public void AddMoney(int x) {
        money += x;
        coinAmount.text = "" + money;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
