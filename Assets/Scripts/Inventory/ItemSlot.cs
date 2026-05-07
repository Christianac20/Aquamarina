using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    #region VARIABLES
    //ITEM DATA
    [SerializeField] string itemName;
    [SerializeField] int quantity;
    [SerializeField] Sprite itemSprite;
    public bool isFull;

    //ITEM SLOT
    [SerializeField] TMP_Text quantityText;
    [SerializeField] Image itemImage;

    public GameObject selectedShader;
    public bool thisItemSelected;
    [SerializeField] InventoryManager inventoryManager;
    #endregion

    #region METHODS
    void Start()
    {
        inventoryManager = FindAnyObjectByType<InventoryManager>();
    }

    public void AddItem(string itemName, int quantity, Sprite itemSprite)
    {
        this.itemName = itemName;
        this.quantity = quantity;
        this.itemSprite = itemSprite;
        isFull = true;

        quantityText.text = quantity.ToString();
        quantityText.enabled = true;
        itemImage.sprite = itemSprite;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            OnLeftClick();
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            OnRightClick();
        }
    }

    public void OnLeftClick()
    { 
        inventoryManager.DeselectAllSlots();
        
        selectedShader.SetActive(true);
        thisItemSelected = true;
    }

    public void OnRightClick()
    { 
    
    }
    #endregion
}
