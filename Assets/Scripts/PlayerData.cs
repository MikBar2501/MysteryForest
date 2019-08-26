using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public string [] foundID;
    public string [] foundLoreID;

    public PlayerData(GameManager gameManager) {
        foundID = new string [gameManager.FoundSignCount()];
        for(int i = 0; i < gameManager.FoundSignCount(); i++) {
            foundID[i] = gameManager.foundSign[i];
        }

        foundLoreID = new string [gameManager.FoundLoreCount()]; 
        for(int j = 0; j < gameManager.FoundLoreCount(); j++) {
            foundLoreID[j] = gameManager.foundLore[j];
        }
    }

    public PlayerData() {
        foundLoreID = null;
        foundID = null;

    }
}
