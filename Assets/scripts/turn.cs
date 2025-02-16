using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndTurn: MonoBehaviour
{
    public int turn=1;
    public TextMeshProUGUI text;
    public Tiel1 tiel1;
    public void Start(){
        text.text = ("Player: 1").ToString();
    }
    public void Endturn(){
        if(tiel1.movecount==0){
        if(turn == 1){
            turn = 2;
        }
        else{
            turn = 1;
        }
        tiel1.movecount = 1;
        text.text = ("Player: "+turn).ToString();
        }
    }
}
