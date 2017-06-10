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

        switch (voiceCommand)
        {
            case "scan complete":
                {
                    SpatialMappingManager.Instance.DrawVisualMeshes = false;
                    IOTCollection.SetActive(true);
                    IOTCollection.transform.parent = spatialMapping.transform;

                }
                break;
        }
    }
}
