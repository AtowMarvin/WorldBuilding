using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CollectableItem", menuName = "ScriptableObject/new CollectableItem")]
public class SO_CollectableItem : ScriptableObject
{
    public string nameItem = " ";
    public int valueGold = 0;
    public Sprite imageSprite;
}
