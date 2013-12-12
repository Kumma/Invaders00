using UnityEngine;
using System.Collections;

public class DestroyOnInvinsible : MonoBehaviour {
	void OnBecameInvisible () {
		Destroy (gameObject);
	}
}
