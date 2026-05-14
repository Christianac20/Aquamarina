using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    #region VARIABLES
    //ITEM DATA
    public string itemName;
    public int quantity;
    [SerializeField] int maxNumberOfItems;
    [SerializeField] Sprite itemSprite;
    [SerializeField] Sprite emptySprite;
    public bool isFull;

    //ITEM SLOT
    [SerializeField] TMP_Text quantityText;
    [SerializeField] Image itemImage;
    public GameObject selectedShader;
    public bool thisItemSelected;
    [SerializeField] InventoryManager inventoryManager;
    #endregion

    #region METHODS
    void Start() //Almaceno referencias a scripts
    {
        inventoryManager = FindAnyObjectByType<InventoryManager>();
    }

    public int AddItem(string itemName, int quantity, Sprite itemSprite) //METODO para añadir items al inventario
    {
        //Check if the slot is already full
        if (isFull)
        {
            return quantity;
        }

        //Update NAME
        this.itemName = itemName;

        //Update IMAGE
        this.itemSprite = itemSprite;
        itemImage.sprite = itemSprite;

        //Update QUANTITY
        this.quantity += quantity;
        if (this.quantity >= maxNumberOfItems)
        {
            quantityText.text = maxNumberOfItems.ToString();
            quantityText.enabled = true;
            isFull = true;

            //Return the LEFTOVERS
            int extraItems = this.quantity - maxNumberOfItems;
            this.quantity = maxNumberOfItems;
            return extraItems;
        }

        //Update QUANTITY TEXT
        quantityText.text = this.quantity.ToString();
        quantityText.enabled = true;

        return 0;
    }

    public void OnPointerClick(PointerEventData eventData) //Que hace un slot si lo clicas
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

    public void OnLeftClick() //al hacer click izdo, si el item es usable, lo usa y deduce uno del total de ese slot. Si el recuento de items de x tipo en un slot es 0, vacía el slot
    {
        if (thisItemSelected)
        {
            bool usable = inventoryManager.UseItem(itemName);
            if (usable)
            {
                this.quantity -= 1;
                quantityText.text = this.quantity.ToString();
                if (this.quantity <= 0)
                {
                    EmptySlot();
                }
            }
        }
        else //Deselecciona todos los slots y selecciona en el que se hace click si no es usable, solo pa efecto de seleccion
        {
            inventoryManager.DeselectAllSlots();
        
            selectedShader.SetActive(true);
            thisItemSelected = true;
        }
    }

    private void EmptySlot() //Metodo que se llama al tener un  slot vacio, desactivando su texto y poniendo el sprite de slot vacio
    {
        quantityText.enabled = false;
        itemImage.sprite = emptySprite;

    }

    public void OnRightClick()
    { 
    
    }
    #endregion
}
