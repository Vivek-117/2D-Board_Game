using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiel : MonoBehaviour
{

    public GameObject locali;
    public float speed=6000;
    void Update(){
    }
    public void move(GameObject location){
    transform.position = Vector3.MoveTowards(transform.position, location.transform.position, speed);
    }

}