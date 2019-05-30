using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventory : MonoBehaviour
{
    private int money;
    public GameObject RoomCanvas;
    public GameObject[] furniture;
    public GameObject[] ownedFurniture;


    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject roomObject in furniture)
        {
            roomObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
