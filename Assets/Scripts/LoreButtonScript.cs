using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoreButtonScript : Sign
{
    public Sign sign1;
    public Sign sign2;

    void Start() {
        id = sign1.id + "+" + sign2.id;
        GetComponent<Button>().onClick.AddListener(delegate {this.GetLoreID();});
    }
    
    public void GetLoreID() {
        GameManager.gameManager.SetUsingCombine(id);
        GameManager.gameManager.TurnOnPanel(5);
    }

}
