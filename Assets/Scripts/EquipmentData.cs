using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Equipment")]
public class EquipmentData : ItemDate
{
 public enum ToolType
    {
        Hoe,WaterCan
    }
    public ToolType toolType;
}
