using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ColorsList 
{
    public List<string> RED = new List<string>();
    public List<string> BLUE = new List<string>();
    public List<string> GREEN = new List<string>();
    public List<string> YELLOW = new List<string>();
    public List<string> PINK = new List<string>();
    public List<string> WHITE = new List<string>();
    public List<string> ORANGE = new List<string>();

    public ColorsList(List<string> signs) {
        foreach(string sign in signs) {
            string [] idSplit = sign.Split('-');
            idSplit[7] = CorrectColor(idSplit[7]);
            switch(idSplit[7]) {
                case "RED":
                    RED.Add(sign);
                    break;
                case "GREEN":
                    GREEN.Add(sign);
                    break;
                case "YELLOW":
                    YELLOW.Add(sign);
                    break;
                case "BLUE":
                    BLUE.Add(sign);
                    break;
                case "PINK":
                    PINK.Add(sign);
                    break;
                case "ORANGE":
                    ORANGE.Add(sign);
                    break;
                default:
                    WHITE.Add(sign);
                    break;
            }
        }
    }

    public List<string> ChooseColor(string color) {
        switch(color) {
                case "RED":
                    return RED;
                    break;
                case "GREEN":
                    return GREEN;
                    break;
                case "YELLOW":
                    return YELLOW;
                    break;
                case "BLUE":
                    return BLUE;
                    break;
                case "PINK":
                    return PINK;
                    break;
                case "ORANGE":
                    return ORANGE;
                    break;
                default:
                    return WHITE;
                    break;
                
            }
    }

    string CorrectColor(string line) {
        string color = "";
        foreach(char ch in line) {
            color += ch;
            switch(color) {
                case "RED":
                    return "RED";
                case "GREEN":
                    return "GREEN";
                case "YELLOW":
                    return "YELLOW";
                case "PINK":
                    return "PINK";
                case "BLUE":
                    return "BLUE";
                case "ORANGE":
                    return "ORANGE";
            }
        }
        return "WHITE";  
    }
    
}
