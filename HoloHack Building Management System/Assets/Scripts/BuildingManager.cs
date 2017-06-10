using HoloToolkit.Unity;
using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using HoloToolkit.Unity.SpatialMapping;

public class BuildingManager : Singleton<BuildingManager>, ISpeechHandler
{

    public GameObject spatialMapping;
    public GameObject IOTCollection;
    public GameObject WorldAnchorManagerObject;

    public GameObject Introduction;
    public GameObject OnceFinishedText;
   
    public enum ApplicationMode { idleMode, EditMode, Experience }

    public ApplicationMode thisCurrentAppMode;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnSpeechKeywordRecognized(SpeechKeywordRecognizedEventData eventData)
    {
        var voiceCommand = eventData.RecognizedText.ToLower();
        Introduction.SetActive(false);
        switch (voiceCommand)
            {
                case "edit space":
                {
                    if(thisCurrentAppMode == ApplicationMode.EditMode) { return; }
                    if (thisCurrentAppMode == ApplicationMode.Experience) { return; }
                    thisCurrentAppMode = ApplicationMode.EditMode;
                    SpatialMappingManager.Instance.DrawVisualMeshes = false;
                    WorldAnchorManagerObject.SetActive(true);
                    IOTCollection.SetActive(true);
                    Introduction.SetActive(false);
                    OnceFinishedText.SetActive(true);
                    

                }
                break;
            case "experience":
                {
                    
                    thisCurrentAppMode = ApplicationMode.Experience;
                    SpatialMappingManager.Instance.DrawVisualMeshes = false;
                    WorldAnchorManagerObject.SetActive(true);
                    IOTCollection.SetActive(true);
                    Introduction.SetActive(false);
                    

                }
                break;
        }
    }
}
