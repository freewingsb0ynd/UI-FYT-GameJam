using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class BarBehaviourScript : EventTrigger
{
    private Image thisImg;
    // Use this for initialization
    void Start()
    {
        thisImg = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PtrEnter()
    {
        Color colorNow = thisImg.color;
        colorNow.a = 0;
        thisImg.color = colorNow;
    }

    public void PtrExit()
    {
        Color colorNow = thisImg.color;
        colorNow.a = 1;
        thisImg.color = colorNow;
    }

    public override void OnPointerEnter(PointerEventData eventData)
    {
        PtrEnter();
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        PtrExit();
    }
}
