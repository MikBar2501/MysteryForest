using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineList : ListElement
{
    void OnEnable() {
        LoadElements(GameManager.gameManager.foundSign);
    }
}
