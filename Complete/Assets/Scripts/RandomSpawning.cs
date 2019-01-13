using UnityEngine;
using System.Collections;

public class RandomSpawning : MonoBehaviour {
	private bool[] positions;
	public GameObject[] obstacle;
	void Start () {
		positions = new bool[8];
		StartCoroutine(SpawnRow());
	}

	IEnumerator SpawnRow (){
		yield return new WaitForSeconds(0.1f);
		
		while(true){
			int emptyPosition = Random.Range(0, 8);
			for (int i = 0; i < 8; i++){
				if( i != emptyPosition) {
					Vector3 pos = new Vector3(2*i-7, 1, this.transform.position.z + 100);
					GameObject.Instantiate(obstacle[0], pos, Quaternion.identity);
				}
			}
			yield return new WaitForSeconds(1f);
		}
	}
}
