using UnityEngine;

public static class Vector2Extensions
{
    public static Vector2 Rotate(this Vector2 originalVector, float rotateAngleInDegrees)
    {
        //Gira un vector en cierto numero de grados
        Quaternion rotation = Quaternion.AngleAxis(rotateAngleInDegrees, Vector3.forward);
        return rotation * originalVector;
    }
}
