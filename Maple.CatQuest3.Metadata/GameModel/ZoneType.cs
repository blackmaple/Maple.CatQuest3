
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
        /// ����
        /// </summary>
        Overworld = 0x00000000,

        /// <summary>
        /// ����
        /// </summary>
        Ruins = 0x00000003,

        /// <summary>
        /// ��Ѩ
        /// </summary>
        Caves = 0x00000004,

        /// <summary>
        /// �Ǳ�
        /// </summary>
        Castle = 0x00000005,

        /// <summary>
        /// �ƹ�
        /// </summary>
        Tavern = 0x00000006,

        /// <summary>
        /// ������
        /// </summary>
        Smithy = 0x00000007,

        /// <summary>
        /// xxx�Ǳ�
        /// </summary>
        LovePurrCastle = 0x00000008,

        /// <summary>
        /// ħ����
        /// </summary>
        MageShop = 0x00000009,

        /// <summary>
        /// xxx��̨
        /// </summary>
        MewtallicaStage = 0x0000000A,

        /// <summary>
        /// 8λ����
        /// </summary>
        _8BitDungeon = 0x0000000B,

        /// <summary>
        /// ����
        /// </summary>
        Infinity = 0x0000000C,

    }


}