using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class ListElement : MonoBehaviour
{
    public GameObject [] elements;
    public GameObject prefab;
    public Transform grid;

    

    protected virtual void LoadElements(List<string> elementsList) {
        //GameManager.gameManager.Print();
        //Array.Clear(elements,0,elements.Length);
        elements = new GameObject[elementsList.Count];
        for(int i = 0; i < elements.Length; i++) {
            elements[i] = Instantiate(prefab,grid);
            elements[i].GetComponent<Sign>().CreateSign(elementsList[i]);
            elements[i].transform.parent = grid;
        }
    }

    void OnDisable() {
        foreach (Transform child in grid.transform) {
            Destroy(child.gameObject);
        }
        elements = new GameObject[0];
    }
}
