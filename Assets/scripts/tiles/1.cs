using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PurrNet;
using UnityEngine.UI;

public class Tiel1 : NetworkBehaviour
{
    public Tiel t1;
    public Tiel t2;
    public EndTurn turn;
    public int pos1=1;
    public int pos2=1;
    public int movecount=1;
    public GameObject[] loc;
    public Button[] but;
    void Start(){
    }
    void Update(){

    }
    public void mm1(){
        m1();
    }
    public void mm2(){
        m2();
    }
    public void mm3(){
        m3();
    }
    public void mm4(){
        m4();
    }
    public void mm5(){
        m5();
    }
    public void mm6(){
        m6();
    }
    public void mm7(){
        m7();
    }
    public void mm8(){
        m8();
    }
    public void mm9(){
        m9();
    }
    public void mm10(){
        m10();
    }
    public void mm11(){
        m11();
    }
    public void mm12(){
        m12();
    }
    public void mm13(){
        m13();
    }
    public void mm14(){
        m14();
    }
    public void mm15(){
        m15();
    }
    public void mm16(){
        m16();
    }
    public void mm17(){
        m17();
    }
    public void mm18(){
        m18();
    }

    [ObserversRpc]
    public void m1(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==4){  
        t1.move(loc[0]);
        pos1=1;
        movecount=0;
        }}
        else if(pos2==4){
        t2.move(loc[0]);
        pos2=1;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m2(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==1||pos1==5){
        t1.move(loc[1]);
        pos1=2;
        movecount=0;
        }}
        else if(pos2==1||pos2==5){
        t2.move(loc[1]);
        pos2=2;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m3(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==7){
        t1.move(loc[2]);
        pos1=3;
        movecount=0;
        }}
        else if(pos2==7){
        t2.move(loc[2]);
        pos2=3;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m4(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==1||pos1==5||pos1==8){
        t1.move(loc[3]);
        pos1=4;
        movecount=0;
        }}
        else if(pos2==1||pos2==5||pos2==8){
        t2.move(loc[3]);
        pos2=4;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m5(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==2||pos1==6||pos1==8){
        t1.move(loc[4]);
        pos1=5;
        movecount=0;
        }}
        else if(pos2==2||pos2==6||pos2==8){
        t2.move(loc[4]);
        pos2=5;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m6(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==5||pos1==7||pos1==9){
        t1.move(loc[5]);
        pos1=6;
        movecount=0;
        }}
        else if(pos2==5||pos2==7||pos2==9){
        t2.move(loc[5]);
        pos2=6;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m7(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==3||pos1==6||pos1==10){
        t1.move(loc[6]);
        pos1=7;
        movecount=0;
        }}
        else if(pos2==3||pos2==6||pos2==10){
        t2.move(loc[6]);
        pos2=7;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m8(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==4||pos1==11||pos1==12){
        t1.move(loc[7]);
        pos1=8;
        movecount=0;
        }}
        else if(pos2==4||pos2==11||pos2==12){
        t2.move(loc[7]);
        pos2=8;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m9(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==5||pos1==6||pos1==10){
        t1.move(loc[8]);
        pos1=9;
        movecount=0;
        }}
        else if(pos2==5||pos2==6||pos2==10){
        t2.move(loc[8]);
        pos2=9;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m10(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==7||pos1==14){
        t1.move(loc[9]);
        pos1=10;
        movecount=0;
        }}
        else if(pos2==7||pos2==14){
        t2.move(loc[9]);
        pos2=10;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m11(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==8||pos1==12||pos1==15){
        t1.move(loc[10]);
        pos1=11;
        movecount=0;
        }}
        else if(pos2==8||pos2==12||pos2==15){
        t2.move(loc[10]);
        pos2=11;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m12(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==9||pos1==13){
        t1.move(loc[11]);
        pos1=12;
        movecount=0;
        }}
        else if(pos2==9||pos2==13){
        t2.move(loc[11]);
        pos2=12;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m13(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==12||pos1==14||pos1==17){
        t1.move(loc[12]);
        pos1=13;
        movecount=0;
        }}
        else if(pos2==12||pos2==14||pos2==17){
        t2.move(loc[12]);
        pos2=13;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m14(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==13||pos1==18){
        t1.move(loc[13]);
        pos1=14;
        movecount=0;
        }}
        else if(pos2==13||pos2==18){
        t2.move(loc[13]);
        pos2=14;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m15(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==11||pos1==16){
        t1.move(loc[14]);
        pos1=15;
        movecount=0;
        }}
        else if(pos2==11||pos2==16){
        t2.move(loc[14]);
        pos2=15;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m16(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==12||pos1==15){
        t1.move(loc[15]);
        pos1=16;
        movecount=0;
        }}
        else if(pos2==12||pos2==15){
        t2.move(loc[15]);
        pos2=16;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m17(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==13||pos1==16||pos1==18){
        t1.move(loc[16]);
        pos1=17;
        movecount=0;
        }}
        else if(pos2==13||pos2==16||pos2==18){
        t2.move(loc[16]);
        pos2=17;
        movecount=0;
        }
        }
    }
    [ObserversRpc]
    public void m18(){
        if(movecount==1){
        if(turn.turn==1){
        if(pos1==14||pos1==17){
        t1.move(loc[17]);
        pos1=18;
        movecount=0;
        }}
        else if(pos2==14||pos2==17){
        t2.move(loc[17]);
        pos2=18;
        movecount=0;
        }
        }
    }
}