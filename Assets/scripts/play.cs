using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using PurrNet;
using UnityEngine.UI;



public class Tester : NetworkBehaviour
{

    public GameObject locali;
    public GameObject tet;
    public float speed=6000;
    void Update(){
        move(locali);
    }
    public void move(GameObject location){
        movee(location);
    }
    [ServerRpc(requireOwnership:false)]
    public void movee(GameObject location){
        tet.transform.position = Vector3.MoveTowards(tet.transform.position, location.transform.position, 1);
    }
    /*[ObserversRpc]
    public void moveee(GameObject location){
    tet.transform.position = Vector3.MoveTowards(tet.transform.position, location.transform.position, 1);
    }*/

}