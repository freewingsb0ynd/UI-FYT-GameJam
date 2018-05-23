using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelScripts : MonoBehaviour {
    
    public Text levelText;
    public GameObject accessDeniedText;
    public InputField passwordInput;
    public string password;
    public string levelNumberText;
    public string levelNext;
    public Button nextHintButton;
    public List<GameObject> hints;

    private int hintIndex = 0;


    // Use this for initialization
    void Start() {
        hints[hintIndex].SetActive(true);
        if (hints.Count > 1) nextHintButton.gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update() {
        if (Time.timeSinceLevelLoad % 2 < 1)
        {
            levelText.text = "LEVELS";

        }
        else
        {
            levelText.text = levelNumberText;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            CheckPassword();
        }
        

    }

    public void CheckPassword(){
        if (passwordInput.text==password)
        {
            SceneManager.LoadScene(levelNext);
        }
        else
        {
            accessDeniedText.SetActive(true);
        }
    }


    public void NextHint()
    {
        hintIndex = (hintIndex + 1) % hints.Count;

        for(int i=0; i< hints.Count; i++)
        {
            hints[i].SetActive(i == hintIndex);
        }

        if (hintIndex == hints.Count - 1 || hintIndex == 0)
        {
            Vector3 scaleNow = nextHintButton.transform.localScale;
            scaleNow.x *= -1f;
            nextHintButton.transform.localScale = scaleNow;
        }

    }


}
