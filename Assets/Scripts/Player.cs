using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public Inventory inventory = new Inventory(21);

    private void Awake() {
       inventory = new Inventory(21);
    }
}
