﻿using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {
	
	private static DontDestroy instance = null;
	public static DontDestroy Instance {
		get { return instance; }
	}
	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
	
	// any other methods you need
}