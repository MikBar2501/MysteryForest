using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public List<string> baseSign = new List<string>();
    public List<string> foundSign = new List<string>();
    public List<string> baseLore = new List<string>();
    public List<string> foundLore = new List<string>();

    public GameObject [] panels;

    FileReader fileReader;
    public string usingCombine;

    public ColorsList colorsList;

    List<string> saveFound;
    

    void Awake() {
        usingCombine = "";
        gameManager = this;
        fileReader = GetComponent<FileReader>();
        fileReader.combinations = Resources.LoadAll("Combinations", typeof(TextAsset)).Cast<TextAsset>().ToArray();
        fileReader.signs = Resources.Load<TextAsset>("signs");
        fileReader.ReadSignsFile();
        fileReader.LoadCombinations();
        saveFound = new List<string>();
        
        /*baseSign.Add("0-1-1-1-0-1-1-RED");
        baseSign.Add("0-0-0-0-1-0-1-RED");
        baseSign.Add("0-1-1-0-0-0-1-BLUE");
        baseSign.Add("1-0-1-0-1-0-1-GREEN");
        baseSign.Add("0-1-1-1-0-1-1-YELLOW");
        baseSign.Add("1-0-0-1-0-1-1-PINK");
        baseSign.Add("0-1-1-1-0-1-1-GREEN");*/

        /* foundSign.Add("0-1-1-1-0-1-1-GREEN");
        foundSign.Add("0-1-1-1-0-1-1-RED");
        foundSign.Add("0-1-1-1-0-1-1-YELLOW");
        foundSign.Add("1-0-0-1-0-1-1-PINK");*/

        //baseLore.Add("0-1-1-1-0-1-1-GREEN+0-1-1-0-0-0-1-BLUE");
        //baseLore.Add("0-1-1-1-0-1-1-YELLOW+0-1-1-1-0-1-1-RED");
        //foundLore.Add("0-1-1-0-0-0-1-BLUE+0-1-1-1-0-1-1-RED");
        Load();
        colorsList = new ColorsList(baseSign);
        
    }

    void Start() {
        
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(panels[5].activeSelf) {
                TurnOnPanel(4);
            } else {
                TurnOnPanel(0);
            }
        }
    }

/*    void Update() {
        if(Input.GetKeyDown(KeyCode.S)) {
            Save();
        } 

        if(Input.GetKeyDown(KeyCode.L)) {
            Load();
        } 
}*/

    


    public int BaseSignCount() {
        return baseSign.Count;
    }

    public int FoundSignCount() {
        return foundSign.Count;
    }

    public int FoundLoreCount() {
        return foundLore.Count;
    }

    public void Print() {
        Debug.Log("Działasz?");
        Debug.Log(BaseSignCount());
    }

    public void Save() {
        SaveSystem.SaveElements(this);
    }

    public void ResetSave() {
        PlayerData data = new PlayerData();
        SaveSystem.SaveElements(data);
        TurnOnPanel(0);
        foundSign.Clear();
        foundLore.Clear();
        //Load();
        
    }

    public void Load() {
        PlayerData data = SaveSystem.LoadElements();
        foundSign.Clear();
        foundLore.Clear();

        if(data.foundID.Length > 0) {
            for(int i = 0; i < data.foundID.Length; i++) {
                foundSign.Add(data.foundID[i]);
            }
        }

        if(data.foundLoreID.Length > 0) {
            for(int j = 0; j < data.foundLoreID.Length; j++) {
                foundLore.Add(data.foundLoreID[j]);
            }
        }
    }

    public void TurnOnPanel(int number) {
        if(number == 0) {
            Save();
        }

        for(int i = 0; i < panels.Length; i++) {
            if(i != number) {
                panels[i].SetActive(false);
            } else {
                panels[i].SetActive(true);
            }
        }

        if(number == 0) {
            SetUsingCombine("");
        }
    }

    public void SetUsingCombine(string combine) {
        usingCombine = combine;
    }

    public string GetUsingCombine() {
        return usingCombine;
    }

    public void AddToLore(string id) {
        bool find = false;
        for(int i = 0; i < foundLore.Count; i++) {
            if(foundLore[i] == id) {
                find = true;
                break;
            }
        }

        if(!find) {
            foundLore.Add(id);
        }
    }

    public void GetEveryCombination() {
        foundLore.Clear();
        foundLore = baseLore;
        /* if(saveFound.Count == 0) {
            saveFound = foundLore;
            foundLore.Clear();
            foundLore = baseLore;
        } else {
            foundLore.Clear();
            foundLore = saveFound;
            saveFound.Clear();
        }*/
    }

    public bool FoundSign(string id) {
        foreach(string sign in foundSign) {
            if(id == sign) {
                return false;
            }
        }

        return true;
    }

}
