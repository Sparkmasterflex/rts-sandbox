using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Army : MonoBehaviour {
    public enum ArmyStance { Defender, Attacker };
    public ArmyStance armyStance;

    public UnitType[] units;

    void Start() {
        for(int i=0; i<units.Length; i++) {
            AddUnits(units[i]);
        }
    }

    // Update is called once per frame
    void Update() {

    }

    void AddUnits(UnitType unit) {
      for(int i=0; i<unit.count; i++) {
        float pos = unit.pos.x + (5*i);
        GameObject u =
            Instantiate(unit.type,
            new Vector3(pos, 0, unit.pos.z),
            Quaternion.identity) as GameObject;
      }

    }
}

[System.Serializable]
public struct UnitType {
    public GameObject type;
    public int count;
    public Vector3 pos;
}
