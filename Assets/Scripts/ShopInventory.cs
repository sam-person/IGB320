using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventory : MonoBehaviour
{
    public int money;
    public GameObject RoomCanvas;
    public GameObject[] furniture;
    public GameObject[] ownedFurniture;

    public GameObject[] inventoryFurniture;
    public GameObject[] allInventoryFurniture;

    public GameObject emptyPrefab;

    public int AirconPrice;
    public int BarPrice;
    public int BedPrice;
    public int BlindsPrice;
    public int CoffeeTablePrice;
    public int ComputerPrice;
    public int CouchPrice;
    public int DiningTablePrice;
    public int RugPrice;
    public int TVPrice;
    public int ShelvesPrice;

    //bool AirconOn;
    //bool BarOn;
    //bool BedOn;
    //bool BlindsOn;
    //bool CoffeeOn;
    //bool ComputerOn;
    //bool CouchOn;
    //bool DiningTableOn;
    //bool RugOn;
    //bool TVOn;
    //bool ShevlesOn;


    // Start is called before the first frame update
    void Start()
    {
        removeHomeObjets();
    }

    //stop displaying objects when off screen
    public void removeHomeObjets()
    {
        foreach (GameObject roomObject in furniture)
        {
            roomObject.SetActive(false);
        }

        foreach (GameObject inventory in inventoryFurniture)
        {
            inventory.SetActive(false);
        }
    }

    //display all owned products
    public void drawHomeObjects()
    {
        foreach (GameObject ownedRoomObject in ownedFurniture)
        {
            ownedRoomObject.SetActive(true);
        }
    }

    public void drawInventory()
    {
        foreach (GameObject ownedInvetory in inventoryFurniture)
        {
            ownedInvetory.SetActive(true);
        }
    }

    public void buyAircon()
    {
        if (money > AirconPrice && ownedFurniture[0] != furniture[0])
        {
            money -= AirconPrice;
            ownedFurniture[0] = furniture[0];

            inventoryFurniture[0] = allInventoryFurniture[0];
        }
    }

    public void buyBar()
    {
        if (money > BarPrice && ownedFurniture[1] != furniture[1])
        {
            money -= BarPrice;
            ownedFurniture[1] = furniture[1];

            inventoryFurniture[1] = allInventoryFurniture[1];
        }
    }

    public void buyBed()
    {
        if (money > BedPrice && ownedFurniture[2] != furniture[2])
        {
            money -= BedPrice;
            ownedFurniture[2] = furniture[2];

            inventoryFurniture[2] = allInventoryFurniture[2];
        }
    }

    public void buyBlinds()
    {
        if (money > BlindsPrice && ownedFurniture[3] != furniture[3])
        {
            money -= BlindsPrice;
            ownedFurniture[3] = furniture[3];

            inventoryFurniture[3] = allInventoryFurniture[3];
        }
    }

    public void buyCoffeeTable()
    {
        if (money > CoffeeTablePrice && ownedFurniture[4] != furniture[4])
        {
            money -= CoffeeTablePrice;
            ownedFurniture[4] = furniture[4];

            inventoryFurniture[4] = allInventoryFurniture[4];
        }
    }

    public void buyComputer()
    {
        if (money > ComputerPrice && ownedFurniture[5] != furniture[5])
        {
            money -= ComputerPrice;
            ownedFurniture[5] = furniture[5];

            inventoryFurniture[5] = allInventoryFurniture[5];
        }
    }

    public void buyCouch()
    {
        if (money > CouchPrice && ownedFurniture[6] != furniture[6])
        {
            money -= CouchPrice;
            ownedFurniture[6] = furniture[6];

            inventoryFurniture[6] = allInventoryFurniture[6];
        }
    }

    public void buyDiningTable()
    {
        if (money > DiningTablePrice && ownedFurniture[7] != furniture[7])
        {
            money -= DiningTablePrice;
            ownedFurniture[7] = furniture[7];

            inventoryFurniture[7] = allInventoryFurniture[7];
        }
    }

    public void buyRug()
    {
        if (money > RugPrice && ownedFurniture[8] != furniture[8])
        {
            money -= RugPrice;
            ownedFurniture[8] = furniture[8];

            inventoryFurniture[8] = allInventoryFurniture[8];
        }
    }

    public void buyTelevision()
    {
        if (money > TVPrice && ownedFurniture[9] != furniture[9])
        {
            money -= TVPrice;
            ownedFurniture[9] = furniture[9];

            inventoryFurniture[9] = allInventoryFurniture[9];
        }
    }

    public void buyShelves()
    {
        if (money > ShelvesPrice && ownedFurniture[10] != furniture[10])
        {
            money -= ShelvesPrice;
            ownedFurniture[10] = furniture[10];

            inventoryFurniture[10] = allInventoryFurniture[10];
        }
    }

    //public void AirconOnOff()
    //{
    //    if (AirconOn == true)
    //    {
    //        ownedFurniture[0] = emptyPrefab;
    //    }
    //    else if (AirconOn == false)
    //    {
    //        ownedFurniture[0] = furniture[0];
    //    }
    //}




}
