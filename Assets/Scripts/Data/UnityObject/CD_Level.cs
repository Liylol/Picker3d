using System.Collections.Generic;
using Data.ValueObjects;
using UnityEngine;

//attributes
namespace Data.UnityObject
{
    [CreateAssetMenu(fileName = "CD_Level", menuName = "Picker3D/CDLevel", order = 1)]
    public class CD_Level : ScriptableObject
    {
        public List<LevelData> Levels = new List<LevelData>();
    }
}
