using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float speed = 5f;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Vector2 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            Vector2 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }


        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) {
            Vector2 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }

    }
}
