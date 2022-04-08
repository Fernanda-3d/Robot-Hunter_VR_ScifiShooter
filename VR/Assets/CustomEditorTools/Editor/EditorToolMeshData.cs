using UnityEditor;
using UnityEngine;

public class EditorToolMeshData : EditorWindow
{
    private int totalVertexCount = 0;
    private int totalTriangleCount = 0;
    private int inactiveVertexCount = 0;
    private int inactiveTriangleCount = 0;
    private int activeVerterxCount = 0;
    private int activeTriangleCount = 0;
    [MenuItem("JJTools/Scene mesh data v0.1")]
    public static void ShowWindow()
    {
        GetWindow(typeof(EditorToolMeshData));
    }

    private void ResetData()
    {
        totalVertexCount = 0;
        totalTriangleCount = 0;
        inactiveVertexCount = 0;
        inactiveTriangleCount = 0;
        activeVerterxCount = 0;
        activeTriangleCount = 0;      
    }

    private void CountAll()
    {
        MeshFilter[] meshFilters = GameObject.FindObjectsOfType<MeshFilter>(true);
        ResetData();
        int vertexCount = 0;
        int triangleCount = 0;
        foreach(var filter in meshFilters){
            if(filter.sharedMesh == null){
               continue;
            }
            vertexCount = filter.sharedMesh.vertexCount;
            triangleCount = filter.sharedMesh.triangles.Length / 3;
            totalVertexCount += vertexCount;
            totalTriangleCount += triangleCount;
            if(!filter.gameObject.activeInHierarchy){
                inactiveVertexCount += vertexCount;
                inactiveTriangleCount += triangleCount;    
            }  
        }
        activeTriangleCount = totalTriangleCount - inactiveTriangleCount;
        activeVerterxCount = totalVertexCount - inactiveVertexCount;
        Repaint();
    }


    private void OnGUI() 
    {
        GUILayout.Label("Mesh data");
        GUILayout.Label("Total vertex count: "+totalVertexCount);
        GUILayout.Label("Total triangle count: "+totalTriangleCount);
        GUILayout.Label("Inactive vertex count: "+inactiveVertexCount);
        GUILayout.Label("Inactive triangle count: "+inactiveTriangleCount);
        GUILayout.Label("Active vertex count: "+activeVerterxCount);
        GUILayout.Label("Active triangle count: "+activeTriangleCount);   

        if(GUILayout.Button("Count vertices and polygons")){
            CountAll();
        }
    }
    
}
