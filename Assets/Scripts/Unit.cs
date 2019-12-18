using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {
    GameObject highlight;

    public GameObject hoverPrefab;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void Highlight() {
        if(highlight == null) {
            Vector3 pos = transform.position;
            pos.y -= 0.3f;
            highlight =
                Instantiate(hoverPrefab,
                pos,
                Quaternion.identity) as GameObject;
           highlight.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        } else {
            highlight.SetActive(true);
        }
    }

    public void RemoveHighlight() {
        if(highlight == null)
            return;
        highlight.SetActive(false);
    }
}
