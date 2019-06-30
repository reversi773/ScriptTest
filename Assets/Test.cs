using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    int mp = 53; //マジックポイント
    

    //魔法攻撃用の関数
    public void Magic(int lostpoints)
    {    
        if (mp >= 5)
        {//mpが5以上の時
            //残りmpを減らす
            this.mp -= lostpoints;
            Debug.Log("魔法攻撃をした。残りMPは" + mp　+"。");
        }
        else
        {//mpが5未満のとき
            Debug.Log("MPが足りないため魔法が使えない。");
        }
     }
}


public class Test : MonoBehaviour
    {
    //Use this for initialization
    void Start()
    {
        //配列を初期化する
        int[] array= { 30, 20, 50, 10, 80};
        //配列の要素のぶんだけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
         Debug.Log(array[i]);
        //配列の要素を逆順に表示
        for (int a = array.Length - 1; 0 <= a;  a--)
　　　　Debug.Log(array[a]);

        
        //Bossクラスの変数を宣言してインスタンスを代入
            Boss lastboss = new Boss();
        for (int i = 0; i < 11; i++) 
        
            //魔法攻撃用の関数を呼び出す
            lastboss.Magic(5);
        

    }

    // Update is called once per frame
    void Update() {
       
    }
}
