using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance { get; private set; }

    private void Awake()
    {
        //if there is more than one instance de stroy the extra
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }


    [Header("tools")]
    //how many tools are there
    public ItemDate[] tools = new ItemDate[4];
    //what item is on players hand
    public ItemDate equippedTool = null;
    
    [Header("Items")]
    //how many crops are there
    public ItemDate[] items = new ItemDate[8];
    //what item is on players hand
    public ItemDate equippedItem = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
