using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Scriptable Objects/Player")]
public class PlayerScriptableObject : ScriptableObject
{
    public int Index;
    public int Price;
    public Sprite Sprite;
}
