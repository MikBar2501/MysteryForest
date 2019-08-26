using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;

public class FileReader : MonoBehaviour
{

    public TextAsset [] combinations;
    public TextAsset signs;

    void Awake() {
        //combinations = Resources.LoadAll("Combinations", typeof(TextAsset)).Cast<TextAsset>().ToArray();
        //signs = Resources.Load<TextAsset>("signs");
    }

    //[MenuItem("Tools/Read file")]
    public void ReadSignsFile()
    {
        //string path = "Assets/Resources/signs.txt";
        string path = signs.text;
        //string [] lines = File.ReadAllLines(path);

        //Debug.Log(path);
        string [] lines = path.Split('\n');
        
        foreach (string line in lines)
        {
            GameManager.gameManager.baseSign.Add(line);
        }  
    }

    public void LoadCombinations() {
        for(int i = 0; i < combinations.Length; i++) {
            GameManager.gameManager.baseLore.Add(combinations[i].name);
        }
    }

}
