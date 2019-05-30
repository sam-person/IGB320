using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    //menu screens
    public GameObject mainMenuCanvas;
    public GameObject homeCanvas;
    public GameObject shopMenu;
    public GameObject savingsMenu;
    public GameObject helpMenu;
    public GameObject Room;

    GameObject homeMenuButtonCanvas;
    GameObject bagsMenu;

    GameObject homeSprite;
    GameObject savingsSprite;

    //shop buttons
    GameObject shopButtonRight;
    GameObject shopButtonLeft;

    //furniture prefabs
    public GameObject shopPage1;
    public GameObject shopPage2;


    public static bool isShopScreen1 = true;


    // Start is called before the first frame update
    void Start()
    {
        homeMenuButtonCanvas = homeCanvas.transform.Find("homeMenu").gameObject;
        bagsMenu = homeCanvas.transform.Find("bagsMenu").gameObject;
        savingsMenu = homeCanvas.transform.Find("savingsMenu").gameObject;

        homeSprite = homeCanvas.transform.Find("homeSprite").gameObject;
        //savingsSprite = homeCanvas.transform.Find("savingsSprite").gameObject;

        shopButtonRight = shopMenu.transform.Find("Shop Right").gameObject;
        shopButtonLeft = shopMenu.transform.Find("Shop Left").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void login()
    {
        //remove main menu screen
        mainMenuCanvas.SetActive(false);

        //activate home screen
        homeCanvas.SetActive(true);
        homeMenuButtonCanvas.SetActive(true);
        Room.SetActive(true);
    }

    public void openShop()
    {
        //remove home screen
        homeSprite.SetActive(false);
        homeMenuButtonCanvas.SetActive(false);
        Room.SetActive(false);

        //activate shop screen
        shopMenu.SetActive(true);
    }

    public void openBags()
    {
        //remove home screen
        homeSprite.SetActive(false);
        homeMenuButtonCanvas.SetActive(false);
        Room.SetActive(false);

        //activate bags screen
        bagsMenu.SetActive(true);
    }

    public void openHelp()
    {
        //remove home screen
        homeSprite.SetActive(false);
        homeMenuButtonCanvas.SetActive(false);
        Room.SetActive(false);

        //activate help screen
        helpMenu.SetActive(true);
    }

    public void openSavings()
    {
        //remove home screen
        homeSprite.SetActive(false);
        homeMenuButtonCanvas.SetActive(false);
        Room.SetActive(false);

        //activate savings screen
        savingsMenu.SetActive(true);
    }

    public void backHome()
    {
        //remove current screen
        shopMenu.SetActive(false);
        bagsMenu.SetActive(false);
        helpMenu.SetActive(false);
        savingsMenu.SetActive(false);

        //activate home screen
        homeSprite.SetActive(true);
        homeMenuButtonCanvas.SetActive(true);
        Room.SetActive(true);
    }

    public void ShopScreen()
    {
        //swap screens
        if (isShopScreen1 == true)
        {
            shopButtonLeft.SetActive(true);
            shopButtonRight.SetActive(false);

            shopPage1.SetActive(false);
            shopPage2.SetActive(true);

            isShopScreen1 = false;
        }

        else if(isShopScreen1 == false)
        {
            shopButtonLeft.SetActive(false);
            shopButtonRight.SetActive(true);

            shopPage1.SetActive(true);
            shopPage2.SetActive(false);

            isShopScreen1 = true;
        }
    }

}
