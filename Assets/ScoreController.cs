using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	//スコアを表示するテキスト
	private GameObject scoreText;

	//スコア計算用変数
	private int score = 0;

	// Use this for initialization
	void Start () {

		//初期スコアを代入
		score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//OnCollisionEnter関数を呼び出す
		OnCollisionEnter();

		//ScoreTextにスコアを表示
		this.scoreText.GetComponent<Text> ().text = "Score:" + score;
		
	}
		
	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision col) {

		//変数colTagを宣言
		string colTag = col.gameObject.tag;

		if (colTag == "SmallStarTag") {
			score += 5;

		} else if (colTag == "LargeStarTag") {
			score += 20;

		} else if (colTag == "SmallCloudTag") {
			score += 25;

		} else if (colTag == "LargeCloudtag") {
			score += 50;
		}
	}		
}
