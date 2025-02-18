using UnityEngine;
using PurrNet;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class Lobby: NetworkBehaviour
{
    public int plid;
    public Button[] but;
    public GameObject Camera_1;
    public GameObject Camera_2;
    public GameObject manaegre;
    void Update(){
        
    }
    public void manage1(){
        pill1();
    }
    public void ss2(){
        pill2();
    }
    public void starttt(){
        pil2();
        manaegre.SetActive(true);
    }
    [ServerRpc(requireOwnership:false)]
    public void pill1(){
        pil1();
    }
    public void pill2(){
        }
        [ObserversRpc]
    public void pil1(){
        but[0].interactable = false;
        but[1].interactable = true;
        but[2].interactable = true;
    }
    public void pil2(){
        Camera_1.SetActive(true);
        Camera_2.SetActive(false);
    }
    public void plidup(){
        plid = 1;
    }
    public void plidupd(){
        plid = 2;
    }
}