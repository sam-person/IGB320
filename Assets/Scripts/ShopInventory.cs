using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventory : MonoBehaviour
{
    public int money;
    public GameObject RoomCanvas;
    public GameObject[] furniture;
    public GameObject[] ownedFurniture;

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


    // Start is called before the first frame update
    void Start()
    {
        removeHomeObjets();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //stop displaying objects when off screen
    public void removeHomeObjets()
    {
        foreach (GameObject roomObject in furniture)
        {
            roomObject.SetActive(false);
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

    public void buyAircon()
    {
        if (money > AirconPrice && ownedFurniture[0] != furniture[0])
        {
            money -= AirconPrice;
            ownedFurniture[0] = furniture[0];
        }
    }

    public void buyBar()
    {
        if (money > BarPrice && ownedFurniture[1] != furniture[1])
        {
            money -= BarPrice;
            ownedFurniture[1] = furniture[1];
        }
    }

    public void buyBed()
    {
        if (money > BedPrice && ownedFurniture[2] != furniture[2])
        {
            money -= BedPrice;
            ownedFurniture[2] = furniture[2];
        }
    }

    public void buyBlinds()
    {
        if (money > BlindsPrice && ownedFurniture[3] != furniture[3])
        {
            money -= BlindsPrice;
            ownedFurniture[3] = furniture[3];
        }
    }

    public void buyCoffeeTable()
    {
        if (money > CoffeeTablePrice && ownedFurniture[4] != furniture[4])
        {
            money -= CoffeeTablePrice;
            ownedFurniture[4] = furniture[4];
        }
    }

    public void buyComputer()
    {
        if (money > ComputerPrice && ownedFurniture[5] != furniture[5])
        {
            money -= ComputerPrice;
            ownedFurniture[5] = furniture[5];
        }
    }

    public void buyCouch()
    {
        if (money > CouchPrice && ownedFurniture[6] != furniture[6])
        {
            money -= CouchPrice;
            ownedFurniture[6] = furniture[6];
        }
    }

    public void buyDiningTable()
    {
        if (money > DiningTablePrice && ownedFurniture[7] != furniture[7])
        {
            money -= DiningTablePrice;
            ownedFurniture[7] = furniture[7];
        }
    }

    public void buyRug()
    {
        if (money > RugPrice && ownedFurniture[8] != furniture[8])
        {
            money -= RugPrice;
            ownedFurniture[8] = furniture[8];
        }
    }

    public void buyTelevision()
    {
        if (money > TVPrice && ownedFurniture[9] != furniture[9])
        {
            money -= TVPrice;
            ownedFurniture[9] = furniture[9];
        }
    }

    public void buyShelves()
    {
        if (money > ShelvesPrice && ownedFurniture[10] != furniture[10])
        {
            money -= ShelvesPrice;
            ownedFurniture[10] = furniture[10];
        }
    }
}
