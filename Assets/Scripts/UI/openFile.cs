using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using Dummiesman;
using System.IO;

public class openFile : MonoBehaviour
{
    string path;
    string error = string.Empty;
    GameObject loadedObject;

    public void OpenExplorer(){
        path = EditorUtility.OpenFilePanel("Open File", "", "");

        if (!File.Exists(path)){
            error = "File " + path + " does not exist";
        }
        else{
            if (loadedObject != null){
                Destroy(loadedObject);
            }
            loadedObject = new OBJLoader().Load(path);
            loadedObject.tag = "model3d";
            error = string.Empty;
        }
    }
}
