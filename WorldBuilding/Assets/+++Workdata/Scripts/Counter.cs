using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Counter : MonoBehaviour
{
    //Liste der möglichen Tiere 
    [SerializeField] private string[] animals ;
    //Anzahl der Tiere ihn der neuen Liste
    [SerializeField] private int animalCountInList;
    //Hier werden die Tire Random Generriert 
    [SerializeField] private string[] animalList; 

    void Start()
    {
        //array initialisieren - mit der finalen länge
        animalList = new string[animalCountInList];
        //setzte ein Element auf ein zufälliges der anderen Liste
        animalList[0] = animals[Random.Range(0,animals.Length)];
        
        //durch die neue Liste intterieren
        for (int i = 0; i<animalList.Length; i++)
        {
            //und jedem Eintrag ein zufälligen Wert hinzufügen
            animalList[i] = animals[Random.Range(0, animals.Length)];
        }

        //Zählen Starten
        // gehe durch alle möglichen tiere
        Debug.Log("Start counting" + animalList[0]);

        int animalsFound = 0;

        foreach (string animal in animalList)
        {
        if (animal == animalList[0])
        {
        animalsFound++;
        }
        }
        //Anzahl der Gehzahlten Tiere
        Debug.Log(" We found " + animalsFound + " " + animalList[0]);
    }
}
