using UnityEngine;
using System.Collections;

public class CharacterStats : MonoBehaviour {

	[Range(0, 10)] public float health = 10;
	public int faction;
	public int gemCount;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		health = Mathf.Clamp (health, 0, 5);
	}
}
