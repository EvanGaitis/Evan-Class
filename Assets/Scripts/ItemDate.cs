using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Item/Items")]
public class ItemDate : ScriptableObject
{
    public string description;
    public Sprite thumbnail;
    public GameObject gameModel;
}
