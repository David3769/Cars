using UnityEngine;

[CreateAssetMenu(fileName = "Car", menuName = "Scriptable Objects/Car")]
public class Car : ScriptableObject
{
    public int Index;
    public int Price;
    public Sprite Sprite;
}
