using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {

    int abc;

    // Use this for initialization
    void Start () {
       
	}

    void ViecABC()
    {
        abc = 1;
        abc = abc + 2;
    }


	// Update is called once per frame
	void Update () {
		
	}
    
    public void ChangeScene(){
        SceneManager.LoadScene("Level1");
    }
}
