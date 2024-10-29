using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    [SerializeField] private GameObject toolTipContainer;
    [SerializeField] private Transform transformCamera;
    [SerializeField] private ScriptableObject itemData;
    private bool isInteractionRange = false;


    
    // Start is called before the first frame update
    void Start()
    {
        //Beim start ist der PickUpText Versteckt
        toolTipContainer.SetActive(false);
        if (Camera.main != null) transformCamera = Camera.main.transform;
    }

    private void Update()
    {
        if (isInteractionRange)
        {
            toolTipContainer.transform.LookAt(transformCamera);
        }
    }

    //Wenn der Player den radius vom Sphere betrit schaltet sich der PickUp Text an
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PlayerEntered");
            toolTipContainer.SetActive(true);
            isInteractionRange = true;
            
            ItemManager.Instance.AddItemCollectable(this);
        }
    }
    //Wenn der Player den radius vom Sphere verlässt schaltet sich der PickUp Text aus 
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PlayerLeft");
            toolTipContainer.SetActive(false);
            isInteractionRange = false;
            
            ItemManager.Instance.RemoveItemCollectable(this);
        }
    }
}
