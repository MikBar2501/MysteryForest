using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Sign : MonoBehaviour {
    
    public string id; //0-0-0-0-0-0-0-RED

    public Image verticalLine;
    public Image horizontalLine;
    public Image crossLine;
    public Image graetCircle;
    public Image smallCircle;
    public Image greatSquare;
    public Image smallSquare;
    Color color; 
    

    private void Start() {

    }

    private void DrawSign() {
        //Debug.Log(id);
        string [] idParts = id.Split('-');
        //SpellMyArray(idParts);

        //Debug.Log(idParts[7]);
        //Debug.Log(idParts[7].Length);
        //string test = idParts[7];
        //Debug.Log(test[test.Length - 1]);
        idParts[7] = CorrectColor(idParts[7]);

        if(idParts[7] == "RED")
        {
            color = new Color(1f,0,0.056f,1f);
        } 
        else if(idParts[7].Trim() == "GREEN")
        {
            color = new Color(0.266f,1f,0.063f,1f);
        } 
        else if(idParts[7].Trim() == "BLUE")
        {
            color = new Color(0f,0.5439873f,1f,1f);
        } 
        else if(idParts[7].Trim() == "YELLOW")
        {
            color = new Color(1f,0.8874891f,0,1f);
        } 
        else if(idParts[7].Trim() == "PINK")
        {
            color = new Color(1f,0,0.449203f,1f);
        } 
        else if(idParts[7].Trim() == "ORANGE")
        {
            color = new Color(1f,0.4184411f,0,1f);
        } else {
            color = new Color(1f,1f,1f,1f);
        }

        string newID = idParts[0] + "-" + idParts[1] + "-" + idParts[2] + "-" + idParts[3] + "-" + idParts[4] + "-" + idParts[5] + "-" + idParts[6] + "-" + idParts[7];
        id = newID;

        if(idParts[0] == "1"){
            //verticalLine.SetActive(true);
            verticalLine.color = color;
            //verticalLine.color.a = 1f;

        } else {
            //verticalLine.SetActive(false);
            verticalLine.color = new Color(0,0,0,0);
        }

        if(idParts[1] == "1"){
            //horizontalLine.SetActive(true);
            horizontalLine.color = color;
            //horizontalLine.color.a = 1f;
        } else {
            //horizontalLine.SetActive(false);
            horizontalLine.color = new Color(0,0,0,0);
        }

        if(idParts[2] == "1"){
            //crossLine.SetActive(true);
            crossLine.color = color;

            //crossLine.color.a = 1f;
        } else {
            //crossLine.SetActive(false);
            crossLine.color = new Color(0,0,0,0);
        }

        if(idParts[3] == "1"){
            //graetCircle.SetActive(true);
            graetCircle.color = color;

            //graetCircle.color.a = 1f;
        } else {
            //graetCircle.SetActive(false);
            graetCircle.color = new Color(0,0,0,0);
        }

        if(idParts[4] == "1"){
            //smallCircle.SetActive(true);
            smallCircle.color = color;

            //smallCircle.color.a = 1f;
        } else {
            //smallCircle.SetActive(false);
            smallCircle.color = new Color(0,0,0,0);
        }

        if(idParts[5] == "1"){
            //greatSquare.SetActive(true);
            greatSquare.color = color;

            //greatSquare.color.a = 1f;
        } else {
            //greatSquare.SetActive(false);
            greatSquare.color = new Color(0,0,0,0);
        }

        if(idParts[6] == "1"){
            //smallSquare.SetActive(true);
            smallSquare.color = color;

            //smallSquare.color.a = 1f;
        } else {
            //verticalLine.SetActive(false);
            smallSquare.color = new Color(0,0,0,0);
        }
    }

    public void CreateSign(string identificator) {
        id = identificator;
        DrawSign();
    }

    public void SpellMyArray(string [] array) {
        for(int i = 0; i < array.Length; i++) {
            Debug.Log(array[i]);
            
        }
        Debug.Log(array.Length.ToString());
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
