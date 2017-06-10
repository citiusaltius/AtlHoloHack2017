using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DispayPowerBtn : MonoBehaviour, IInputClickHandler {

    public GameObject display;
    public MeshRenderer mainDsiplay;

    public void OnInputClicked(InputClickedEventData eventData)
    {

        if(BuildingManager.Instance.thisCurrentAppMode == BuildingManager.ApplicationMode.EditMode)
        {
            return;
        }

        if (!display.activeSelf)
        {
            display.SetActive(true);
            mainDsiplay.enabled = false;
        } else
        {
            display.SetActive(false);
            mainDsiplay.enabled = true;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
