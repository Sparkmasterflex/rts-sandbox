using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour {
    public GameObject selectedObject;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );

        RaycastHit hitInfo;

        if(Physics.Raycast(ray, out hitInfo)) {
            GameObject hitObject = hitInfo.transform.root.gameObject;

            if(Input.GetMouseButtonDown(0)) {
                SelectObject(hitObject);
            }
        } else {
            if(Input.GetMouseButtonDown(0)) {
                ClearSelection();
            }
        }
    }

    void SelectObject(GameObject obj) {
        if(selectedObject != null) {
            if(obj == selectedObject)
                return;
            ClearSelection();
        }

        if(obj.tag == "Unit") {
            selectedObject = obj;
            Unit unit = GetUnit();
            if(unit != null)
              unit.Highlight();
        }
    }

    void ClearSelection() {
        if(selectedObject == null)
            return;

        Unit unit = GetUnit();
        if(unit != null)
          unit.RemoveHighlight();
        selectedObject = null;
    }

    Unit GetUnit() {
        if(selectedObject == null)
            return null;
        return selectedObject.GetComponent<Unit>();
    }
}
