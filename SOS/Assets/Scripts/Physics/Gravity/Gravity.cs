using UnityEngine;

public static class Gravity {

    public static Vector2 gravityDirection = Vector2.down;
    /* Dans quelle direction va s'appliquer la gravité
     * Sera toujours normalisée afin de permettre de garder une gravité uniforme dans n'importe quelle direction
     */
    
    public static float gravityAmplitude = 9.81f;
    /* La force de gravité appliquée sur le joueur (de base, 9.81f)
     * La gravité appliquée sera gravityDirection.normalized * gravityAmplitude
     */

    public enum GravityOrientation { Down, Right, Up, Left, Free };
    public static GravityOrientation gravityOrientation;
    /* Nous permettra de changer l'orientation de gravityDirection
     * "Free" nous permettra d'assigner la valeur de gravityDirection comme on le souhaitera
     */

    public enum GravityInterpolation { Immediate, Lerp, Slerp, Custom };
    public static GravityInterpolation gravityInterpolation;
    /* Nous permettra de modifier la transition d'un changement de gravité à un autre
     * "Custom" nous permettra d'assigner une AnimationCurve ou autre facteur de transition pour avoir la transition souhaitée
     */


}
