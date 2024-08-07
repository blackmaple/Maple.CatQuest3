
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
    /// ["ProjectStar".""."ZoneType"]
    /// </summary>
    public enum ZoneType : System.Int32
    { 

        /// <summary>
        /// 世界
        /// </summary>
        Overworld = 0x00000000,

        /// <summary>
        /// 废墟
        /// </summary>
        Ruins = 0x00000003,

        /// <summary>
        /// 洞穴
        /// </summary>
        Caves = 0x00000004,

        /// <summary>
        /// 城堡
        /// </summary>
        Castle = 0x00000005,

        /// <summary>
        /// 酒馆
        /// </summary>
        Tavern = 0x00000006,

        /// <summary>
        /// 铁匠铺
        /// </summary>
        Smithy = 0x00000007,

        /// <summary>
        /// xxx城堡
        /// </summary>
        LovePurrCastle = 0x00000008,

        /// <summary>
        /// 魔法店
        /// </summary>
        MageShop = 0x00000009,

        /// <summary>
        /// xxx舞台
        /// </summary>
        MewtallicaStage = 0x0000000A,

        /// <summary>
        /// 8位地牢
        /// </summary>
        _8BitDungeon = 0x0000000B,

        /// <summary>
        /// 无限
        /// </summary>
        Infinity = 0x0000000C,

    }


}