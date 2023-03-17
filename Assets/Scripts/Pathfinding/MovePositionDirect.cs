using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePositionDirect : MonoBehaviour, IMovePosition {

    private Vector3 movePosition;
    public Animator anim;

    private void Awake() {
        movePosition = transform.position;
        anim = GetComponent<Animator>();
    }

    public void SetMovePosition(Vector3 movePosition) {
        this.movePosition = movePosition;
    }

    private void Update() {
        Vector3 moveDir = (movePosition - transform.position).normalized;
        if (Vector3.Distance(movePosition, transform.position) < 1f) {
            moveDir = Vector3.zero;
            anim.SetBool("isRun", false);
        } // Stop moving when near
        GetComponent<IMoveVelocity>().SetVelocity(moveDir);
        


    }

}
