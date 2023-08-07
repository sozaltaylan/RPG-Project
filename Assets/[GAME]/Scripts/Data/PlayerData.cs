using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Player")]
public class PlayerSO : ScriptableObject
{
    public float speed;
    public float angularSpeed;
}
