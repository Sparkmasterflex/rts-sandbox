using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour {
    public Army playerArmy;
    public Army aiArmy;

    Camera m_MainCamera;

    // Start is called before the first frame update
    void Start() {
        m_MainCamera = Camera.main;
        m_MainCamera.transform.position = new Vector3(100, 8, 20);
    }

    // Update is called once per frame
    void Update() {

    }
}
