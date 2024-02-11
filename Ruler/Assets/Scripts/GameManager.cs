using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject myPlayer;

    private float myPositionZ;
    
    private const string DATA_DIR = "/Data/";
    private const string DATA_P_FILE = "p.txt";
    private string DATA_FULL_P_FILE_PATH;

    public float MyPositionZ
    {
        get
        {
            if (File.Exists(DATA_FULL_P_FILE_PATH))
            {
                string fileContents = File.ReadAllText(DATA_FULL_P_FILE_PATH);
                myPositionZ = float.Parse(fileContents);
            }
            return myPositionZ;
        }

        set
        {
            myPositionZ = value;
            string fileContent = "" + myPositionZ;
            if (!File.Exists(DATA_FULL_P_FILE_PATH))
            {
                Directory.CreateDirectory(Application.dataPath + DATA_DIR);
            }
            File.WriteAllText(DATA_FULL_P_FILE_PATH, fileContent);
        }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DATA_FULL_P_FILE_PATH = Application.dataPath + DATA_DIR + DATA_P_FILE;
        
        Vector3 position = new Vector3(0f, 0f, MyPositionZ);
        myPlayer.transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        myPositionZ = myPlayer.transform.position.z;
        //Debug.Log("POSITION Z =" + myPositionZ + "\nPOSITION Z CONTENT =" + MyPositionZ);

        if (Input.GetKeyDown(KeyCode.S))
        {
            float savedPosition = myPositionZ;
            MyPositionZ = savedPosition;
            Debug.Log("Your position is saved" + savedPosition);
        }
        
        if(Input.GetKeyDown(KeyCode.L))
        {
            Vector3 position = new Vector3(0f, 0f, MyPositionZ);
            myPlayer.transform.position = position;
        }
    }
}
