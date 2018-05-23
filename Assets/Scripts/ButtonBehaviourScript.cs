using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ButtonBehaviourScript : EventTrigger {
    private Button thisButton;
	// Use this for initialization
	void Start () {
        thisButton = GetComponent<Button>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ScaleUp()
    {
        Vector3 scaleNow = thisButton.transform.localScale;
        scaleNow.x *= 1.5f;
        scaleNow.y *= 1.5f;
        //Debug.Log("ptr enter");
        thisButton.transform.localScale = scaleNow;
    }

    public void ScaleDown()
    {
        Vector3 scaleNow = thisButton.transform.localScale;
        scaleNow.x /= 1.5f;
        scaleNow.y /= 1.5f;
        //Debug.Log("ptr enter");
        thisButton.transform.localScale = scaleNow;
    }

    public override void OnPointerEnter(PointerEventData eventData)
    {
        ScaleUp();
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        ScaleDown();
    }
}
