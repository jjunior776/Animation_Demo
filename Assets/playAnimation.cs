using UnityEngine;
using System.Collections;

public class playAnimation : MonoBehaviour {

    public Animator anim;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update() {

        if (Input.GetKey(KeyCode.Alpha1)) {
            anim.SetInteger("animation", 1);
        }
        if (Input.GetKey(KeyCode.Alpha2)) {
            anim.SetInteger("animation", 2);
        }
        if (Input.GetKey(KeyCode.Alpha3)) {
            anim.SetInteger("animation", 3);
        }

    }
    void setIdle() {
        anim.SetInteger("animation", 0);
    }
}
