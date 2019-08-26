using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using UnityEditor;

public class LoreFileReader : MonoBehaviour
{
 
    public FileReader fileReader;
    public Text loreText;
    public Text performanceText;
    public Text mechanicText;

    void OnEnable() {
        ReadCombineFile(GameManager.gameManager.usingCombine);
    }

    void ReadCombineFile(string id) {
        TextAsset myCombine = new TextAsset();
        foreach(TextAsset asset in fileReader.combinations) {
            if(asset.name == id) {
                myCombine = asset;
                break;
            }
        }

        string lore = "";
        string performance = "";
        string mechanic = "";
        string part = "*";

        //string [] lines = File.ReadAllLines("Assets/LoreFiles/Combinations/" + myCombine.name + ".txt");
        string text = myCombine.text;
        string [] lines = text.Split('\n');
        
        lines[0] = CorrectLine(lines[0]);
        if(lines[0] == "text") {
            
            for(int i = 1; i < lines.Length; i++) {
                lines[i] = CorrectLine(lines[i]);
                if(lines[i] == "*") {
                    part = "*";
                } else if(lines[i] == "**") {
                    part = "**";
                } else if(lines[i] == "***") {
                    part = "***";
                } else {
                    switch (part){
                        case "*":
                            lore += lines[i];
                            break;
                        case "**":
                            performance += lines[i];
                            break;
                        case "***":
                            mechanic += lines[i];
                            break;
                    }
                }
            }
        } 

        loreText.text = lore;
        performanceText.text = performance;
        mechanicText.text = mechanic;
    }

    string CorrectLine(string line) {
        string text = "";

        for(int i = 0; i < line.Length; i++) {
            if(line[0] == '*' && line[1] != '*') {
                text = "*";
            } else if(line[0] == '*' && line[1] == '*' && line[2] != '*') {
                text = "**";
            } else if(line[0] == '*' && line[1] == '*' && line[2] == '*') {
                text = "***";
            } else if(line[0] == 't' && line[1] == 'e' && line[2] == 'x' && line[3] == 't') {
                text = "text";
            } else {
                text = line;
            }
        }

        return text;
    }
}
