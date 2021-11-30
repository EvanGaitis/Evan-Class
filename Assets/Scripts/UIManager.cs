using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [Header("Inventory System")]
    public InventorySlot[] toolSlots;
    public InventorySlot[] itemSlots;
    
    private void Awake()
    {
        //if there is more than one instance destroy the extra
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        RenderInventory();
    }

    public void RenderInventory()
    {
        ItemDate[] inventoryToolSlots = InventoryManager.Instance.tools;

        ItemDate[] inventoryItemSlots = InventoryManager.Instance.items;    

        RenderInventoryPanel(inventoryToolSlots, toolSlots);

        RenderInventoryPanel(inventoryItemSlots, itemSlots);
    }

    void RenderInventoryPanel(ItemDate[] slots, InventorySlot[] uiSlot)
    {
        for (int i = 0; i < uiSlot.Length; i++)
        {
            uiSlot[i].Display(slots[i]);
        }
    }


}
