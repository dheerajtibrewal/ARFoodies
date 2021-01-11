using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Firebase;
using Firebase.Unity.Editor;
using Firebase.Database;


public class DoneToUi : MonoBehaviour
{
    public Text warning;
    public InputField name;
    public InputField number;
    public GameObject panel;
    
    public Text usernameInput, numberInput;
    private Player data;
    private DatabaseReference databaseReference;
    // Start is called before the first frame update
    void Start()
    {
       FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://mystartup-a40c4.firebaseio.com/");
       databaseReference = FirebaseDatabase.DefaultInstance.RootReference; 
    }

    public void Savedata(){
        data = new Player(usernameInput.text, numberInput.text);
        string jsonData = JsonUtility.ToJson(data);
        databaseReference.Child("UserData").Child("Users" + Random.Range(0,100000)).SetRawJsonValueAsync(jsonData);
        Debug.Log("data dent");
    }


     public void StartingPage()
	{
        if( string.IsNullOrEmpty( name.text ) || string.IsNullOrEmpty( number.text ) ){
            warning.gameObject.SetActive( true );
        }
        else{
         warning.gameObject.SetActive( false );
         Savedata();

		panel.SetActive(false);
        }
	}
    // Start is called before the first frame update
  
         

}//class
