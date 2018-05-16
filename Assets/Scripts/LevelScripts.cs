using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelScripts : MonoBehaviour {
    public Button submitButton;
    public Text levelText;
    public GameObject accessDeniedText;
    public InputField passwordInput;
    public string password;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Time.timeSinceLevelLoad % 2 < 1)
        {
            levelText.text = "LEVELS";

        }
        else
        {
            levelText.text = "1";
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            CheckPassword();
        }
        
    }

    public void CheckPassword(){
        if (passwordInput.text==password)
        {
            SceneManager.LoadScene("Level2");
        }
        else
        {
            accessDeniedText.SetActive(true);
        }
    }


    public void ScaleUp()
    {
        Vector3 scaleNow = submitButton.transform.localScale;
        scaleNow.x *= 1.5f;
        scaleNow.y *= 1.5f;
        //Debug.Log("ptr enter");
        submitButton.transform.localScale = scaleNow;
    }

    public void ScaleDown()
    {
        Vector3 scaleNow = submitButton.transform.localScale;
        scaleNow.x /= 1.5f;
        scaleNow.y /= 1.5f;
        //Debug.Log("ptr enter");
        submitButton.transform.localScale = scaleNow;
    }


}
