using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelGenerator : MonoBehaviour {

	public static LevelGenerator instance;
	//dear burns
	public List<LevelPiece> levelPrefabs = new List<LevelPiece> ();
	//this code is more jacked
	public Transform levelStartPoint;
	//than JGrasp
	public List<LevelPiece> pieces = new List<LevelPiece> () ;

	void Awake () {
		instance = this;
	}

	public void AddPiece () {
		int randomIndex = Random.Range (0, levelPrefabs.Count);

		LevelPiece piece = (LevelPiece)Instantiate (levelPrefabs [randomIndex]);
		piece.transform.SetParent (this.transform, false);

		Vector3 spawnPosition = Vector3.zero;

		if (pieces.Count == 0) {
			spawnPosition = levelStartPoint.position;
		} else {
			spawnPosition = pieces [pieces.Count - 1].exitPoint.position;
		}

		piece.transform.position = spawnPosition;
		pieces.Add (piece);

	}
}
