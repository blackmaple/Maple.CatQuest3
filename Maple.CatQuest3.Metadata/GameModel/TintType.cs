
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
    /// ["ProjectStar".""."TintType"]
    /// </summary>
    public enum TintType : System.Int32
    { 

        
        NORMAL = 0x00000000,

        FLASH = 0x00000001,

        FLASH_HIT = 0x00000002,

        PULSE = 0x00000003,

        FLASH_DARK = 0x00000004,

        SHIP_DEATH = 0x00000005,

        RESET = 0x00000006,

        RESET_IMMEDIATE = 0x00000007,

        REMOVE = 0x00000008,

        FLASH_AND_FADE_OUT = 0x00000009,

    }


}