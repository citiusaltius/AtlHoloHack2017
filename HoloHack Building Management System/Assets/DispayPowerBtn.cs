using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DispayPowerBtn : MonoBehaviour, IInputClickHandler {

    public GameObject display;

    public void OnInputClicked(InputClickedEventData eventData)
    {

        if (!display.activeSelf)
        {
            display.SetActive(true);
        } else
        {
            display.SetActive(false);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
