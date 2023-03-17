using CodeMonkey.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitRTS : MonoBehaviour
{

    public GameObject selectedGameObject;
    private IMovePosition movePosition;
    public Animator anim;
    public float rotationSpeed = 180;
    [SerializeField]Transform characterTransform;
    private Vector3 mousePosition;

    private void Start() {
       anim = GetComponent<Animator>();  
    }
    
    private void Awake()
    {
        selectedGameObject = transform.Find("Selected").gameObject;
        movePosition = GetComponent<IMovePosition>();
        SetSelectedVisible(false);
    }
    private void Update() {
        mousePosition = UtilsClass.GetMouseWorldPosition();
    }

    public void SetSelectedVisible(bool visible)
    {
        if (selectedGameObject != null) {
            selectedGameObject.SetActive(visible);
        }
       
    }

    public void MoveTo(Vector3 targetPosition) {

        if (targetPosition.y <= 90) {

        }
      
        anim.SetBool("isRun", true);
   
        movePosition.SetMovePosition(targetPosition);

        Vector3 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 lookAt = mouseScreenPosition;

        float AngleRad = Mathf.Atan2(lookAt.y - this.transform.position.y, lookAt.x - this.transform.position.x);

        float AngleDeg = (180 / Mathf.PI) * AngleRad;
        if (AngleDeg >=90) {
            AngleDeg = 180;
        }
        else {
            AngleDeg = 0;
        }
        this.transform.rotation = Quaternion.Euler(0, AngleDeg, 0);


    }

}
