using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Unity.Editor;
using Firebase.Database;
using UnityEngine.UI;
public class DataBridge : MonoBehaviour
{
    public Text usernameInput, passwordInput;
    private Player data;
    private DatabaseReference databaseReference;
    // Start is called before the first frame update
    void Start()
    {
       FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://mystartup-a40c4.firebaseio.com/");
       databaseReference = FirebaseDatabase.DefaultInstance.RootReference; 
    }

    public void Savedata(){
        data = new Player(usernameInput.text, passwordInput.text);
        string jsonData = JsonUtility.ToJson(data);
        databaseReference.Child("Users" + Random.Range(0,100000)).SetRawJsonValueAsync(jsonData);
        Debug.Log("data dent");
    }


    


    // Update is called once per frame
    void Update()
    {
        
    }
}
