using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScoreCntroller : MonoBehaviour
{
   //初期のスコアを初期化
   int score = 0;
   
    
    
  

    //Scoreを表示するテキスト
     private GameObject ScoreText;

    // Start is called before the first frame update
    void Start()
    {
      
        //シーン中のScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("scoreText");

      score = 0; 
        
       

    }

    // Update is called once per frame
    void Update()
    {
      
    }

        //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
       //タグによって点数を変える
         if(other.gameObject.tag == "LargeSterTag")
        {
           score += 20;
         

        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 20 ;
            

        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
           score += 30 ;
           

        }

       this.ScoreText.GetComponent<Text> ().text = "Score:" + score;
       
       
    }

        
}
