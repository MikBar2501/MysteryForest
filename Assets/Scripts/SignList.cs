using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignList : ListElement
{
    void OnEnable() {
        LoadElements(GameManager.gameManager.foundSign);
    }

    void OnDisable() {
        foreach (Transform child in grid.transform) {
            Destroy(child.gameObject);
        }
    }
}
