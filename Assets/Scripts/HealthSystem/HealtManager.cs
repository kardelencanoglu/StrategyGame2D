using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtManager : MonoBehaviour
{
    [SerializeField] GameObject healtBar;
    private void Update() {
        if (healtBar.transform.localScale.x <=0) {
            Destroy(gameObject);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Bullet") {
          //  Debug.Log("Temas1");
            if (gameObject.name.Equals("Hospital(Clone)")) {
                
                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.83f, healtBar.transform.localScale.y);
            }
            else if (gameObject.name.Equals("PowerPlants(Clone)")) {
                
                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 1f, healtBar.transform.localScale.y);
            }
            else if (gameObject.name.Equals("Barracks(Clone)")) {
               
                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.5f, healtBar.transform.localScale.y);
            }
            else if (gameObject.name.Equals("SoldierUnits(Clone)")) {
                
                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 2.5f, healtBar.transform.localScale.y);
            }

            else if (gameObject.tag.Equals("Soldier"))
            {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.07f, healtBar.transform.localScale.y);
            }

            else if (gameObject.tag.Equals("Soldier1")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.1f, healtBar.transform.localScale.y);
            }
            else if (gameObject.tag.Equals("Soldier2")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.05f, healtBar.transform.localScale.y);
            }
        
        }

        else if (collision.gameObject.tag == "Bullet1") {
            //Debug.Log("Temas2");
            if (gameObject.name.Equals("Hospital(Clone)")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.42f, healtBar.transform.localScale.y);
            }
            else if (gameObject.name.Equals("PowerPlants(Clone)")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.5f, healtBar.transform.localScale.y);
            }
            else if (gameObject.name.Equals("Barracks(Clone)")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.25f, healtBar.transform.localScale.y);
            }
            else if (gameObject.name.Equals("SoldierUnits(Clone)")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 1.25f, healtBar.transform.localScale.y);
            }


            else if (gameObject.tag.Equals("Soldier")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.7f, healtBar.transform.localScale.y);
            }

            else if (gameObject.tag.Equals("Soldier1"))
            {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.1f, healtBar.transform.localScale.y);
            }

            else if (gameObject.tag.Equals("Soldier2")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.05f, healtBar.transform.localScale.y);
            }
        }

        else if (collision.gameObject.tag == "Bullet2") {
           // Debug.Log("Temas3");
            if (gameObject.name.Equals("Hospital(Clone)")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.17f, healtBar.transform.localScale.y);
            }
            else if (gameObject.name.Equals("PowerPlants(Clone)")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.2f, healtBar.transform.localScale.y);
            }
            else if (gameObject.name.Equals("Barracks(Clone)")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.1f, healtBar.transform.localScale.y);
            }
            else if (gameObject.name.Equals("SoldierUnits(Clone)")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.5f, healtBar.transform.localScale.y);
            }

            else if (gameObject.tag.Equals("Soldier")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.1f, healtBar.transform.localScale.y);
            }
            else if (gameObject.tag.Equals("Soldier1")) {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.05f, healtBar.transform.localScale.y);
            }

            else if (gameObject.tag.Equals("Soldier2"))
            {

                healtBar.transform.localScale = new Vector3(healtBar.transform.localScale.x - 0.7f, healtBar.transform.localScale.y);
            }
        }
    }
}
