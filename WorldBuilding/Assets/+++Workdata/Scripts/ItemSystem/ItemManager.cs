using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance { get; private set; }
    [SerializeField] private SO_CollectableItem[] items;

    private List<SO_CollectableItem> collectableItem = new List<SO_CollectableItem>();
    private List<CollectableItem> itemInRange = new List<CollectableItem>();

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        /*for(int i = 0; i < items.Length; i++)
        {
            Debug.Log(items[i].nameItem + " kostet " + items[i].valueGold+ " Gold ");
        }

        int j = 0;
        while(j < items.Length)
        {
            Debug.Log(items[j].nameItem + " kostet " + items[j].valueGold+ " Gold ");
            j++;
        }
        
        //alle Items mit einem for-loop checken
        foreach(SO_CollectableItem item in items)
        {
            Debug.Log(item.nameItem + " kostet " + item.valueGold+ " Gold ");
        }
        */
    }

    public void AddItemCollectable(CollectableItem collectableItem)
    {
        itemInRange.Add(collectableItem);
    } 
    public void RemoveItemCollectable(CollectableItem collectableItem)
    {
        itemInRange.Remove(collectableItem);
    } 
}
