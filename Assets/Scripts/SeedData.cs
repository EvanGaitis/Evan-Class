using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Seeds")]
public class SeedData : ItemDate
{
    //How many seconds it takes for the second to get ready
    public int secondsToGrow;

    //the crops will yield
    public ItemDate cropsToYield;
}
