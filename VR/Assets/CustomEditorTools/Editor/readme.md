# Mesh data editor tool
## Intented usage
Tool will scan a open scene for meshFilter components.
From meshFilter- components, vertices and polygons are calculated.
Main problem this solves is getting the total count of above mentioned from the objects in the scene.

## Usage
* From the top menu bar in Unity, select JJTools->Scene mesh data
* From the opened window, click 'Count vertices and polygons' Note that tool does not autorefres, buttonclick is needed for fresh calculation.
Inactive count shows total count for gameobjects that have been disabled and active for enabled gameobjects.
Total count is the sum of these.

## Tool maturity
version 0.1 is a poorly tested and includes only core functionality.

## Future ideas
* Breakdown of totalcount. This might be a nodebased tree too but sheet with columns for mesh- name, total instances of given mesh and mesh data might suffice
* Export breakdown to .csv
* Links to mesh- objects for detailed info