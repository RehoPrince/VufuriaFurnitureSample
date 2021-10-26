using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureDisplay : MonoBehaviour
{
    private int currentIndex = 0;
    private int length;

    private SOFurnitureDisplay currentFurnitureDisplay;




    [Header("General Vars")]
    [Space(10)]
    public static GameObject furniturePrefab;
    public string title;
    public string description;
    

    [Header("Scriptable Object Vars")]
    [Space(10)]
    [SerializeField]
    SOFurnitureDisplay[] furnitureDisplays;
    
    void Awake()
    {
        length = furnitureDisplays.Length;


        currentFurnitureDisplay = furnitureDisplays[currentIndex];
        furniturePrefab =  (GameObject)Instantiate(currentFurnitureDisplay.prefab, this.transform);
        title = currentFurnitureDisplay.title;
        description = currentFurnitureDisplay.description;
    }

    
    

    #region Button Action Function


    public void NextDisplay(bool add)
    {

        int index = GetIndex(add);

        currentFurnitureDisplay = furnitureDisplays[index];

        Display(furniturePrefab, out furniturePrefab);
        title = currentFurnitureDisplay.title;
        description = currentFurnitureDisplay.description;      



    }


    #endregion
    #region Other Functions
    /// <summary>
    /// Displays the Asset prefab as a GameObject that can be destroyed
    /// The `prefabIn` GameObject should be the same as the `prefabOut` GameObject
    /// Ensures there's only instance of instantiated GameObject
    /// </summary>
    /// <param name="prefabIn"></param>
    /// <param name="prefabOut"></param>
    void Display(GameObject prefabIn, out GameObject prefabOut)
    {
        Destroy(prefabIn);

        GameObject prefabInScene = (GameObject)Instantiate(currentFurnitureDisplay.prefab, this.transform);

        prefabOut = prefabInScene;
    }

    /// <summary>
    ///Gets the Current index or Previous index of the Scriptable Objects 
    /// </summary>
    /// <param name="add">Determines whether to add or subtract from current index</param>
    /// <returns>int index</returns>
    private int GetIndex(bool add = true)
    {
        if (add)
        {
            currentIndex++;
            if(currentIndex > length - 1)
            {
                currentIndex = length - 1;
            }
        }
        else
        {
            currentIndex--;
            if(currentIndex < 0)
            {
                currentIndex = 0;
            }
        }

        return currentIndex;
        
    }
    #endregion
}
