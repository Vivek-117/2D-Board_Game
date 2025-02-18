using UnityEngine;
using PurrNet;
using UnityEngine.UI;
using TMPro;

public class EndTurn: NetworkBehaviour
{
    public int turn=1;
    public TextMeshProUGUI text;
    public Tiel1 tiel1;
    public GameObject button;
    public Lobby lob;
    public int tur = 1;
    public int pid;
    public void Start(){
        text.text = ("Player: "+turn).ToString();
        pid = lob.plid;
        vst();
    }
    public void Endturn(){
        text.text = ("Player: "+turn).ToString();
        et();
    }
    void Update(){
        butact();
        vst();
    }
    [ObserversRpc]
    public void butact(){
       if (tur == turn)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        } 
    }
    [ObserversRpc]
    public void et(){
        if(tiel1.movecount==0){
        if(turn == 1){
            turn = 2;
        }
        else{
            turn = 1;
        }
        tiel1.movecount = 1;
    }
    }

    public void vst(){
        if(1==pid)
        tur=1;
        else
        tur=2;
    }        

}
