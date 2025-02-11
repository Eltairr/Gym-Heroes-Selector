using UnityEngine;

public class MuscleGrowthController : MonoBehaviour
{
    public SkinnedMeshRenderer characterMesh; 

    private float chestGrowth = 0f;

void Update()
{
    // Detect touchscreen or mouse input
    if (Input.GetMouseButtonDown(0)) 
    {
        chestGrowth = Mathf.Clamp(chestGrowth + 5f, 0f, 100f);
        ApplyMuscleGrowth();
    }
}


    void ApplyMuscleGrowth()
    {
        int chestIndex = characterMesh.sharedMesh.GetBlendShapeIndex("core max"); 
        if (chestIndex != -1)
        {
            characterMesh.SetBlendShapeWeight(chestIndex, chestGrowth);
        }
    }
}
