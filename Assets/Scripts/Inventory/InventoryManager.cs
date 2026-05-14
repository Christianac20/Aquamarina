using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryManager : MonoBehaviour
{
    #region VARIABLES
    public ItemSlot[] itemSlots;
    public ItemSO[] itemSOs;
    public AudioManager audioManager;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool UseItem(string itemName)
    {
        for (int i = 0; i < itemSOs.Length; i++)
        { 
            if(itemSOs[i].itemName == itemName)
            {
                bool usable = itemSOs[i].UseItem();
                return usable;
            }
        }
        return false;

    }

    public int AddItem(string itemName, int quantity, Sprite itemSprite)
    {
        //Debug.Log("itemName = " + itemName + ", quantity = " + quantity + ", itemSprite = " + itemSprite);
        for (int i = 0; i < itemSlots.Length; i++) //CIclo por todas las casillas del inventario
        {
            if (itemSlots[i].isFull == false && itemSlots[i].itemName == itemName || itemSlots[i].quantity == 0) 
            { 
                int leftOverItems = itemSlots[i].AddItem(itemName, quantity, itemSprite);
                if (leftOverItems > 0) 
                {
                    leftOverItems = AddItem(itemName, leftOverItems, itemSprite);
                }
                return leftOverItems;
            }
        }
        switch (itemName)
        {
            case "O2 Bottle":
                audioManager.PlaySFX(audioManager.BombonaOxigeno);
                Debug.Log("Suena mostro");
                break;
            case "MenaHierro":
                audioManager.PlaySFX(audioManager.Plastico);
                break;
            case "Cobre":
                audioManager.PlaySFX(audioManager.Cobre);
                Debug.Log("Suena mostro");
                break;
            case "Hierro":
                audioManager.PlaySFX(audioManager.Hierro);
                break;
            case "Cristal":
                audioManager.PlaySFX(audioManager.Cristal);
                break;
            case "Burbuja":
                audioManager.PlaySFX(audioManager.Oxigeno);
                break;
            
        }
        return quantity;
    }

    public void DeselectAllSlots()
    {
        for (int i = 0; i < itemSlots.Length; i++)
        {
            itemSlots[i].selectedShader.SetActive(false);
            itemSlots[i].thisItemSelected = false;
        }
    }
}
