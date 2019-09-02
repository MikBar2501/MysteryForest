using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LoreBase : ListElement
{
    void OnEnable() {
        LoadElements(GameManager.gameManager.foundLore);
    }

    protected override void LoadElements(List<string> elementsList) {
        //Array.Clear(elements,0,elements.Length);
        //GameManager.gameManager.Print();
        elements = new GameObject[elementsList.Count];
        for(int i = 0; i < elements.Length; i++) {
            string [] signs = elementsList[i].Split('+');
            elements[i] = Instantiate(prefab,grid);
            elements[i].GetComponent<LoreButtonScript>().sign1.CreateSign(signs[0]);
            elements[i].GetComponent<LoreButtonScript>().sign2.CreateSign(signs[1]);
            //elements[i].transform.parent = grid;
            elements[i].transform.SetParent(grid);

        }
    }

}
