using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using Random = UnityEngine.Random;
using UnityEngine.UI;

public class EquationChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI firstNum; // first number in equation
    public TextMeshProUGUI secondNum; // second number in equation
    public TextMeshProUGUI sign; // equation symbol
    public TextMeshProUGUI ans; // the answer of the equation
    private int randomNumber; // first number random
    private int randomNumber1; // second number random
    private int ran; // random sign 
    public TMP_InputField inputField; // the user input
    public GameObject answerPopUp;
    public TextMeshProUGUI solution;
    private bool nextQuestion; 
    //private ObjectSaver objectsaver;
    private TextMeshProUGUI coinText;
    private int money;
    public GameObject back;
    

    void Start()
    {
        GenerateQuestion();
        money = PlayerPrefs.GetInt("money");
        DontDestroyOnLoad(back);
        //money = 0;
        //objectsaver = GameObject.FindGameObjectsWithTag("Coin").GetComponent<ObjectSaver>();
        //Calculate();
        coinText = GameObject.FindGameObjectWithTag("Coin").GetComponent<TextMeshProUGUI>();
    } 
    public void GenerateQuestion() {
        inputField.text = "";
        nextQuestion = false;
        randomNumber = (int)(Random.Range(1.0f, 10.0f));
        randomNumber1 = (int)(Random.Range(1.0f, 10.0f));
        //int randomNumber2 = random.Next(1, 10);
        firstNum.text = "" + randomNumber;
        secondNum.text = "" + randomNumber1;
        ChangeSign(4.0f); 
        answerPopUp.SetActive(false);
    }

    private void ChangeSign(float f) {
        ran = (int) (Random.Range(1.0f, f));
        if(ran == 1) {
            sign.text = "+";
        } else if (ran == 2) {
            sign.text = "-";
        } else if (ran == 3) {
            sign.text = "×";
        } else if (ran == 4) {
            sign.text = "÷";
        }
    }

    public void Calculate(){//InputField input) {

        //string trys = input.GetComponent<InputField>().text;
        //int hi = int.Parse(input.text);
        if(ran == 1) {
            ans.text = "" + (randomNumber + randomNumber1);
        } else if (ran == 2) {
            ans.text = "" + (randomNumber - randomNumber1);
        } else if (ran == 3) {
            ans.text = "" + (randomNumber * randomNumber1);
        } else if (ran == 4) {
            ans.text = "" + (randomNumber / randomNumber1);
        }
        answerPopUp.SetActive(true);
        if(!nextQuestion) {
            if(ans.text == inputField.text) {
                solution.text = "Correct!";
                nextQuestion = true;
                //coinText.text += 1;
                //objectsaver.AddMoney(1);
                money += 2;
                coinText.text = "" + money;
                PlayerPrefs.SetInt("money", money);
            } else {
                solution.text = "Wrong! The correct answer is: " + ans.text;
                nextQuestion = true;
            }
        } else {
            GenerateQuestion();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //string inputText = inputField.text;
            //Debug.Log("Input text: " + inputText);
    }
}
