
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.CatQuest3
{
    
    
    /// <summary>
    /// ["ProjectStar".""."MapIconType"]
    /// </summary>
    public enum MapIconType : System.Int32
    { 

        
        Player1 = 0x00000001,

        Player2 = 0x00000002,

        Dungeon = 0x00000004,

        SaveParrot = 0x00000008,

        DockSummon = 0x00000010,

        DockRepair = 0x00000020,

        MainQuestCheckpoint = 0x00000040,

        Marker = 0x00000080,

        MapRegionInfo = 0x00000100,

        Tavern = 0x00000200,

        KiddShop = 0x00000400,

        Chest = 0x00000800,

        PlayerShip = 0x00001000,

        SideQuestCheckpoint = 0x00002000,

        MageShop = 0x00004000,

    }


}