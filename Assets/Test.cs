using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Magic()
    {
        hp -= mp;
        if(mp >= 5){
            mp -= 5;

            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        } else{
            Debug.Log("MPが足りないため魔法が使えない");
        }
    }

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        hp -= damage;
    }
}

public class Test : MonoBehaviour{


       
        


    // Use this for initialization
    void Start(){
        int[] array = { 2, 4, 6, 8, 10 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }



        for(int p = 4;p >= 0;p--)
        {
            Debug.Log(array[p]);
        }



        Boss MagicAttack = new Boss(); 

        for(int q = 1;q <=10;q++)
        {
            MagicAttack.Magic();
        }

        MagicAttack.Magic();
      


        
    }

        
        
              
     
    

    // Update is called once per frame
    void Update(){

    }

}
