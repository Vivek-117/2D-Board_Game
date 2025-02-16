using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchInventory: MonoBehaviour
{
    public GameObject Camera_1;
    public GameObject Camera_2;
    public GameObject Camera_3;
    public EndTurn turn;

    void Start(){
        
    }

    public void ManageInventory()
    {
        if(turn.turn == 2)
        {
            Cam_2();
        }
        else
        {
            Cam_1();
        }
    }


    void Cam_1()
    {
        Camera_1.SetActive(true);
        Camera_3.SetActive(false);
    }

    void Cam_2()
    {
        Camera_2.SetActive(true);
        Camera_3.SetActive(false);   
    }

}