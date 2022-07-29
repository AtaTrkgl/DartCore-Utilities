using UnityEngine;

namespace DartCore.Utilities
{
    public class GizmoUtilities
    {
        private const float INVERSE_SQRT_OF_TWO = 0.7071067811865475f;
        
        public static void DrawArrow2D(Vector2 origin, Vector2 tip, float arrowHeadLength)
        {
            var arrowDir = (Vector2) MathUtilities.Direction(origin, tip);
            var perpendicularArrowDir = (Vector2) Vector3.Cross(arrowDir, Vector3.forward).normalized;
            
            var tipMultiplier = arrowHeadLength * INVERSE_SQRT_OF_TWO;

            // Arrow Drawing
            Gizmos.DrawLine(origin,  tip);
            Gizmos.DrawLine(tip,  tip - (arrowDir + perpendicularArrowDir) * tipMultiplier);
            Gizmos.DrawLine(tip,  tip - (arrowDir - perpendicularArrowDir) *tipMultiplier);
        }
    }
}
