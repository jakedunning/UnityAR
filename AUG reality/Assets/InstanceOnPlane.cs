using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine;

public class InstanceOnPlane : MonoBehaviour
{
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    ARRaycastManager raycastManager;
    public GameObject prefab;
    
    void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && raycastManager.Raycast(Input.mousePosition, hits))
        {
            Instantiate(prefab, hits[0].pose.position, hits[0].pose.rotation);
        }
    }
}
