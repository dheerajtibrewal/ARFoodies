using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanle : MonoBehaviour
{
    public GameObject MenuOrigPos;
    public GameObject MenuActPos;
    public GameObject MenuPanel;

    public bool Move_Menu_Panel;
    public bool Move_Menu_Panel_back;

    public float moveSpeed;
    public float tempMenuPos;
    bool button1 = true;
    
    // Start is called before the first frame update
    void Start()
    {
      MenuPanel.transform.position = MenuOrigPos.transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        if(Move_Menu_Panel)
        {
            MenuPanel.transform.position = Vector3.Lerp(MenuPanel.transform.position,MenuActPos.transform.position
            ,moveSpeed*Time.deltaTime);
            button1 = false;


            if(MenuPanel.transform.localPosition.x == tempMenuPos)
            {
                Move_Menu_Panel = false;
                MenuPanel.transform.position = MenuActPos.transform.position;
                tempMenuPos = -9999999.99f;
            }
            if(Move_Menu_Panel)
            {
                tempMenuPos = MenuPanel.transform.position.x;
            }
        }

        if(Move_Menu_Panel_back)
        {
            MenuPanel.transform.position = Vector3.Lerp(MenuPanel.transform.position,MenuOrigPos.transform.position
            ,moveSpeed*Time.deltaTime);

            if(MenuPanel.transform.localPosition.x == tempMenuPos)
            {
                Move_Menu_Panel_back = false;
                MenuPanel.transform.position = MenuOrigPos.transform.position;
                tempMenuPos = -9999999.99f;
            }
            if(Move_Menu_Panel)
            {
                tempMenuPos = MenuPanel.transform.position.x;
            }
        }
    }

    public void MovePanel(){
        Move_Menu_Panel_back = false;
        Move_Menu_Panel = true;

        if(button1 == false)
        {
            Move_Menu_Panel = false;
            Move_Menu_Panel_back = true; 
            button1 = true;
        }
    }
}
