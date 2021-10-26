using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    FurnitureDisplay furnitureDisplay;

    [SerializeField] TextMeshProUGUI furnitureTitleText;
    [SerializeField] TextMeshProUGUI furnitureDescText;
     

    void Awake()
    {
        furnitureDisplay = GameObject.FindGameObjectWithTag("Furniture Display").GetComponent<FurnitureDisplay>();

    }

    void Start()
    {
        furnitureTitleText.text = furnitureDisplay.title;
        furnitureDescText.text = furnitureDisplay.description;
    }


    public void OnNextButton()
    {
        furnitureDisplay.NextDisplay(true);
        furnitureTitleText.text = furnitureDisplay.title;
        furnitureDescText.text = furnitureDisplay.description;
    }

    public void OnPrevButton()
    {
        furnitureDisplay.NextDisplay(false);
        furnitureTitleText.text = furnitureDisplay.title;
        furnitureDescText.text = furnitureDisplay.description;
    }
}
