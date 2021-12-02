using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [Header("Inventory System")]
    public GameObject inventoryPanel;
    public InventorySlot[] toolSlots;
    public InventorySlot[] itemSlots;

    public Text itemNameText;
    public Text itemDescriptionText;

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

    public void ToggleInventoryPanel()
    {
        inventoryPanel.SetActive(!inventoryPanel.activeSelf);

        RenderInventory();
    }

    //Display item info in the box
    public void DisplayItemInfo(ItemDate date)
    {  
        //if data is null reset
        if(date == null)
        {
            itemNameText.text = "";
            itemDescriptionText.text = "";

            return;
        }

        itemNameText.text = date.name;
        itemDescriptionText.text = date.description;
    }
}
