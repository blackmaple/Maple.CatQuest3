
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.CatQuest3
{


    /// <summary>
    /// static class ["ProjectStar"."ProjectStar.Localization"."LocalizationTools"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000A5AU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114, 46, 76, 111, 99, 97, 108, 105, 122, 97, 116, 105, 111, 110], [76, 111, 99, 97, 108, 105, 122, 97, 116, 105, 111, 110, 84, 111, 111, 108, 115])]

    //  class static System.String[] languagesRTL
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"languagesRTL", "LANGUAGES_RTL", true)]

    //  class static System.String[] latinLanguages
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"latinLanguages", "LATIN_LANGUAGES", true)]

    //  class static System.String noTranslateMsg
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"noTranslateMsg", "NO_TRANSLATE_MSG", true)]

    //  class static System.Collections.Generic.Dictionary<UnityEngine.Localization.Tables.TableReference,UnityEngine.Localization.Tables.StringTable> localizationTable
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"localizationTable", "LOCALIZATION_TABLE", true)]

    public partial class LocalizationTools
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "ProjectStar.Localization";
        //public static byte[] Static_Namespace { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114, 46, 76, 111, 99, 97, 108, 105, 122, 97, 116, 105, 111, 110];

        //public const string Const_ClassName = "LocalizationTools";
        //public static byte[] Static_ClassName { get; } = [76, 111, 99, 97, 108, 105, 122, 97, 116, 105, 111, 110, 84, 111, 111, 108, 115];

        //public const uint Const_TypeToken = 0x02000A5AU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_LocalizationTools(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_LocalizationTools(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_LocalizationTools obj) => obj._ptr;
            public static implicit operator bool(Ptr_LocalizationTools obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar"."ProjectStar.Localization"."LocalizationTools"]
    /// </summary>
    public partial class LocalizationTools
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        /// static  System.String ApplyRTLFix(System.String text)
        /// </summary>
        /// <param name="text">class System.String</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyRTLFix")]
        /// static extern nint APPLY_RTL_FIX (nint text);


        /// <summary>
        /// static  System.Void CacheLocalizationStringTables()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CacheLocalizationStringTables")]
        /// static extern void CACHE_LOCALIZATION_STRING_TABLES ();


        /// <summary>
        /// static  System.Collections.Generic.IList<UnityEngine.Localization.Locale> get_availableLangaugeLocales()
        /// </summary>
        /// <returns>interface System.Collections.Generic.IList<UnityEngine.Localization.Locale></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_availableLangaugeLocales")]
        /// static extern nint GET_AVAILABLE_LANGAUGE_LOCALES ();


        /// <summary>
        /// static  UnityEngine.Localization.Locale get_defaultLanguage()
        /// </summary>
        /// <returns>class UnityEngine.Localization.Locale</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_defaultLanguage")]
        /// static extern nint GET_DEFAULT_LANGUAGE ();


        /// <summary>
        /// static  UnityEngine.Localization.Locale get_locale()
        /// </summary>
        /// <returns>class UnityEngine.Localization.Locale</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_locale")]
        /// static extern nint GET_LOCALE ();


        /// <summary>
        /// static  System.Void InitStaticFields()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitStaticFields")]
        /// static extern void INIT_STATIC_FIELDS ();


        /// <summary>
        /// static  System.Boolean IsCurrentLangaugeRTL()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCurrentLangaugeRTL")]
        /// static extern System.Boolean IS_CURRENT_LANGAUGE_RTL ();


        /// <summary>
        /// static  System.Boolean IsLatinLanguage(UnityEngine.Localization.LocaleIdentifier localeIdentifier)
        /// </summary>
        /// <param name="localeIdentifier">struct UnityEngine.Localization.LocaleIdentifier</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsLatinLanguage")]
        /// static extern System.Boolean IS_LATIN_LANGUAGE (UnityEngine.Localization.LocaleIdentifier localeIdentifier);


        /// <summary>
        /// static  System.Boolean IsLocalizationInitializationComplete()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsLocalizationInitializationComplete")]
        /// static extern System.Boolean IS_LOCALIZATION_INITIALIZATION_COMPLETE ();


        /// <summary>
        /// static  UnityEngine.Localization.Tables.AssetTable RetrieveAssetTable(UnityEngine.Localization.Tables.TableReference tableRef)
        /// </summary>
        /// <param name="tableRef">struct UnityEngine.Localization.Tables.TableReference</param>
        /// <returns>class UnityEngine.Localization.Tables.AssetTable</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RetrieveAssetTable")]
        /// static extern nint RETRIEVE_ASSET_TABLE (UnityEngine.Localization.Tables.TableReference tableRef);


        /// <summary>
        /// static  TAsset RetrieveAssetValueFromTable(UnityEngine.Localization.Tables.TableReference table, UnityEngine.Localization.Tables.TableEntryReference entry)
        /// </summary>
        /// <param name="table">struct UnityEngine.Localization.Tables.TableReference</param>
        /// <param name="entry">struct UnityEngine.Localization.Tables.TableEntryReference</param>
        /// <returns>class TAsset</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RetrieveAssetValueFromTable")]
        /// static extern nint RETRIEVE_ASSET_VALUE_FROM_TABLE (UnityEngine.Localization.Tables.TableReference table, UnityEngine.Localization.Tables.TableEntryReference entry);


        /// <summary>
        /// static  UnityEngine.Localization.Tables.StringTable RetrieveStringTable(UnityEngine.Localization.Tables.TableReference tableRef)
        /// </summary>
        /// <param name="tableRef">struct UnityEngine.Localization.Tables.TableReference</param>
        /// <returns>class UnityEngine.Localization.Tables.StringTable</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RetrieveStringTable")]
        /// static extern nint RETRIEVE_STRING_TABLE (UnityEngine.Localization.Tables.TableReference tableRef);


        /// <summary>
        /// static  System.Boolean RetrieveStringValueFromTable(UnityEngine.Localization.Tables.TableReference table, UnityEngine.Localization.Tables.TableEntryReference entry, System.String& localizedString)
        /// </summary>
        /// <param name="table">struct UnityEngine.Localization.Tables.TableReference</param>
        /// <param name="entry">struct UnityEngine.Localization.Tables.TableEntryReference</param>
        /// <param name="localizedString">class System.String&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RetrieveStringValueFromTable")]
        /// static extern System.Boolean RETRIEVE_STRING_VALUE_FROM_TABLE (UnityEngine.Localization.Tables.TableReference table, UnityEngine.Localization.Tables.TableEntryReference entry, nint localizedString);


        /// <summary>
        /// static  System.ValueTuple<UnityEngine.Localization.Tables.TableReference,UnityEngine.Localization.Tables.TableEntryReference> RetrieveTranslateID(System.String translateID)
        /// </summary>
        /// <param name="translateID">class System.String</param>
        /// <returns>struct System.ValueTuple<UnityEngine.Localization.Tables.TableReference,UnityEngine.Localization.Tables.TableEntryReference></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RetrieveTranslateID")]
        /// static extern System.ValueTuple<UnityEngine.Localization.Tables.TableReference,UnityEngine.Localization.Tables.TableEntryReference> RETRIEVE_TRANSLATE_ID (nint translateID);


        /// <summary>
        /// static  System.String ReverseText(System.String text)
        /// </summary>
        /// <param name="text">class System.String</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReverseText")]
        /// static extern nint REVERSE_TEXT (nint text);


        /// <summary>
        /// static  System.Void set_availableLangaugeLocales(System.Collections.Generic.IList<UnityEngine.Localization.Locale> value)
        /// </summary>
        /// <param name="value">interface System.Collections.Generic.IList<UnityEngine.Localization.Locale></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_availableLangaugeLocales")]
        /// static extern void SET_AVAILABLE_LANGAUGE_LOCALES (nint value);


        /// <summary>
        /// static  System.Void set_defaultLanguage(UnityEngine.Localization.Locale value)
        /// </summary>
        /// <param name="value">class UnityEngine.Localization.Locale</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_defaultLanguage")]
        /// static extern void SET_DEFAULT_LANGUAGE (nint value);


        /// <summary>
        /// static  System.Void set_locale(UnityEngine.Localization.Locale value)
        /// </summary>
        /// <param name="value">class UnityEngine.Localization.Locale</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_locale")]
        /// static extern void SET_LOCALE (nint value);



        /// <summary>
        /// static  System.String TranslateOrDefault(System.String term, System.String content)
        /// </summary>
        /// <param name="term">class System.String</param>
        /// <param name="content">class System.String</param>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TranslateOrDefault", CallConvs = [typeof(CallConvCdecl)], Search = typeof(Search_LocalizationTools))]
        static extern PMonoString TRANSLATE_OR_DEFAULT_00(nint term, nint content);


        /// <summary>
        /// static  System.String TranslateOrDefault(ScriptLocalizedTerms term, System.String content)
        /// </summary>
        /// <param name="term">enum ScriptLocalizedTerms</param>
        /// <param name="content">class System.String</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TranslateOrDefault", Search = typeof(Search_LocalizationTools))]
        /// static extern nint TRANSLATE_OR_DEFAULT_01 (ScriptLocalizedTerms term, nint content);


        /// <summary>
        /// static  System.String TranslateOrDefault(UnityEngine.Localization.Tables.TableReference table, UnityEngine.Localization.Tables.TableEntryReference term, System.String content)
        /// </summary>
        /// <param name="table">struct UnityEngine.Localization.Tables.TableReference</param>
        /// <param name="term">struct UnityEngine.Localization.Tables.TableEntryReference</param>
        /// <param name="content">class System.String</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TranslateOrDefault", Search = typeof(Search_LocalizationTools))]
        /// static extern nint TRANSLATE_OR_DEFAULT_02 (UnityEngine.Localization.Tables.TableReference table, UnityEngine.Localization.Tables.TableEntryReference term, nint content);


        public static partial class Search_LocalizationTools
        {
            /// 
            ///     

            /// <summary>
            /// static  System.String TranslateOrDefault(System.String term, System.String content)
            /// </summary>
            public static bool TRANSLATE_OR_DEFAULT_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TranslateOrDefault", "System.String", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.String TranslateOrDefault(ScriptLocalizedTerms term, System.String content)
            /// </summary>
            /// public static bool TRANSLATE_OR_DEFAULT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TranslateOrDefault", "ScriptLocalizedTerms", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.String TranslateOrDefault(UnityEngine.Localization.Tables.TableReference table, UnityEngine.Localization.Tables.TableEntryReference term, System.String content)
            /// </summary>
            /// public static bool TRANSLATE_OR_DEFAULT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TranslateOrDefault", "UnityEngine.Localization.Tables.TableReference", "UnityEngine.Localization.Tables.TableEntryReference", "System.String");
            ///     
            ///  
            /// 
            /// 
        }

    }


}