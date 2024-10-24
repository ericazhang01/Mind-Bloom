using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StudyButtonHelp : MonoBehaviour
{
    // Start is called before the first frame update
    private ChangeScene sceneChanger;
    void OnMouseDown(){
        Debug.Log("is clicked");
        SceneManager.LoadScene("study scene");
    }
}
