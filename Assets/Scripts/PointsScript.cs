using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsScript : MonoBehaviour
{
    public GameObject pointsText;
    public GameObject canvas;
    int totalMoney;
    Text displayMoney;

    // Start is called before the first frame update
    void Start()
    {
        displayMoney = pointsText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        totalMoney = canvas.GetComponent<ShopInventory>().money;

        displayMoney.text = totalMoney.ToString();
    }



}
