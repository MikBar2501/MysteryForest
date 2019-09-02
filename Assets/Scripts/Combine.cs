using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combine : MonoBehaviour
{
    string slot1id;
    string slot2id;

    public Slot slot1;
    public Slot slot2;

    void Start() {
        ResetSlot();
    }

    public void GenerateLoreId(string id1, string id2) {
        string combine = id1 + "+" + id2;
        //Debug.Log(combine);
        if(FindInLoreBase(combine)) {
            //Debug.Log("We have part of Lore");
            GameManager.gameManager.AddToLore(combine);
            GetLoreID(combine);
            GameManager.gameManager.Save();
        } else {
            //Debug.Log("Nothing");
        }

        ResetSlot();
    }

    public void StartGenerate() {
        GenerateLoreId(slot1id, slot2id);
    }

    public void SetSlot(string id) {
        if(slot1id == "") {
            slot1id = id;
            slot1.DrawInSlot(slot1id);
        } else {
            slot2id = id;
            slot2.DrawInSlot(slot2id);
            Invoke("StartGenerate", 1f);
        }
    }

    public void ResetSlot() {
        slot1id = slot2id = "";
        slot2.TurnOffSign();
        slot1.TurnOffSign();
    }

    public bool FindInLoreBase(string id) {
        //bool find = false;
        foreach(string identificator in GameManager.gameManager.baseLore) {
            if(identificator == id) {
                return true;
            }
        }
        return false;
    }

    public void GetLoreID(string id) {
        GameManager.gameManager.SetUsingCombine(id);
        GameManager.gameManager.TurnOnPanel(5);
    }
}
