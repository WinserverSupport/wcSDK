//***********************************************************************
// (c) Copyright 1998-2019 Santronics Software, Inc. All Rights Reserved.
//***********************************************************************
//
// File Name : wcMakeWildAPI.cs
// Subsystem : Wildcat! C# .NET SDK
// Version   : 8.0.454.8
// Author    : SSI
// About     : C# API for Wildcat! Configuration DLL (wcsmw.dll)
//
// Revision History:
// Build    Date      Author  Comments
// -----    --------  ------  -------------------------------------------
// 454.8    04/29/19  SSI     - Start of V8.0
//***********************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace wcSDK
{
	public static class wcMakeWildAPI
	{

	#region Credits ...

		// ------------------------------------------------------------------------
		// (c) Copyright 1998-2019 by Santronics Software Inc. All Rights Reserved.
		// Wildcat! SDK API v8.0.454.8
        //
        // CUSTOM/MANUALLY UPDATED
		// ------------------------------------------------------------------------

	#endregion

	#region Public WINServer MakeWild API Constants ...

		public const int MAX_PATH = 260;
        public const int SIZE_ENCODED_PASSWORD = 20;
        public const int SIZE_SHORT_FILE_NAME = 16;

        public const int srvFingerServer = 0X1;
		public const int srvWcxMwLogin = 0X2;
		public const int srvWcxIpCheck = 0X4;
		public const int srvOnlyLocalRPC = 0X8;

	#endregion

	#region Public WINServer MakeWild API Structures ...

		////! Group: Configuration Structures

		////!---------------------------------------------------------
		////! TConferencePaths provides the various directory setups
		////! per mail confeference
		////!---------------------------------------------------------
		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct TConferencePaths
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string Display;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string Bulletin;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string Help;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string Menu;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string Questionnaire;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string MsgDatabase;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string Attach;
		}

		////!---------------------------------------------------------
		////! TWildcatServerPrivateConfig is the configuration "MakeWild"
		////! structure. The public field is exposed to normal
		////! SDK clients.
		////!---------------------------------------------------------
		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct TWildcatServerPrivateConfig
		{
			public wcServerAPI.TMakewild mwPublic;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string FileDatabasePath;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string UserDatabasePath;
			public TConferencePaths DefaultConferencePaths;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=SIZE_ENCODED_PASSWORD)]
			public string SystemPassword;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=SIZE_ENCODED_PASSWORD)]
			public string MakewildPassword;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string LanguagePath;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string BatchFilePath;
			public int dwServerOptions;
		}

		////!---------------------------------------------------------
		////! TWildcatServerPrivateConfDesc defines a mail conference
		////! setup.
		////!---------------------------------------------------------
		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct TWildcatServerPrivateConfDesc
		{
			public wcServerAPI.TConfDesc tcdPublic;
			public TConferencePaths Paths;
		}

		////!---------------------------------------------------------
		////! TWildcatServerPrivateConfDesc defines a mail conference
		////! setup.
		////!---------------------------------------------------------
		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct TWildcatServerPrivateFileArea
		{
			public wcServerAPI.TFileArea tfaPublic;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string Path;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst=40)]
			public byte[] Reserved;
		}

		////!---------------------------------------------------------
		////! TWildcatServerPrivateFileVolumec provides CD volume
		////! setup information.
		////!---------------------------------------------------------
		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct TWildcatServerPrivateFileVolume
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=SIZE_SHORT_FILE_NAME)]
			public string Name;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=SIZE_SHORT_FILE_NAME)]
			public string VolumeLabel;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string UniqueFile;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=MAX_PATH)]
			public string Path;
			public int Offline;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst=84)]
			public byte[] Reserved;
		}

	#endregion

	#region Public WINServer MakeWild API DLL Imports ...

		////!----------------------------------------------------------------
		////! Group: Makewild Configuration
		////! MwLogin
		////! Login as the configuration client
		////! password  - configuration password, used "" if none. if a
		////!             password is required, you should prompt for the
		////!             password.
		////! returns TRUE if successful, otherwise see extended error
		////!----------------------------------------------------------------
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwLogin(string password);

		////!----------------------------------------------------------------
		////! Group: Makewild Configuration
		////! MwGetMakewild
		////! return the configuration structure TWildcatServerPrivateConfig
		////! mw - TWildcatServerPrivateConfig
		////! returns TRUE if successful, otherwise see extended error
		////! see also MwUpdateMakeWild
		////!----------------------------------------------------------------
		[DllImport("wcvb.dll", EntryPoint="vbMwGetMakewild", SetLastError=true)]
		public extern static bool MwGetMakewild(TWildcatServerPrivateConfig mw);

		////!----------------------------------------------------------------
		////! Group: Makewild Configuration
		////! MwUpdateMakewild
		////! Save the configuration structure TWildcatServerPrivateConfig
		////! mw - TWildcatServerPrivateConfig
		////! returns TRUE if successful, otherwise see extended error
		////! see also MwGetMakeWild
		////!----------------------------------------------------------------
		[DllImport("wcvb.dll", EntryPoint="vbMwUpdateMakewild", SetLastError=true)]
		public extern static bool MwUpdateMakewild(TWildcatServerPrivateConfig mw);

		////!----------------------------------------------------------------
		////! Group: Security Profile functions
		////!
		////! MwGetSecurityProfileCount    get number of security profiles
		////! MwGetSecurityProfileNames    get a string list of security names
		////! MwGetSecurityProfiles        get an array of TSecurityProfiles
		////! MwAddSecurityProfile         add a security profile
		////! MwUpdateSecurityProfile      update a security profile
		////! MwRemoveSecurityProfile      remote a security profile
		////!----------------------------------------------------------------
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static int MwGetSecurityProfileCount();
		[DllImport("wcvb.dll", EntryPoint="vbMwGetSecurityProfileNames", SetLastError=true)]
		public extern static object MwGetSecurityProfileNames(int index, int count);
		[DllImport("wcvb.dll", EntryPoint="vbMwGetSecurityProfiles", SetLastError=true)]
		public extern static bool MwGetSecurityProfiles(int index, int count, wcServerAPI.TSecurityProfile profile);
		[DllImport("wcvb.dll", EntryPoint="vbMwAddSecurityProfile", SetLastError=true)]
		public extern static bool MwAddSecurityProfile(wcServerAPI.TSecurityProfile profile, int index);
		[DllImport("wcvb.dll", EntryPoint="vbMwUpdateSecurityProfile", SetLastError=true)]
		public extern static bool MwUpdateSecurityProfile(int index, wcServerAPI.TSecurityProfile profile);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwRemoveSecurityProfile(int index);

		////!----------------------------------------------------------------
		////! Group: Security Access Profile functions
		////! The "Group" functions apply to the access profiles, NOT the
		////! security profiles.
		////!
		////! MwCreateGroup                create a new group
		////! MwRemoveGroup                remove a group
		////! MwCloneGroup                 clone a group and all its flags
		////! MwGetGroupCount              get the number of groups
		////! MwGetGroupNames              get the current group names (and
		////!                              indexes implicitly by position in
		////!                              array)
		////! MwGetObjectFlags             get the object's flags in group
		////! MwGetMultipleObjectFlags     get multiple object flags in group
		////! MwSetObjectFlags             sets the object's flags in a group (will
		////!                              add the object to the group file if
		////!                              it needs to, or remove it if flags == 0)
		////! MwSetMultipleObjectFlags     set multiple object flags in group
		////! MwGetObjectFlagsInGroups     get the flags for an object in each
		////!                              group, indexes are relative to the
		////!                              group names returned by MwGetGroupNames()
		////! MwSetObjectFlagsInGroups     set the flags for an object in each group
		////!----------------------------------------------------------------
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwCreateGroup(string groupname, int index);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwRemoveGroup(string groupname);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwCloneGroup(int sourcegroupindex, string newgroupname, int newgroupindex);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static int MwGetGroupCount();
		[DllImport("wcvb.dll", EntryPoint="vbMwGetGroupNames", SetLastError=true)]
		public extern static object MwGetGroupNames();
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static int MwGetObjectFlags(int groupindex, int objectid);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwGetMultipleObjectFlags(int groupindex, int objectid, int count, int flags);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwSetObjectFlags(int groupindex, int objectid, int flags);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwSetMultipleObjectFlags(int groupindex, int objectid, int flags, int count);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwGetObjectFlagsInGroups(int objectid, int flags);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwSetObjectFlagsInGroups(int objectid, int flags);

		////!----------------------------------------------------------------
		////! Group: Computers/Load Balancing
		////! The "Computer" functions apply to the "Computers" setup in
		////! wcconfig.exe.  This help load balance the system by distributing
		////! the wconline setup of the internet servers across various
		////! machines. The default is a blank computer name - index 0.
		////!----------------------------------------------------------------
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static int MwGetComputerConfigCount();
		[DllImport("wcvb.dll", EntryPoint="vbMwGetComputerConfigNames", SetLastError=true)]
		public extern static object MwGetComputerConfigNames(int index, int count);
		[DllImport("wcvb.dll", EntryPoint="vbMwGetComputerConfigs", SetLastError=true)]
		public extern static bool MwGetComputerConfigs(int index, int count, wcServerAPI.TComputerConfig cconfig);
		[DllImport("wcvb.dll", EntryPoint="vbMwAddComputerConfig", SetLastError=true)]
		public extern static bool MwAddComputerConfig(wcServerAPI.TComputerConfig ccoonfig, int index);
		[DllImport("wcvb.dll", EntryPoint="vbMwUpdateComputerConfig", SetLastError=true)]
		public extern static bool MwUpdateComputerConfig(int index, wcServerAPI.TComputerConfig cconfig);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwRemoveComputerConfig(int index);

		////!----------------------------------------------------------------
		////! Group: Mail Conference Setup
		////! Mail conference setup functions
		////!----------------------------------------------------------------
		[DllImport("wcvb.dll", EntryPoint="vbMwGetShortConfDescs", SetLastError=true)]
		public extern static bool MwGetShortConfDescs(int conference, int count, wcServerAPI.TShortConfDesc cd);
		[DllImport("wcvb.dll", EntryPoint="vbMwGetConfDescs", SetLastError=true)]
		public extern static bool MwGetConfDescs(int conference, int count, TWildcatServerPrivateConfDesc cd);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwSetConferenceCount(int count);
		[DllImport("wcvb.dll", EntryPoint="vbMwUpdateConfDesc", SetLastError=true)]
		public extern static bool MwUpdateConfDesc(int conference, TWildcatServerPrivateConfDesc cd);
		[DllImport("wcvb.dll", EntryPoint="vbMwGetConferenceGroups", SetLastError=true)]
		public extern static bool MwGetConferenceGroups(int group, int count, wcServerAPI.TConferenceGroup fg);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwSetConferenceGroupCount(int count);
		[DllImport("wcvb.dll", EntryPoint="vbMwUpdateConferenceGroup", SetLastError=true)]
		public extern static bool MwUpdateConferenceGroup(int group, wcServerAPI.TConferenceGroup cg);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwGetConferenceGroupBits(int group, int bytes, byte bits);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwSetConferenceGroupBits(int group, int bytes, byte bits);

		////!----------------------------------------------------------------
		////! Group: File Area Setup
		////! File Area setup functions
		////!----------------------------------------------------------------
		[DllImport("wcvb.dll", EntryPoint="vbMwGetShortFileAreas", SetLastError=true)]
		public extern static bool MwGetShortFileAreas(int area, int count, wcServerAPI.TShortFileArea fa);
		[DllImport("wcvb.dll", EntryPoint="vbMwGetFileAreas", SetLastError=true)]
		public extern static bool MwGetFileAreas(int area, int count, TWildcatServerPrivateFileArea fa);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwSetFileAreaCount(int count);
		[DllImport("wcvb.dll", EntryPoint="vbMwUpdateFileArea", SetLastError=true)]
		public extern static bool MwUpdateFileArea(int area, TWildcatServerPrivateFileArea fa);

		////!
		////! Group: File Area Group Setup
		////!
		[DllImport("wcvb.dll", EntryPoint="vbMwGetFileGroups", SetLastError=true)]
		public extern static bool MwGetFileGroups(int group, int count, wcServerAPI.TFileGroup fg);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwSetFileGroupCount(int count);
		[DllImport("wcvb.dll", EntryPoint="vbMwUpdateFileGroup", SetLastError=true)]
		public extern static bool MwUpdateFileGroup(int group, wcServerAPI.TFileGroup fg);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwGetFileGroupBits(int group, int bytes, byte bits);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwSetFileGroupBits(int group, int bytes, byte bits);

		////!
		////! Group: CD Volume Setup
		////!
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static int MwGetFileVolumeCount();
		[DllImport("wcvb.dll", EntryPoint="vbMwGetFileVolumeNames", SetLastError=true)]
		public extern static object MwGetFileVolumeNames(int index, int count);
		[DllImport("wcvb.dll", EntryPoint="vbMwGetFileVolumes", SetLastError=true)]
		public extern static bool MwGetFileVolumes(int index, int count, TWildcatServerPrivateFileVolume fv);
		[DllImport("wcvb.dll", EntryPoint="vbMwAddFileVolume", SetLastError=true)]
		public extern static bool MwAddFileVolume(TWildcatServerPrivateFileVolume fv, int index);
		[DllImport("wcvb.dll", EntryPoint="vbMwUpdateFileVolume", SetLastError=true)]
		public extern static bool MwUpdateFileVolume(int index, TWildcatServerPrivateFileVolume fv);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwRemoveFileVolume(int index);

		////!----------------------------------------------------------------
		////! Group: Door Setup
		////! Door setup functions
		////!----------------------------------------------------------------
		[DllImport("wcvb.dll", EntryPoint="vbMwGetDoorNames", SetLastError=true)]
		public extern static object MwGetDoorNames(int index, int count);
		[DllImport("wcvb.dll", EntryPoint="vbMwGetDoors", SetLastError=true)]
		public extern static bool MwGetDoors(int index, int count, wcServerAPI.TDoorInfo di);
		[DllImport("wcvb.dll", EntryPoint="vbMwAddDoor", SetLastError=true)]
		public extern static bool MwAddDoor(wcServerAPI.TDoorInfo di, int index);
		[DllImport("wcvb.dll", EntryPoint="vbMwUpdateDoor", SetLastError=true)]
		public extern static bool MwUpdateDoor(int index, wcServerAPI.TDoorInfo di);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwRemoveDoor(int index);

		////!----------------------------------------------------------------
		////! Group: Language Prompt Files Setup
		////! Language Setup functions
		////!----------------------------------------------------------------
		[DllImport("wcvb.dll", EntryPoint="vbMwGetLanguages", SetLastError=true)]
		public extern static bool MwGetLanguages(int index, int count, wcServerAPI.TLanguageInfo li);
		[DllImport("wcvb.dll", EntryPoint="vbMwAddLanguage", SetLastError=true)]
		public extern static bool MwAddLanguage(wcServerAPI.TLanguageInfo li, int index);
		[DllImport("wcvb.dll", EntryPoint="vbMwUpdateLanguage", SetLastError=true)]
		public extern static bool MwUpdateLanguage(int index, wcServerAPI.TLanguageInfo li);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwRemoveLanguage(int index);

		////!----------------------------------------------------------------
		////! Group: Modem Profiles Setup
		////! Modem Profiles setup functions
		////!----------------------------------------------------------------
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static int MwGetModemCount();
		[DllImport("wcvb.dll", EntryPoint="vbMwGetShortModemProfiles", SetLastError=true)]
		public extern static bool MwGetShortModemProfiles(int index, int count, wcServerAPI.TShortModemProfile mp);
		[DllImport("wcvb.dll", EntryPoint="vbMwGetModemProfile", SetLastError=true)]
		public extern static bool MwGetModemProfile(int index, wcServerAPI.TModemProfile mp);
		[DllImport("wcvb.dll", EntryPoint="vbMwAddModemProfile", SetLastError=true)]
		public extern static bool MwAddModemProfile(wcServerAPI.TModemProfile mp, int index);
		[DllImport("wcvb.dll", EntryPoint="vbMwUpdateModemProfile", SetLastError=true)]
		public extern static bool MwUpdateModemProfile(int index, wcServerAPI.TModemProfile mp);
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwRemoveModemProfile(int index);

		////!----------------------------------------------------------------
		////! Group: Node Configuration functions.
		////!----------------------------------------------------------------
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static int MwGetNodeConfigCount();
		[DllImport("wcvb.dll", EntryPoint="vbMwGetNodeConfigs", SetLastError=true)]
		public extern static bool MwGetNodeConfigs(int node, int count, wcServerAPI.TNodeConfig nc);
		[DllImport("wcvb.dll", EntryPoint="vbMwUpdateNodeConfig", SetLastError=true)]
		public extern static bool MwUpdateNodeConfig(int node, wcServerAPI.TNodeConfig nc);

		////!----------------------------------------------------------------
		////! Group: Miscellaneous
		////! Check for the existence of server path with
		////! optional create option
		////!----------------------------------------------------------------
		[DllImport("wcsmw.dll", SetLastError=true)]
		public extern static bool MwCheckPath(string path, int create);

	#endregion

	}

} //end of root namespace
