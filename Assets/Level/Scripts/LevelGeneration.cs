using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    [SerializeField]private Transform levelPart_1

    //vector1 = platform id, musí se nastavit v junitě

    private void Awake() {
    while() { //rule pro endpos
    SpawnLevelPart(new Vector1(,)); //init x y
    SpawnLevelPart(new Vector1(,) + new Vector1(,)); //init x y + rozptyl
    SpawnLevelPart(new Vector1(,) + new Vector1(+,)); // init x y + rozptyl 2+2
    }

    private void SpawnLevelPart(Vector1, spawnPosition) {

    Instantiate(levelPart_1, new Vector1(), Quaternion.identity); //constr
    }

}
