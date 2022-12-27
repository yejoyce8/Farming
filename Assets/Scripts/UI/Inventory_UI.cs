using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_UI : MonoBehaviour
{
    public GameObject inventoryPanel;

    public Player player;

    public List<Slot_UI> slots = new List<Slot_UI>();

    void Start() {
        inventoryPanel.SetActive(false);
    }
        
    void Update()
    {
        Setup();

        if(Input.GetKeyDown(KeyCode.Tab)) {
            ToggleInventory();

        }
    }
    public void ToggleInventory() {
        if(!inventoryPanel.activeSelf) {
            inventoryPanel.SetActive(true);
            //Setup();
        } else {
            inventoryPanel.SetActive(false);
        }

    }

    void Setup() {
        if(slots.Count == player.inventory.slots.Count) {
            Debug.Log("count = count");
            for (int i = 0; i < slots.Count; i++) {
                if (player.inventory.slots[i].type != CollectableType.NONE) {
                    // display the icon
                    slots[i].SetItem(player.inventory.slots[i]);
                } else {
                    slots[i].SetEmpty();
                }
            }
        }
    }

}
