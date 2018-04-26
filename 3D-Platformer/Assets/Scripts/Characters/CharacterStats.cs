using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour {

	[Range(0, 10)] public float health = 5;
	public int faction;
	public int gemCount;
	public Text gemText;
	public Text hpText;

	// Use this for initialization
	void Start () {
		updateGems ();
		updateHealth ();
	}

	// Update is called once per frame
	void Update () {
		health = Mathf.Clamp (health, 0, 5);
		updateGems ();
		updateHealth ();
	}

	void updateGems() {
		gemText.text = "Gems: " + gemCount.ToString();
	}

	void updateHealth() {
		hpText.text = "Health: " + health.ToString();
	}

}
