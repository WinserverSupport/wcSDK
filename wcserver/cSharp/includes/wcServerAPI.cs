//***********************************************************************
// (c) Copyright 1998-2024 Santronics Software, Inc. All Rights Reserved.
//***********************************************************************
//
// File Name : wcServerAPI.cs
// Subsystem : Wildcat! C# .NET SDK
// Version   : 8.0.454.12
// Author    : SSI
// About     : Sourced for wcserverAPI.DLL
//
// CUSTOM/MANUALLY UPDATED
//
// Revision History:
// Build    Date      Author  Comments
// -----    --------  ------  -------------------------------------------
// 454.8    04/29/19  SSI     - Start of V8.0
// 454.10   04/16/20  SSI     - Recompile
// 454.12   05/15/21  HLS     - Updated to match wcserver.h/wctype.h
//***********************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace wcSDK
{
    public class wcServerAPI
    {

        #region Public Windows Structures ...

        public struct FileTime
        {
            public int dwLowDateTime;
            public int dwHighDateTime;
        }

        public struct DateTime
        {
            public int dwLowDateTime;
            public int dwHighDateTime;
        }

        public struct SYSTEMTIME
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct WIN32_FIND_DATA
        {
            public int dwFileAttributes;
            public FileTime ftCreationTime;
            public FileTime ftLastAccessTime;
            public FileTime ftLastWriteTime;
            public int nFileSizeHigh;
            public int nFileSizeLow;
            public int dwReserved0;
            public int dwReserved1;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string cFileName;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
            public string cAlternateFileName;
        }

        #endregion

        #region Public Windows DLL Imports

        [DllImport("kernel32.dll", SetLastError = true)]
        public extern static int FileTimeToSystemTime(ref FileTime lpFileTime, ref SYSTEMTIME lpSystemTime);
        [DllImport("kernel32.dll", SetLastError = true)]
        public extern static int SystemTimeToFileTime(ref SYSTEMTIME lpSystemTime, ref FileTime lpFileTime);
        [DllImport("kernel32.dll", SetLastError = true)]
        public extern static long GetLastError();
        [DllImport("kernel32.dll", SetLastError = true)]
        public extern static long GetCurrentThreadId();

        #endregion

        #region Public WINServer API Constants ...

        ////!
        ////! WC DLL Error Values
        ////!
        public const int WC_STATUS_BASE = 0X20000000;
        public const int WC_SUCCESS = 0;
        public const int WC_UNSUPPORTED_VERSION = WC_STATUS_BASE + 1;
        public const int WC_CONTEXT_NOT_INITIALIZED = WC_STATUS_BASE + 2;
        public const int WC_INVALID_NODE_NUMBER = WC_STATUS_BASE + 3;
        public const int WC_USER_NOT_FOUND = WC_STATUS_BASE + 4;
        public const int WC_INCORRECT_PASSWORD = WC_STATUS_BASE + 5;
        public const int WC_USER_NOT_LOGGED_IN = WC_STATUS_BASE + 6;
        public const int WC_INVALID_INDEX = WC_STATUS_BASE + 7;
        public const int WC_INVALID_OBJECT_ID = WC_STATUS_BASE + 8;
        public const int WC_GROUP_ALREADY_EXISTS = WC_STATUS_BASE + 9;
        public const int WC_GROUP_NOT_FOUND = WC_STATUS_BASE + 10;
        public const int WC_OBSELETE_BY_502BETA = WC_STATUS_BASE + 11;
        public const int WC_OBJECTID_ALREADY_EXISTS = WC_STATUS_BASE + 12;
        public const int WC_NAME_NOT_FOUND = WC_STATUS_BASE + 13;
        public const int WC_NAME_ALREADY_EXISTS = WC_STATUS_BASE + 14;
        public const int WC_ALREADY_LOGGED_IN = WC_STATUS_BASE + 15;
        public const int WC_ITEM_NOT_FOUND = WC_STATUS_BASE + 16;
        public const int WC_ITEM_REQUIRES_NAME = WC_STATUS_BASE + 17;
        public const int WC_ITEM_ALREADY_EXISTS = WC_STATUS_BASE + 18;
        public const int WC_ITEM_NAME_DIFFERENT = WC_STATUS_BASE + 19;
        public const int WC_RECORD_NOT_FOUND = WC_STATUS_BASE + 20;
        public const int WC_ACCESS_DENIED = WC_STATUS_BASE + 21;
        public const int WC_NODE_ALREADY_IN_USE = WC_STATUS_BASE + 22;
        public const int WC_USER_ALREADY_LOGGED_IN = WC_STATUS_BASE + 23;
        public const int WC_INVALID_CONNECTION_ID = WC_STATUS_BASE + 24;
        public const int WC_INVALID_CONFERENCE = WC_STATUS_BASE + 25;
        public const int WC_INVALID_CONFERENCEGROUP = WC_STATUS_BASE + 26;
        public const int WC_INVALID_FILEAREA = WC_STATUS_BASE + 27;
        public const int WC_INVALID_FILEGROUP = WC_STATUS_BASE + 28;
        public const int WC_DUPLICATE_RECORD = WC_STATUS_BASE + 29;
        public const int WC_NO_ACTION_TAKEN = WC_STATUS_BASE + 30;
        public const int WC_ACCOUNT_LOCKED_OUT = WC_STATUS_BASE + 31;
        public const int WC_FILE_SEARCH_SYNTAX = WC_STATUS_BASE + 32;
        public const int WC_REQUEST_NOT_ADDED = WC_STATUS_BASE + 33;
        public const int WC_CONTEXT_MULTI_REFS = WC_STATUS_BASE + 34;
        public const int WC_CONTEXT_ALREADY_INITIALIZED = WC_STATUS_BASE + 35;
        public const int WC_NO_NODES_AVAILABLE = WC_STATUS_BASE + 36;
        public const int WC_COMPUTERNAME_NOT_FOUND = WC_STATUS_BASE + 37;
        public const int WC_DBASE_IX_MISMATCH = WC_STATUS_BASE + 38;
        public const int WC_DBASE_UPDATE_ERROR = WC_STATUS_BASE + 39;
        public const int WC_DBASE_RESERVED40 = WC_STATUS_BASE + 40;
        public const int WC_DBASE_RESERVED41 = WC_STATUS_BASE + 41;
        public const int WC_DBASE_RESERVED42 = WC_STATUS_BASE + 42;
        public const int WC_DBASE_RESERVED43 = WC_STATUS_BASE + 43;
        public const int WC_USER_OUT_OF_TIME = WC_STATUS_BASE + 44;
        public const int WC_ACCOUNT_NOT_VALIDATED = WC_STATUS_BASE + 45;
        public const int WC_DOMAIN_ACCESS_DENIED = WC_STATUS_BASE + 46;
        public const int WC_BUFFER_TOO_SMALL = WC_STATUS_BASE + 47;
        public const int WC_DOMAIN_NOT_FOUND = WC_STATUS_BASE + 48;
        public const int WC_PASSWORD_EXPIRED = WC_STATUS_BASE + 49;
        public const int WC_PASSWORD_CHANGE_REQUIRED = WC_STATUS_BASE + 50;
        public const int WC_ANONYMOUS_DENIED = WC_STATUS_BASE + 51;
        public const int WC_HOURS_RESTRICTED = WC_STATUS_BASE + 52;
        public const int WC_SECURITY_NOT_FOUND = WC_STATUS_BASE + 53;
        public const int WC_INVALID_USERNAME = WC_STATUS_BASE + 54;

        public const int MAX_PATH = 260;

        public const int SIZE_VOLUME_NAME = 16;
        public const int SIZE_CALLTYPE = 32;
        public const int SIZE_COMPUTER_NAME = 16;
        public const int SIZE_CONFERENCE_NAME = 60;
        public const int SIZE_CONFERENCEGROUP_NAME = 32;
        public const int SIZE_DOMAIN_NAME = 64;
        public const int SIZE_DOOR_NAME = 40;
        public const int SIZE_ENCODED_PASSWORD = 20;
        public const int SIZE_EXTENSION = 4;
        public const int SIZE_FILEAREA_NAME = 32;
        public const int SIZE_FILEGROUP_NAME = 32;
        public const int SIZE_LANGUAGE_NAME = 12;
        public const int SIZE_MENU_DESCRIPTION = 40;
        public const int SIZE_MODEM_NAME = 32;
        public const int SIZE_PASSWORD = 32;
        public const int SIZE_SASL_NAME = 32;
        public const int SIZE_SECURITY_NAME = 24;
        public const int SIZE_SERVICE_NAME = 64;
        public const int SIZE_USER_NAME = 72;
        public const int MAX_USER_NAME = 28;
        public const int CHANNEL_MESSAGE_HEADER_SIZE = 12;
        public const int MAX_CHANNEL_MESSAGE_SIZE = 500;
        public const int SIZE_PACKER_DESCRIPTION = 32;
        public const int SIZE_PACKER_COMMAND = 40;
        public const int MAX_PACKER_COUNT = 10;
        public const int SIZE_MAKEWILD_BBSNAME = 52;
        public const int SIZE_MAKEWILD_CITY = 32;
        public const int SIZE_MAKEWILD_PHONE = 28;
        public const int SIZE_MAKEWILD_FIRSTCALL = 28;
        public const int SIZE_MAKEWILD_PACKETID = 12;
        public const int SIZE_MAKEWILD_REGSTRING = 8;

        public const int WILDCAT_FRAMEWORK_VERSION = 1;
        public const int WILDCAT_MKTG_VERSION = 6;
        public const int WILDCAT_COMPONENT_ICP = 0X1;
        public const int WILDCAT_COMPONENT_SSL = 0X2;

        ////!--------------------------------------------------------------
        ////! SPECIAL NOTE ABOUT LONG vs SHORT FILE NAMES
        ////!
        ////! - v5.5 - File Database Only
        ////!
        ////!    MAX_PATH long file name support was implemented in v5.5
        ////!    Database conversion was required since TFileRecord size
        ////!    was changed
        ////!
        ////! - v6.1.451.9 - Message Database Only (Native storage)
        ////!
        ////!   A 80 (79 + 1 null) semi-long file name was implemented
        ////!   in v6.1.451.9 for TMsgHeader.Attachment.  The old
        ////!   short file name field was renamed to TMsgHeader.AttachmentSFN
        ////!
        ////!   Developers can use a sizeof(TMsgHeader.Header) check to see
        ////!   what is the current size of the API.
        ////!
        ////!--------------------------------------------------------------
        public const int SIZE_SHORT_FILE_NAME = 16;
        public const int SIZE_LONG_FILE_NAME = MAX_PATH;
        public const int SIZE_ATTACH_FILE_NAME = 80;

        ////!--------------------------------------------------------------------
        ////! Access Profiles Class Object identifiers (COID).
        ////! COIDS are used to identify a group/class of objects.
        ////!--------------------------------------------------------------------
        public const uint MASK_OBJECTCLASS = 0XFF000000;
        public const int OBJECTCLASS_RIGHTS = 0X1000000;
        public const int OBJECTCLASS_CONFERENCE = 0X2000000;
        public const int OBJECTCLASS_CONFERENCEGROUP = 0X3000000;
        public const int OBJECTCLASS_FILEAREA = 0X4000000;
        public const int OBJECTCLASS_FILEGROUP = 0X5000000;
        public const int OBJECTCLASS_DOOR = 0X6000000;
        public const int OBJECTCLASS_MENU = 0X7000000;
        public const int OBJECTCLASS_CODE = 0X8000000;
        public const int OBJECTCLASS_CLIENT = 0X9000000;
        public const int OBJECTCLASS_SAPPHIRE_QUERY = 0XA000000;
        public const int OBJECTCLASS_CHAT_CHANNEL = 0XB000000;
        public const int OBJECTCLASS_RADIUS_CLIENT = 0XC000000;
        public const int OBJECTCLASS_DOMAINS = 0XD000000;

        ////!--------------------------------------------------------------------
        ////! Access Profiles Object identifiers (OID).
        ////! Use with GetObjectFlags() during user sessions to determine if
        ////! logged in user has access to specific functionalities identified
        ////! by the OIDs
        ////!--------------------------------------------------------------------
        public const int OBJECTID_BULLETINS_OPTIONAL = OBJECTCLASS_RIGHTS + 1;
        public const int OBJECTID_CHANGE_PHONE = OBJECTCLASS_RIGHTS + 2;
        public const int OBJECTID_CHANGE_BIRTHDATE = OBJECTCLASS_RIGHTS + 4;
        public const int OBJECTID_QWK_ALLOW_BULLETINS = OBJECTCLASS_RIGHTS + 5;
        public const int OBJECTID_QWK_ALLOW_NEWS = OBJECTCLASS_RIGHTS + 6;
        public const int OBJECTID_QWK_ALLOW_FILES = OBJECTCLASS_RIGHTS + 7;
        public const int OBJECTID_QWK_DETAIL_DOWNLOAD = OBJECTCLASS_RIGHTS + 8;
        public const int OBJECTID_QWK_CHECK_DUPES = OBJECTCLASS_RIGHTS + 9;
        public const int OBJECTID_QWK_SAVE_PACKETS = OBJECTCLASS_RIGHTS + 10;
        public const int OBJECTID_MASTER_SYSOP = OBJECTCLASS_RIGHTS + 11;
        public const int OBJECTID_RATIO_ACTION = OBJECTCLASS_RIGHTS + 12;
        public const int OBJECTID_ALLOW_FAST_LOGIN = OBJECTCLASS_RIGHTS + 13;
        public const int OBJECTID_ALLOW_OVERWRITE_FILES = OBJECTCLASS_RIGHTS + 14;
        public const int OBJECTID_SHOW_PASSWORD_FILES = OBJECTCLASS_RIGHTS + 15;
        public const int OBJECTID_ALLOW_OFFLINE_FILE_REQUESTS = OBJECTCLASS_RIGHTS + 16;
        public const int OBJECTID_ALLOW_UPLOAD_OVER_TIME = OBJECTCLASS_RIGHTS + 17;
        public const int OBJECTID_ALLOW_DOWNLOAD_OVER_TIME = OBJECTCLASS_RIGHTS + 18;
        public const int OBJECTID_ALLOW_UPLOADER_MODIFY_FILE = OBJECTCLASS_RIGHTS + 20;
        public const int OBJECTID_QWK_NETSTATUS = OBJECTCLASS_RIGHTS + 26;
        public const int OBJECTID_SYSOP_READ_PRIVATE_MAIL = OBJECTCLASS_RIGHTS + 27;
        public const int OBJECTID_ALLOW_INTERNET_EMAIL = OBJECTCLASS_RIGHTS + 28;
        public const int OBJECTID_ALLOW_ANY_TELNET = OBJECTCLASS_RIGHTS + 29;
        public const int OBJECTID_ALLOW_ANY_FTP = OBJECTCLASS_RIGHTS + 30;
        public const int OBJECTID_ALLOW_HTTP_PROXY = OBJECTCLASS_RIGHTS + 31;
        public const int OBJECTID_ALLOW_ALL_IP = OBJECTCLASS_RIGHTS + 32;
        public const int OBJECTID_ALLOW_DEFAULT_IP = OBJECTCLASS_RIGHTS + 33;
        public const int OBJECTID_ALLOW_PPP = OBJECTCLASS_RIGHTS + 34;
        public const int OBJECTID_IGNORE_TIME_ONLINE = OBJECTCLASS_RIGHTS + 35;
        public const int OBJECTID_IGNORE_IDLE_TIME = OBJECTCLASS_RIGHTS + 36;
        public const int OBJECTID_ALLOW_SMTP_AUTH = OBJECTCLASS_RIGHTS + 37;
        public const int OBJECTID_ALLOW_NNTP_ACCESS = OBJECTCLASS_RIGHTS + 38;
        public const int OBJECTID_USERBIN_ACCESS = OBJECTCLASS_RIGHTS + 39;
        public const int OBJECTID_ALLOW_FTP_ACCESS = OBJECTCLASS_RIGHTS + 40;
        public const int OBJECTID_ALLOW_WEB_ACCESS = OBJECTCLASS_RIGHTS + 41;
        public const int OBJECTID_ALLOW_TELNET_ACCESS = OBJECTCLASS_RIGHTS + 42;
        public const int OBJECTID_CHANGE_EMAILADDRESS = OBJECTCLASS_RIGHTS + 43;
        public const int OBJECTID_CHANGE_SMTPFORWARD = OBJECTCLASS_RIGHTS + 44;
        public const int OBJECTID_ALLOW_CC_GROUPS = OBJECTCLASS_RIGHTS + 45;
        public const int OBJECTID_PROTOCOL_ACCESS = OBJECTCLASS_RIGHTS + 0X10000;
        public const int OBJECTID_NODE_ACCESS = OBJECTCLASS_RIGHTS + 0X20000;
        public const int OBJECTFLAGS_CONFERENCE_JOIN = 0X1;
        public const int OBJECTFLAGS_CONFERENCE_READ = 0X2;
        public const int OBJECTFLAGS_CONFERENCE_WRITE = 0X4;
        public const int OBJECTFLAGS_CONFERENCE_SYSOP = 0X8;
        public const int OBJECTFLAGS_FILEAREA_LIST = 0X1;
        public const int OBJECTFLAGS_FILEAREA_DOWNLOAD = 0X2;
        public const int OBJECTFLAGS_FILEAREA_UPLOAD = 0X4;
        public const int OBJECTFLAGS_FILEAREA_SYSOP = 0X8;

        ////!
        ////! MessageSearch() search attributes
        ////!
        public const int MSF_FORWARD = 0X1;
        public const int MSF_FROM = 0X2;
        public const int MSF_TO = 0X4;
        public const int MSF_SUBJECT = 0X8;
        public const int MSF_BODY = 0X10;

        ////!
        ////! wcBASIC Telnet connection options
        ////!
        public const int CONNECT_RAW = 0;
        public const int CONNECT_TELNET_ASCII = 1;
        public const int CONNECT_TELNET_7BIT = 2;
        public const int CONNECT_TELNET_8BIT = 3;

        ////!
        ////! User Database Function Keys
        ////!
        public const int UserIdKey = 0;
        public const int UserNameKey = 1;
        public const int UserLastNameKey = 2;
        public const int UserSecurityKey = 3;

        ////!
        ////! Files Database Function Keys
        ////!
        public const int FileNameAreaKey = 0;
        public const int FileAreaNameKey = 1;
        public const int FileAreaDateKey = 2;
        public const int FileUploaderKey = 3;
        public const int FileDateAreaKey = 4;

        ////!
        ////! System Operation Type
        ////!
        public const short saOpen = 0;
        public const short saClosed = 1;
        public const short saClosedQuestionnaire = 2;
        public const short saClosedValidation = 3;
        public const short dusNone = 0;
        public const short dusAsk = 1;
        public const short dusAllow = 2;
        public const short mhcUpperCase = 0;
        public const short mhcLowerCase = 1;
        public const short mhcAsIs = 2;

        ////!
        ////! LogPeriod options
        ////!
        public const short wclogNone = 0;
        public const short wclogHourly = 1;
        public const short wclogDaily = 2;
        public const short wclogWeekly = 3;
        public const short wclogMonthly = 4;
        public const short wclogUnlimitedSize = 5;
        public const short wclogMaxSize = 6;

        public const short pNone = 0;
        public const short pAscii = 1;
        public const short pXmodem = 2;
        public const short pXmodemCRC = 3;
        public const short pXmodem1K = 4;
        public const short pXmodem1KG = 5;
        public const short pYmodem = 6;
        public const short pYmodemG = 7;
        public const short pKermit = 8;
        public const short pZmodem = 9;
        public const short NumProtocols = 10;
        public const short fiaAllow = 0;
        public const short fiaLogoff = 1;
        public const short fiaLockout = 2;

        ////!
        ////! Password Bit Options for Security Profile and User Record
        ////!
        public const int pwdChangeForce = 0X1;
        public const int pwdChangeDisallow = 0X2;
        public const int pwdChangeExpire = 0X4;
        public const int pwdExpireLockout = 0X8;
        public const int pwdAttemptsLockout = 0X10;

        public const int lh12am = 0X1;
        public const int lh1am = 0X2;
        public const int lh2am = 0X4;
        public const int lh3am = 0X8;
        public const int lh4am = 0X10;
        public const int lh5am = 0X20;
        public const int lh6am = 0X40;
        public const int lh7am = 0X80;
        public const int lh8am = 0X100;
        public const int lh9am = 0X200;
        public const int lh10am = 0X400;
        public const int lh11am = 0X800;
        public const int lh12pm = 0X1000;
        public const int lh1pm = 0X2000;
        public const int lh2pm = 0X4000;
        public const int lh3pm = 0X8000;
        public const int lh4pm = 0X10000;
        public const int lh5pm = 0X20000;
        public const int lh6pm = 0X40000;
        public const int lh7pm = 0X80000;
        public const int lh8pm = 0X100000;
        public const int lh9pm = 0X200000;
        public const int lh10pm = 0X400000;
        public const int lh11pm = 0X800000;
        public const int lhAllHours = 0XFFFFFF;
        public const int lhSun = 0X1;
        public const int lhMon = 0X2;
        public const int lhTue = 0X4;
        public const int lhWed = 0X8;
        public const int lhThu = 0X10;
        public const int lhFri = 0X20;
        public const int lhSat = 0X40;
        public const int lhAllDays = 0X7F;
        public const int lhStartofWeek = lhSun;
        public const int lhEndofWeek = lhSat;
        public const int SIZE_CONFERENCE_ECHOTAG = 64;
        public const short mtNormalPublicPrivate = 0;
        public const short mtNormalPublic = 1;
        public const short mtNormalPrivate = 2;
        public const short mtFidoNetmail = 3;
        public const short mtEmailOnly = 4;
        public const short mtUsenetNewsgroup = 5;
        public const short mtUsenetNewsgroupModerated = 6;
        public const short mtInternetMailingList = 7;
        public const short mtFidoEcho = 8;
        public const short mtListServeForum = 9;
        public const short mtUserEmail = 10;
        public const short mtEND = 256;
        public const short vnYes = 0;
        public const short vnNo = 1;
        public const short vnPrompt = 2;

        ////! The following maXXXXXXXXX bit flags are used in the
        ////! TConfDesc.Options field.

        public const int maAllowMailSnooping = 0X1;
        public const int maPreserveMime = 0X2;
        public const int maAllowReplyOnly = 0X4;

        ////!
        ////! Option for TConfDesc.AuthorType field. This will define the
        ////! conference option for how the From field will be defined when
        ////! a message is created.
        ////!
        public const short authorDefaultName = 0;
        public const short authorForceUserName = 1;
        public const short authorForceAliasName = 2;
        public const short authorAllowBoth = 3;
        public const short authorAnonymousName = 4;

        ////!
        ////! TFileArea.Options attributes
        ////!
        public const int faIsVolume = 0X1;
        public const int faAllowPrivateFiles = 0X2;
        public const int faAllowFolderWatch = 0X4;

        public const short dtGeneric16 = 0;
        public const short dtDoor32 = 1;
        public const short dtDoorway = 2;

        public const int CALLTYPE_LOCAL = 0X1;
        public const int CALLTYPE_DIALUP = 0X2;
        public const int CALLTYPE_TELNET = 0X4;
        public const int CALLTYPE_FTP = 0X8;
        public const int CALLTYPE_HTTP = 0X10;
        public const int CALLTYPE_FRONTEND = 0X20;
        public const int CALLTYPE_POP3 = 0X40;
        public const int CALLTYPE_SMTP = 0X80;
        public const int CALLTYPE_PPP = 0X100;
        public const int CALLTYPE_RADIUS = 0X200;
        public const int CALLTYPE_NNTP = 0X400;
        public const int CALLTYPE_HTTPS = 0X800;

        public const int SIZE_NODECONFIG_COMPUTER = 16;
        public const int SIZE_NODECONFIG_PORTNAME = 16;
        public const int SIZE_LANGUAGE_DESCRIPTION = 72;
        public const int MAX_LANGUAGE_SUBCOMMAND_CHARS = 100;
        public const int LSC_YES = 0;
        public const int LSC_NO = 1;
        public const int SIZE_MODEM_STRING = 64;
        public const short aRing = 0;
        public const short aResult = 1;
        public const short aAutoAnswer = 2;
        public const int SIZE_SERVERSTATE_PORT = 80;
        public const int SERVERSTATE_OFFLINE = 0;
        public const int SERVERSTATE_DOWN = 1;
        public const int SERVERSTATE_REFUSE = 2;
        public const int SERVERSTATE_UP = 3;
        public const int MENU_TOPLEVEL = 0X2;
        public const int MAX_MENU_ITEMS = 40;
        public const int SIZE_MENUITEM_SELECTION = 16;
        public const int SIZE_MENUITEM_DESCRIPTION = 32;
        public const int SIZE_MENUITEM_COMMAND = 48;
        public const int SIZE_USER_TITLE = 12;
        public const short clSessionNone = 0;
        public const short clSessionUser = 1;
        public const short clSessionSystem = 2;
        public const short clSessionConfig = 3;
        public const short nsDown = 0;
        public const short nsUp = 1;
        public const short nsSigningOn = 2;
        public const short nsLoggedIn = 3;
        public const short nsProcessingEvent = 4;
        public const short nsForceDown = 5;
        public const int SIZE_NODEINFO_ACTIVITY = 32;
        public const int SIZE_NODEINFO_SPEED = 8;
        public const int SIZE_NODEINFO_LASTCALLER = 48;
        public const int SIZE_USER_FROM = 32;
        public const int ucstNone = 0;
        public const int ucstPersonal = 1;
        public const int ucstPersonalAll = 2;
        public const int ucstAll = 3;
        public const int ucstMask = 0XF;
        public const int ucfReserved1 = 0X10;
        public const int ucfReserved2 = 0X20;
        public const int ucfReserved3 = 0X40;
        public const int ucfAllAttach = 0X80;
        public const int SIZE_USER_PHONE = 16;
        public const int SIZE_USER_ADDRESS = 32;
        public const int SIZE_USER_STATE = 16;
        public const int SIZE_USER_ZIP = 12;
        public const int NUM_USER_SECURITY = 10;
        public const short sNotDisclosed = 0;
        public const short sMale = 1;
        public const short sFemale = 2;
        public const short ePrompt = 0;
        public const short eLine = 1;
        public const short eFullScreen = 2;
        public const short hlNovice = 0;
        public const short hlRegular = 1;
        public const short hlExpert = 2;
        public const short ttAuto = 0;
        public const short ttTTY = 1;
        public const short ttAnsi = 2;
        public const short fdSingle = 0;
        public const short fdDouble = 1;
        public const short fdFull = 2;
        public const short fdAnsi = 3;
        public const short mdScroll = 0;
        public const short mdClear = 1;
        public const short mdKeepHeader = 2;
        public const short ptText = 0;
        public const short ptQwk = 1;
        public const short ptOPX = 2;

        ////!
        ////! User validation states for ssClosedValidation setup
        ////!
        public const short vsNone = 0;
        public const short vsValidationRequired = 1;
        public const short vsPrevalidated = 2;
        public const short vsValidated = 3;

        public const int SIZE_MESSAGE_SUBJECT = 72;
        public const int SIZE_MESSAGE_NETWORK = 12;

        ////!
        ////! The following mfXXXXXXXXX bit flags are used in the
        ////! TMsgHeader.MailFlags field.  Bits are defined as required
        ////! for unique/special mail processing.
        ////!
        public const int mfPOP3Received = 0X1000000;
        public const int mfReceiptCreated = 0X2000000;
        public const int mfSmtpDelivered = 0X4000000;
        public const int mfNNTPPost = 0X8000000;
        public const int mfMimeSaved = 0X1;
        public const int mfNoDupeChecking = 0X2;
        public const int mfNoReplying = 0X4;

        public const int SIZE_FILE_DESCRIPTION = 76;
        public const int MAX_FILE_LONGDESC_LINES = 15;
        public const int SIZE_FILE_LONGDESC = 80;
        public const int ffAbortedUpload = 0X1;

        ////!
        ////! System.Control or System.Control.# Signals
        ////!
        public const int SC_WATCH_REQUEST = 0;
        public const int SC_DISPLAY_UPDATE = 1;
        public const int SC_PUSH_KEY = 2;
        public const int SC_SECURITY_CHANGE = 3;
        public const int SC_DISCONNECT = 4;
        public const int SC_TIME_CHANGE = 5;
        public const int SC_USER_RECORD_CHANGE = 6;

        ////!
        ////! System.Event Signals: File Database Signals
        ////!
        public const int SE_FILE_UPLOAD = 10;
        public const int SE_FILE_DOWNLOAD = 11;
        public const int SE_FILE_DELETE = 12;
        public const int SE_FILE_UPDATE = 13;

        ////!
        ////! System.Event Signals: Miscellaneous Client Control Signals
        ////! Note: Currently, there is no implementation. However, the
        ////! signals are defined to begin a standard signal number set.
        ////!
        public const int SE_SHUTDOWN_REQUEST = 20;
        public const int SE_RESTART = 21;
        public const int SE_CONFIG_CHANGE = 22;
        public const int SE_POPCONNECT = 23;

        ////!
        ////! System.Event Signals: Server Status Change
        ////!
        public const int SE_SERVER_STATE_CHANGE = 30;
        public const int SE_NODE_STATE_CHANGE = 31;

        ////!
        ////! System.MailServer Signals: This channel is specifically
        ////! designed for events between wcmail/wcsmtp and configuration
        ////! components so that wcmail/wcsmtp can automatically reread
        ////! internal data.  NOTE: wcSMTP port info changes requires
        ////! a restart. Only non-essential data is reread
        ////!
        public const int SE_MAILSERVER_UPDATE = 40;

        public const int SP_USER_PAGE = 0;
        public const int SP_SYSOP_CHAT = 1;
        public const int SP_NEW_MESSAGE = 2;
        public const int SP_ALT_NUMBER_FILE = 3;

        public const int listUnixFormat = 0;
        public const int listMSDOSFormat = 1;

        public const int SIZE_SYSTEMPAGE_LINES = 3;
        public const int SIZE_SYSTEMPAGE_TEXT = 80;

        public const int ipfilterDeny = 0;
        public const int ipfilterAllow = 1;
        public const int ipfilterNone = 2;

        ////!
        ////! TWildcatPOP3.dwOptions Bit Flags
        ////!
        public const int pop3MarkRcvd = 0X1;
        public const int pop3HonorRR = 0X2;
        public const int pop3ResolveHost = 0X20;

        ////!
        ////! TWildcatSMTP.dwOptions Bit Flags
        ////!
        public const int smtpBit0 = 0X1;
        public const int smtpRcvdBin = 0X2;
        public const int smtpNoMXOnce = 0X4;
        public const int smtpIpFilter = 0X8;
        public const int smtpIncMXTries = 0X10;
        public const int smtpResolveHost = 0X20;
        public const int smtpDisableETRN = 0X40;
        public const int smtpAllowLocal = 0X80;
        public const int smtpCheckHello = 0X100;
        public const int smtpEnableWCSAP = 0X200;
        public const int smtpEnableSFHook = 0X400;
        public const int smtpUsePort587 = 0X800;

        ////!
        ////! TWildcatFTP.dwOptions Bit Flags
        ////!
        public const int ftpBit0 = 0X1;
        public const int ftpUnixFileAge = 0X2;
        public const int ftpUseFtpLimit = 0X4;
        public const int ftpCheckForDIZ = 0X8;
        public const int ftpResolveHost = 0X20;
        public const int ftpDisableIndex = 0X40;

        ////!
        ////! TWildcatNNTP.dwOptions Bit Flags
        ////!
        public const int nntpAllowAnony = 0X1;
        public const int nntpResolveHost = 0X20;

        ////!
        ////! TWildcatHttpd.dwOptions Bit Flags
        ////!
        public const int httpEnableProxy = 0X1;
        public const int httpCommonLogFile = 0X2;
        public const int httpDeutschIVW = 0X4;
        public const int httpResolveHost = 0X20;
        public const int httpEnableChunking = 0X8;

        ////!
        ////! TWildcatTelnet.dwOptions Bit Flags
        ////!
        public const int telnetEnableRLogin = 0X1;
        public const int telnetResolveHost = 0X20;

        ////! v5.5.450.3
        ////! Options and structures for Wildcat! SASL Authentication functions.
        ////!
        public const int WCSASL_SUCCESS = 0;
        public const int WCSASL_AUTH_OK = WCSASL_SUCCESS;
        public const int WCSASL_AUTH_FAIL = 1;
        public const int WCSASL_INVALID_METHOD = 2;
        public const int WCSASL_GET_RESPONSE = 3;
        public const int WCSASL_GET_PASSWORD = 4;
        public const int WCSASL_LOOKUPUSER = 5;

        ////!
        ////! TWildcatSASLContext.dwOptions Bit Flags
        ////!
        public const int saslTranslate = 0X1;
        public const int saslTranslateBoth = 0X11;

        #endregion

        #region Public Structures created to get around conversion issues ...

        #region TmodemProfile Changes ...

        ////====[TModemProfile Begin]=======================================================
        ////These were created to get around the Array of fixed length strings in the
        ////TModemProfile Structure
        ////
        ////ExtraBaudResults replaces - ExtraBaudResults(1 To 10) As String * SIZE_MODEM_STRING
        ////ModemStrings replaces - Reserved5(1 To 3) As String * SIZE_MODEM_STRING
        ////
        ////====[Structures]===============================================================

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct ExtraBaudResults
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_STRING)]
            public string BaudResult;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct ModemStrings
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_STRING)]
            public string ModemString;
        }

        ////====[End Structures]===========================================================

        #endregion

        #region TUser Changes ...

        ////====[TUser Begin]=======================================================
        ////These were created to get around the Array of fixed length strings in the
        ////TUser Structure
        ////
        ////UserSecurityProfiles replaces - security(1 To NUM_USER_SECURITY) As String * SIZE_SECURITY_NAME
        ////
        ////====[Structures]===============================================================

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UserSecurityProfiles
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SECURITY_NAME)]
            public string SecurityProfile;
        }

        ////====[End Structures]===========================================================

        #endregion

        #region TFullFileRecord Changes ...

        ////====[TFullFileRecord Begin]=======================================================
        ////These were created to get around the Array of fixed length strings in the
        ////TFullFileRecord Structure
        ////
        ////LongDescriptons replaces - LongDescription(1 To MAX_FILE_LONGDESC_LINES) As String * SIZE_FILE_LONGDESC
        ////
        ////====[Structures]===============================================================

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct LongDescriptions
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_FILE_LONGDESC)]
            public string Description;
        }

        ////====[End Structures]===========================================================

        #endregion

        #region TSpellSuggestList Changes ...

        ////====[TSpellSuggestList Begin]=======================================================
        ////These were created to get around the Array of fixed length strings in the
        ////TSpellSuggestList Structure
        ////
        ////SpellSuggestWords replaces - Words(1 To 10) As String * 32
        ////
        ////====[Structures]===============================================================

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct SpellSuggestWords
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string Word;
        }

        ////====[End Structures]===========================================================

        #endregion

        #region TSystemPageInstantMessage Changes ...

        ////====[TSystemPageInstantMessage Begin]=======================================================
        ////These were created to get around the Array of fixed length strings in the 
        ////TSystemPageInstantMessage Structure
        ////
        ////SystemPageText replaces - text(1 To SIZE_SYSTEMPAGE_LINES) As String * SIZE_SYSTEMPAGE_TEXT
        ////
        ////====[Structures]===============================================================

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct SystemPageText
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SYSTEMPAGE_TEXT)]
            public string PageText;
        }

        ////====[End Structures]===========================================================

        #endregion

        #endregion

        #region Public WINServer API Structures...
        ////!
        ////! delegate for SetupWildcatCallback()
        ////!
        public delegate int TWildcatCallBack(int userdata, ref TChannelMessage msg);

        ////!
        ////! Channel message structure for Callbacks
        ////!
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TChannelMessage
        {
            public int Channel;
            public int SenderId;
            public short UserData;
            public short DataSize;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_CHANNEL_MESSAGE_SIZE)]
            public byte[] Data;
        }

        ////!
        ////! Data structure for Paging Channel Events
        ////! passed via TChannelMessage.Data field
        ////!
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TPageMessage
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_USER_NAME)]
            public string from;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = SIZE_SYSTEMPAGE_LINES)]
            public SystemPageText[] Message;
            public int InviteToChat;
        }

        ////!
        ////! Data structure for Chat Channel Events
        ////! passed via TChannelMessage.Data field
        ////!
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TChatMessage
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 28)]
            public string from;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Text;
            public byte Whisper;
        }

        //!---------------------------------------------------------------------------------------
        //! These next four structures were added to the "mod" source to make wcsdk corrections,
        //! as required for the VB.NET based app.
        //!
        //! TChatControl
        //! TChatControlSwitch
        //! TChatAction
        //! TChatUserInfo
        //!
        //! We are moving them into the wcSDK v8.0 library
        //!---------------------------------------------------------------------------------------

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TChatControl
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 28)]
            public string Name;
            public int ChannelId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string Text;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TChatControlSwitch
        {
            public TChatControl Control;
            public int NewId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string NewText;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TChatAction
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 28)]
            public string From;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string Text;
            public int Target;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string TargetText;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TChatUserInfo
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 28)]
            public string Name;
            public short Id;
            public short Channel;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
            public string Topic;
        }

        //!---------------------------------------------------------------------------------------



        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TObjectName
        {
            public int Status;
            public int objectID;
            public int Number;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string Name;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatTimeouts
        {
            public short dwVersion;
            public short dwRevision;
            public int Web;
            public int WebQues;
            public int Telnet;
            public int TelnetLogin;
            public int Ftp;
            public int wcPPP;
            public int wcNAV;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 92)]
            public string Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatLogOptions
        {
            public int EnableSessionTrace;
            public int LogPeriod;
            public int dwMaxSize;
            public int dwVerbosity;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct THttpAuthOptions
        {
            public int AllowPlainText;
            public int AllowPlainTextWithSSL;
            public int AllowPlainMD5;
            public int AllowDigest;
            public int AllowWcChallenge;
            public int RequireSSL;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatHttpd
        {
            public short dwVersion;
            public short dwRevision;
            public int obs_CommonLogF;
            public int obs_Deutsch;
            public TWildcatLogOptions LogOptions;
            public int dwOptions;
            public int MaximumBandWidth;
            public int SendBufferSize1K;
            public int RcvdBufferSize1K;
            public int TrackPerformance;
            public THttpAuthOptions HttpAuth;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 24)]
            public string Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatSMTP
        {
            public short dwVersion;
            public short dwRevision;
            public int port;
            public short sendthreads;
            public short acceptthreads;
            public int dwOptions;
            public int acceptonly;
            public int retries;
            public int retrywait;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 52)]
            public string SmartHost;
            public int sizelimit;
            public int localonly;
            public int MAPSRBL;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 52)]
            public string MAPSRBLServer;
            public int ESMTP;
            public int reqauth;
            public int VRFY;
            public int AllowRelay;
            public int CheckRCPT;
            public int EnableBadFilter;
            public int RequireMX;
            public int RequireHostMatch;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatNNTP
        {
            public short dwVersion;
            public short dwRevision;
            public int dwPort;
            public int dwOptions;
            public int MaxCrossPost;
            public TWildcatLogOptions LogOptions;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatPOP3
        {
            public short dwVersion;
            public short dwRevision;
            public int EnablePopBeforeSmtp;
            public int dwPopBeforeSmtpTimeout;
            public int dwOptions;
            public TWildcatLogOptions LogOptions;
            public int MaximumBandWidth;
            public int SendBufferSize1K;
            public int RcvdBufferSize1K;
            public int TrackPerformance;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatTelnet
        {
            public short dwVersion;
            public short dwRevision;
            public int dwOptions;
            public TWildcatLogOptions LogOptions;
            public int MaximumBandWidth;
            public int SendBufferSize1K;
            public int RcvdBufferSize1K;
            public int TrackPerformance;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 72)]
            public string Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatFTP
        {
            public short dwVersion;
            public short dwRevision;
            public int AllowAnonymous;
            public int ShowFileGroups;
            public int UseUnderScore;
            public int UseSingleAreaChange;
            public int MaxAnonymousConnects;
            public TWildcatLogOptions LogOptions;
            public int ListFormat;
            public int dwOptions;
            public int MaximumBandWidth;
            public int SendBufferSize1K;
            public int RcvdBufferSize1K;
            public int TrackPerformance;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TMakewild
        {
            public int Version;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MAKEWILD_BBSNAME)]
            public string BBSName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_USER_NAME)]
            public string SysopName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MAKEWILD_CITY)]
            public string City;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MAKEWILD_PHONE)]
            public string Phone;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MAKEWILD_FIRSTCALL)]
            public string FirstCall;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MAKEWILD_PACKETID)]
            public string PacketId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MAKEWILD_REGSTRING)]
            public string RegString;
            public int SystemAccess;
            public int MaxLoginAttempts;
            public int FreeFormPhone;
            public int HideAnonFtpPassword;
            public int LogonLanguagePrompt;
            public int Assume8N1;
            public int LoginAskLocation;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SECURITY_NAME)]
            public string NewUserSecurity;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_EXTENSION)]
            public string DefaultExt;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SHORT_FILE_NAME)]
            public string ThumbnailFile;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string OldDoorPath;
            public int obs_EnableHttpPr;
            public int SmtpMaxAcceptLoad;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 124)]
            public string Reserved;
            public TWildcatTelnet TelnetConfig;
            public TWildcatFTP FTPConfig;
            public TWildcatPOP3 POP3Config;
            public TWildcatLogOptions MAILLogOptions;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string Reserved2;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string Reserved1;
            public TWildcatLogOptions SMTPLogOptions;
            public TWildcatNNTP NNTPConfig;
            public int AllowLogonEmail;
            public int CaseSensitivePasswords;
            public int MsgHeaderCaseMode;
            public int SpamAllowAuth;
            public TWildcatSMTP SMTPConfig;
            public TWildcatHttpd HttpdConfig;
            public TWildcatTimeouts Timeouts;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 27)]
            public byte[] DefaultColors;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
            public byte[] ExcludeBulletins;
            public int InstalledComponents;
            public int obs_ResolveHostna;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string BuildDate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_DOMAIN_NAME)]
            public string DomainName;
            public int WindowsCharset;
            public int LogonUserNameOnly;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatComputerIpPort
        {
            public int dwPort;
            public int dwIpAddress;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TComputerConfig
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_COMPUTER_NAME)]
            public string Name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string DoorPath;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string CgiPath;
            public int HttpPort;
            public int FtpPort;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string WWWHostname;
            public int Servers;
            public int HttpProxyPort;
            public short dwVersion;
            public short dwRevision;
            public TWildcatComputerIpPort ipportHttp;
            public TWildcatComputerIpPort ipportFtp;
            public TWildcatComputerIpPort ipportPop3;
            public TWildcatComputerIpPort ipportTelnet;
            public TWildcatComputerIpPort ipportSmtp;
            public TWildcatComputerIpPort ipportNntp;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 340)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TLogonhours
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public int[] DayValue;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TSecurityProfile
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SECURITY_NAME)]
            public string Name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SECURITY_NAME)]
            public string ExpiredName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SHORT_FILE_NAME)]
            public string DisplayFileName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SECURITY_NAME)]
            public string DoorSysProfileName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SHORT_FILE_NAME)]
            public string MenuDisplaySet;
            public int DailyTimeLimit;
            public int PerCallTimeLimit;
            public int VerifyPhoneInterval;
            public int VerifyBirthdateInterval;
            public int FailedInfoAction;
            public int MaxDownloadCountPerDay;
            public int DownloadRatioLimit;
            public int MaxDownloadKbytesPerDay;
            public int DownloadKbytesRatioLimit;
            public int UploadTimeCredit;
            public int ExpireDays;
            public short PasswordOptions;
            public short PasswordExpireDays;
            public int FtpSpaceKbytes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_DOMAIN_NAME)]
            public string EmailDomainName;
            public int MaximumLogons;
            public int RestrictedHours;
            public TLogonhours LogonHours;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TConfDesc
        {
            public int objectid;
            public int Number;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_CONFERENCE_NAME)]
            public string name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string Reserved1;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_USER_NAME)]
            public string ConferenceSysop;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_CONFERENCE_ECHOTAG)]
            public string EchoTag;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_NAME)]
            public string ReplyToAddress;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_NAME)]
            public string Distribution;
            public int MailType;
            public int PromptToKillMsg;
            public int PromptToKillAttach;
            public int AllowHighAscii;
            public int AllowCarbon;
            public int AllowReturnReceipt;
            public int LongHeaderFormat;
            public int AllowAttach;
            public int ShowCtrlLines;
            public int ValidateNames;
            public int DefaultFileGroup;
            public int MaxMessages;
            public int DaysToKeepReceivedMail;
            public int DaysToKeepPublicMail;
            public int RenumberThreshold;
            public int DaysToKeepExternalMail;
            public int DeleteSMTPDelivered;
            public int PublishAsLocalNewsGroup;
            public int Options;
            public int AuthorType;
            public int UnixCreationTime;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Reserved;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_NAME)]
            public string DefaultFromAddress;
            public short wVersion;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TShortConfDesc
        {
            public int objectid;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_CONFERENCE_NAME)]
            public string name;
            public int MailType;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TConferenceGroup
        {
            public int objectid;
            public int Number;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_CONFERENCEGROUP_NAME)]
            public string name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TFileArea
        {
            public int objectid;
            public int Number;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_FILEAREA_NAME)]
            public string name;
            public int ExcludeFromNewFiles;
            public int PromptForPasswordProtect;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_FILEAREA_NAME)]
            public string FtpDirectoryName;
            public int Options;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TShortFileArea
        {
            public int objectid;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_FILEAREA_NAME)]
            public string name;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TFileGroup
        {
            public int objectid;
            public int Number;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_FILEGROUP_NAME)]
            public string name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TDoorInfo
        {
            public int objectid;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_DOOR_NAME)]
            public string name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SHORT_FILE_NAME)]
            public string Batch;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SHORT_FILE_NAME)]
            public string Display;
            public int DoorMenuIndex;
            public int MultiUser;
            public int SmallDoorSys;
            public int DoorType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TLanguageInfo
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_LANGUAGE_NAME)]
            public string name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_LANGUAGE_DESCRIPTION)]
            public string Description;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_LANGUAGE_SUBCOMMAND_CHARS)]
            public string SubcommandChars;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TShortModemProfile
        {
            public int UserDefined;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_NAME)]
            public string name;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TModemProfile
        {
            public int Version;
            public int UserDefined;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_NAME)]
            public string name;
            public int InitBaud;
            public int LockDTE;
            public int HardwareFlow;
            public int ExitOffHook;
            public int CarrierDelay;
            public int RingDelay;
            public int DropDtrDelay;
            public int PrelogDelay;
            public int ResultDelay;
            public int ResetDelay;
            public int AnswerMethod;
            public int EnableCallerId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_STRING)]
            public string ResetCommand;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_STRING)]
            public string AnswerCommand;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_STRING)]
            public string Reserved1;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_STRING)]
            public string OffHook;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_STRING)]
            public string RingResult;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_STRING)]
            public string ConnectResult;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_STRING)]
            public string Reserved2;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_STRING)]
            public string ErrorFreeResult;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public ExtraBaudResults[] ExtraBaudResults;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public int[] ExtraBaudResultNumbers;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_STRING)]
            public string Reserved3;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_STRING)]
            public string InitCommand;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_STRING)]
            public string Reserved4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public ModemStrings[] Reserved5;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Reserved6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TNodeConfig
        {
            public int CallTypesAllowed;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MODEM_NAME)]
            public string ModemName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_NODECONFIG_COMPUTER)]
            public string Computer;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_NODECONFIG_PORTNAME)]
            public string port;
            public int PermanentLineID;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public string VirtualDoorPort;
            public int NodeDisabled;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 44)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TServerState
        {
            public int OwnerId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_NODECONFIG_COMPUTER)]
            public string Computer;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SERVERSTATE_PORT)]
            public string port;
            public int State;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TwcMenuItem
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MENUITEM_SELECTION)]
            public string Selection;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MENUITEM_DESCRIPTION)]
            public string Description;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MENUITEM_COMMAND)]
            public string Command_Renamed;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MENUITEM_COMMAND)]
            public string[] Parameters;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TMenu
        {
            public int objectid;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MENU_DESCRIPTION)]
            public string Description;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SHORT_FILE_NAME)]
            public string DisplayName;
            public int flags;
            public int count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_MENU_ITEMS - 1)]
            public TwcMenuItem[] Items;
            public int FastLoginChar;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SECURITY_NAME)]
            public string SecurityEntryName;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TUserInfo
        {
            public int ID;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_NAME)]
            public string Name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_TITLE)]
            public string Title;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TwcNodeInfo
        {
            public int Nodestatus;
            public int ServerState;
            public int Connectionid;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_NODEINFO_LASTCALLER)]
            public string LastCaller;
            public TUserInfo User;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_FROM)]
            public string UserFrom;
            public int UserPageAvailable;
            public int Reserved1;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_NODEINFO_ACTIVITY)]
            public string Activity;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_NODEINFO_SPEED)]
            public string Speed;
            public FileTime TimeCalled;
            public FileTime CurrentTime;
            public int Reserved2;
            public int NodeNumber;
            public int MinutesLeft;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TUser
        {
            public int Status;
            public TUserInfo Info;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_FROM)]
            public string From;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_PASSWORD)]
            public string Password;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public UserSecurityProfiles[] Security;
            public int Reserved1;
            public int AllowMultipleLogins;
            public int LogonHoursOverride;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_NAME)]
            public string RealName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_PHONE)]
            public string PhoneNumber;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_ADDRESS)]
            public string Company;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_ADDRESS)]
            public string Address1;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_ADDRESS)]
            public string Address2;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_ADDRESS)]
            public string City;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_STATE)]
            public string State;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_ZIP)]
            public string Zip;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_ADDRESS)]
            public string Country;
            public int Sex;
            public int Editor;
            public int HelpLevel;
            public int Protocol;
            public int TerminalType;
            public int FileDisplay;
            public int MsgDisplay;
            public int PacketType;
            public int LinesPerPage;
            public int HotKeys;
            public int QuoteOnReply;
            public int SortedListings;
            public int PageAvailable;
            public int EraseMorePrompt;
            public int Reserved3;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_LANGUAGE_NAME)]
            public string Language;
            public FileTime LastCall;
            public FileTime LastNewFiles;
            public FileTime ExpireDate;
            public FileTime FirstCall;
            public FileTime Birthdate;
            public int Conference;
            public int MsgsWritten;
            public int Uploads;
            public int TotalUploadKbytes;
            public int Downloads;
            public int TotalDownloadKbytes;
            public int DownloadCountToday;
            public int DownloadKbytesToday;
            public int TimesOn;
            public int TimeLeftToday;
            public int MinutesLogged;
            public int SubscriptionBalance;
            public int NetmailBalance;
            public int AccountLockedOut;
            public int PreserveMimeMessages;
            public int ShowEmailHeaders;
            public FileTime LastUpdate;
            public short SystemFlags;
            public short UserFlags;
            public int Validation;
            public short PasswordOptions;
            public short PasswordExpireDays;
            public FileTime PasswordChangeDate;
            public int AnonymousOnly;
            public int AllowUserDirectory;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TFidoAddress
        {
            public short Zone;
            public short Net;
            public short Node;
            public short Point;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TMsgHeader
        {
            public int Status;
            public int Conference;
            public int Id;
            public int Number;
            public TUserInfo MsgFrom;
            public TUserInfo MsgTo;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MESSAGE_SUBJECT)]
            public string Subject;
            public FileTime PostedTimeGMT;
            public FileTime MsgTime;
            public FileTime ReadTime;
            public int IsPrivate;
            public int Received;
            public int ReceiptRequested;
            public int Deleted;
            public int Tagged;
            public int Reference;
            public int ReplyCount;
            public TFidoAddress FidoFrom;
            public TFidoAddress FidoTo;
            public int FidoFlags;
            public int MsgSize;
            public int PrevUnread;
            public int NextUnread;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MESSAGE_NETWORK)]
            public string Network;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SHORT_FILE_NAME)]
            public string AttachmentSFN;
            public int AllowDisplayMacros;
            public int AddedByUserId;
            public int Exported;
            public int MailFlags;
            public int NextAttachment;
            public int ReadCount;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_ATTACH_FILE_NAME)]
            public string Attachment;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TFileRecord
        {
            public int Status;
            public int Area;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SHORT_FILE_NAME)]
            public string SFName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_FILE_DESCRIPTION)]
            public string Description;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_PASSWORD)]
            public string Password;
            public int FileFlags;
            public int Size;
            public FileTime FileTime;
            public FileTime LastAccessed;
            public int NeverOverwrite;
            public int NeverDelete;
            public int IsFreeFile;
            public int CopyBeforeDownload;
            public int Offline;
            public int FailedScan;
            public int FreeTime;
            public int Downloads;
            public int Cost;
            public TUserInfo Uploader;
            public int UserInfo;
            public int HasLongDescription;
            public FileTime PostTime;
            public int PrivateUserId;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] Reserved;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_LONG_FILE_NAME)]
            public string Name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public byte[] Reserved2;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TFullFileRecord
        {
            public TFileRecord Info;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string StoredPath;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_FILE_LONGDESC_LINES)]
            public LongDescriptions[] LongDescription;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TFileRecord5
        {
            public int Status;
            public int Area;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SHORT_FILE_NAME)]
            public string Name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_FILE_DESCRIPTION)]
            public string Description;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_PASSWORD)]
            public string Password;
            public int Reserved1;
            public int Size;
            public FileTime FileTime;
            public FileTime LastAccessed;
            public int NeverOverwrite;
            public int NeverDelete;
            public int FreeFile;
            public int CopyBeforeDownload;
            public int Offline;
            public int FailedScan;
            public int FreeTime;
            public int Downloads;
            public int Cost;
            public TUserInfo Uploader;
            public int UserInfo;
            public int HasLongDescription;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 44)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TFullFileRecord5
        {
            public TFileRecord5 Info;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string StoredPath;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_FILE_LONGDESC_LINES)]
            public LongDescriptions[] LongDescription;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TSpellSuggestList
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public SpellSuggestWords[] Words;
        }

        ////!
        ////! Data Structure used for SE_FILE_xxxxxx channel signals.
        ////!
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TSystemEventFileInfo
        {
            public int FileArea;
            public int Connectionid;
            public FileTime TimeStamp;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_LONG_FILE_NAME)]
            public string szFileName;
        }

        ////!
        ////! Structure used by WCVIEW to display screen data sent by
        ////! Host clients.  WCVIEW will send SC_WATCH_REQUEST to clients
        ////! asking them to provide screen data. If the clients are listening,
        ////! they can fill in the structure and send the data with the
        ////! SC_DISPLAY_UPDATE channel signal which will then signal WCVIEW
        ////! to update its display screens.
        ////!
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TSystemControlViewMsg
        {
            public short Line;
            public short Count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 240)]
            public short[] Text;
            public short CursorX;
            public short CursorY;
            public short MinutesLeft;
        }

        ////!
        ////! Data Structure used for SP_xxxxxx channel signals
        ////!
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TSystemPageNewMessage
        {
            public int Conference;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_CONFERENCE_NAME)]
            public string ConferenceName;
            public int Id;
            public TUserInfo from;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_MESSAGE_SUBJECT)]
            public string Subject;
        }

        ////!
        ////! Data Structure used for instant messages, channel "System.Page"
        ////!
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TSystemPageInstantMessage
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_USER_NAME)]
            public string from;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = SIZE_SYSTEMPAGE_LINES)]
            public SystemPageText Message;
            public int InviteToChat;
        }

        ////!
        ////! Structure for Wildcat! Service Creations
        ////!
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatService
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SERVICE_NAME)]
            public string Name;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SERVICE_NAME)]
            public string Vendor;
            public int Version;
            public int Address;
            public int Port;
        }

        ////!
        ////! Structure for Connection Information
        ////! Set GetConnectionInfo() SDK function
        ////!
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TConnectionInfo
        {
            public int Connectionid;
            public int Node;
            public int Time;
            public int IdleTime;
            public int Calls;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string WindowsUserName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_COMPUTER_NAME)]
            public string Computer;
            public int IpAddress;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string ProgramName;
            public int RefCount;
            public TUserInfo User;
            public int HandlesOpen;
            public int ChannelsOpen;
            public int CurrentTid;
            public int PeerAddress;
            public int CallType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 92)]
            public byte[] Reserved;
        }

        ////!
        ////! Structure for GetWildcatServerInfo() function
        ////! Combines multiple server calls to get server totals in 1 call
        ////!
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatServerInfo
        {
            public int TotalCalls;
            public int TotalUsers;
            public int TotalMessages;
            public int TotalFiles;
            public int MemoryUsage;
            public int MemoryLoad;
            public int LastMessageId;
            public int LastUserId;
            public int ServerVersion;
            public int ServerBuild;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 84)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatProcessTimes
        {
            public FileTime ftSystem;
            public FileTime ftStart;
            public FileTime ftExit;
            public FileTime ftKernel;
            public FileTime ftUser;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
            public byte[] Reserved;
        }

        ////!
        ////! TWildcatSASLContext is used to store any context specific
        ////! data we need in SASL based connections
        ////!
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatSASLContext
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_SASL_NAME)]
            public string szSaslMethod;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string szChallenge;
            public int dwOptions;
            public int dwState;
            public int dwUserid;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4096)]
            public byte[] Data;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_USER_NAME)]
            public string szUsername;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string szRealm;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string szDomain;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string szNonce;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string szCNonce;
            public int dwCNonceCount;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string szURI;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string szMethod;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string szAlg;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string szQop;
        }

        ////! v6.0.451.2
        ////! Structure for wcCreateFileEx() function
        ////!
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TwcOpenFileInfo
        {
            public int hFile;
            public int dwSize;
            public FileTime ftWriteTime;
            public int dwAttributes;
            public int dwSizeHigh;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 232)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TPackerRec
        {
            public int Letter;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_PACKER_DESCRIPTION)]
            public string Description;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_EXTENSION)]
            public string Extension;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_PACKER_COMMAND)]
            public string Packer;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SIZE_PACKER_COMMAND)]
            public string Unpacker;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatServerGuid
        {
            public DateTime Time;
            public int Count;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string szGuid;
        }

        //!
        //! v7.0.454.6
        //! Structure for WcGetGeoIP()
        //!
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TWildcatGeoIP
        {
            public bool has_data;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string ipaddr;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string city;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 52)]
            public string continent;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 52)]
            public string country;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string latitude;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string longitude;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string metro_code;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 52)]
            public string tzone;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string postal;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public string country_code;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string region_code;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 52)]
            public string region_name;
        }

        #endregion

        #region Public WINServer API DLL Imports ...

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetWildcatVersion();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetWildcatBuild();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int WcGetServerVersion();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int WcGetServerBuild();
        [DllImport("wcvb.dll", EntryPoint = "vbWildcatServerConnect", SetLastError = true)]
        public extern static bool WildcatServerConnect(int parent);
        [DllImport("wcvb.dll", EntryPoint = "vbWildcatServerConnectSpecific", SetLastError = true)]
        public extern static bool WildcatServerConnectSpecific(int parent, string computername);
        [DllImport("wcvb.dll", SetLastError = true)]
        public extern static bool WildcatServerConnectLocal(int parent);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WildcatServerDialog(int parent, string computername, int namesize);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetWildcatErrorMode(int verbose);

        [DllImport("wcvb.dll", EntryPoint = "vbGetConnectedServer", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.AnsiBStr)]
        public extern static string GetConnectedServer();

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WildcatServerCreateContext();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WildcatServerCreateContextFromHandle(int context);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WildcatServerCreateContextFromChallenge(string challenge);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetWildcatServerContextHandle();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WildcatServerDeleteContext();

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetupWildcatCallback(Delegate cbproc, int userdata);

        [DllImport("wcsrv2.dll", EntryPoint = "SetupWildcatCallback", SetLastError = true)]
        public extern static bool SetupWildcatCallbackEx(Delegate cbproc, int userdata);

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool RemoveWildcatCallback();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool GrantThreadAccess(int tid);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetWildcatThreadContext();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetWildcatThreadContext(int context);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetNode();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetNodeStatus(int nodestatus);
        [DllImport("wcvb.dll", EntryPoint = "vbGetMakewild", SetLastError = true)]
        public extern static bool GetMakewild(ref TMakewild mw);
        [DllImport("wcvb.dll", EntryPoint = "vbGetComputerConfig", SetLastError = true)]
        public extern static bool GetComputerConfig(ref TComputerConfig cc);
        /// <returns>Returns the user's session context challenge string.</returns>
        [DllImport("wcvb.dll", EntryPoint = "vbGetChallengeString", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.AnsiBStr)]
        public extern static string GetChallengeString();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool LoginSystem();
        [DllImport("wcvb.dll", EntryPoint = "vbLookupName", SetLastError = true)]
        public extern static bool LookupName(string name, ref TUserInfo uinfo);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool AllocateNode(int node, int calltype, string speed);
        [DllImport("wcvb.dll", EntryPoint = "vbLoginUser", SetLastError = true)]
        public extern static bool LoginUser(int UserId, string Password, ref TUser user);
        [DllImport("wcvb.dll", EntryPoint = "vbLoginUserEx", SetLastError = true)]
        public extern static bool LoginUserEx(int UserId, string Password, int calltype, string speed, ref TUser user);
        [DllImport("wcvb.dll", EntryPoint = "vbLoginRadiusUser", SetLastError = true)]
        public extern static bool LoginRadiusUser(int UserId, byte chapid, ref byte challenge, int challengesize, ref byte challresponse, ref TUser user);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool LogoutUser();
        [DllImport("wcvb.dll", EntryPoint = "vbWildcatLoggedIn", SetLastError = true)]
        public extern static int WildcatLoggedIn(ref TUser user);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetUsersOnline();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetProfileObjectFlags(string profile, int objectid);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcCloseHandle(int h);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcCreateDirectory(string directory);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int WcCreateFile(string fn, uint access, uint sharemode, uint create);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcDeleteFile(string fn);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcExistFile(string fn);
        [DllImport("wcvb.dll", EntryPoint = "vbWcFindFirstFile", SetLastError = true)]
        public extern static int WcFindFirstFile(string fn, ref WIN32_FIND_DATA fd);
        [DllImport("wcvb.dll", EntryPoint = "vbWcFindNextFile", SetLastError = true)]
        public extern static bool WcFindNextFile(int ff, ref WIN32_FIND_DATA fd);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcFindClose(int ff);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int WcGetFileSize(int h);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcGetFileTime(int h, ref FileTime ft);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcGetFileTimeByName(string fn, ref FileTime ft);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcMoveFile(string src, string dest);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcReadFile(int h, byte[] buffer, uint requested, ref uint Read);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcReadLine(int h, byte[] buffer, uint buflen);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcSetEndOfFile(int h);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int WcSetFilePointer(int h, int dist, int movemethod);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcSetFileTime(int h, ref FileTime ft);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcWriteFile(int h, ref byte[] buffer, int requested, ref int Written);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetConnectionId();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetTotalCalls(int increment);
        [DllImport("wcvb.dll", EntryPoint = "vbGetText", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.AnsiBStr)]
        public extern static string GetText(string fn);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetObjectFlags(int objectid);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool GetMultipleObjectFlags(ref int objectid, int count, ref int flags);
        [DllImport("wcvb.dll", EntryPoint = "vbGetObjectById", SetLastError = true)]
        public extern static bool GetObjectById(int objectid, ref TObjectName objectname);
        [DllImport("wcvb.dll", EntryPoint = "vbGetMultipleObjectsById", SetLastError = true)]
        public extern static bool GetMultipleObjectsById(ref int objectid, int count, ref TObjectName objectname);
        [DllImport("wcvb.dll", EntryPoint = "vbGetObjectByName", SetLastError = true)]
        public extern static bool GetObjectByName(int classid, string name, ref TObjectName objectname, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetNextObjectByName", SetLastError = true)]
        public extern static bool GetNextObjectByName(ref TObjectName objectname, ref int tid);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetStringObjectId(int objectclass, string name);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetStringObjectFlags(int objectclass, string name);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetSecurityProfileCount();
        [DllImport("wcvb.dll", EntryPoint = "vbGetSecurityProfileNames", SetLastError = true)]
        public extern static object GetSecurityProfileNames();
        [DllImport("wcvb.dll", EntryPoint = "vbGetSecurityProfileByIndex", SetLastError = true)]
        public extern static bool GetSecurityProfileByIndex(int Index, ref TSecurityProfile profile);
        [DllImport("wcvb.dll", EntryPoint = "vbGetSecurityProfileByName", SetLastError = true)]
        public extern static bool GetSecurityProfileByName(string name, ref TSecurityProfile profile);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetAccessProfileCount();
        [DllImport("wcvb.dll", EntryPoint = "vbGetAccessProfileNames", SetLastError = true)]
        public extern static object GetAccessProfileNames();
        [DllImport("wcvb.dll", EntryPoint = "vbGetAccessProfileName", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.AnsiBStr)]
        public extern static string GetAccessProfileName(int Index);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetConferenceCount();
        [DllImport("wcvb.dll", EntryPoint = "vbGetConfDesc", SetLastError = true)]
        public extern static bool GetConfDesc(int Conference, ref TConfDesc cd);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetConferenceGroupCount();
        [DllImport("wcvb.dll", EntryPoint = "vbGetConferenceGroup", SetLastError = true)]
        public extern static bool GetConferenceGroup(int Index, ref TConferenceGroup cg);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetFileAreaCount();
        [DllImport("wcvb.dll", EntryPoint = "vbGetFileArea", SetLastError = true)]
        public extern static bool GetFileArea(int area, ref TFileArea fa);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetFileGroupCount();
        [DllImport("wcvb.dll", EntryPoint = "vbGetFileGroup", SetLastError = true)]
        public extern static bool GetFileGroup(int Index, ref TFileGroup fg);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetDoorCount();
        [DllImport("wcvb.dll", EntryPoint = "vbGetDoor", SetLastError = true)]
        public extern static bool GetDoor(int Index, ref TDoorInfo di);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetLanguageCount();
        [DllImport("wcvb.dll", EntryPoint = "vbGetLanguage", SetLastError = true)]
        public extern static bool GetLanguage(int Index, ref TLanguageInfo li);
        [DllImport("wcvb.dll", EntryPoint = "vbGetModemProfile", SetLastError = true)]
        public extern static bool GetModemProfile(string name, ref TModemProfile mp);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetNodeCount();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetMaximumUserCount();
        [DllImport("wcvb.dll", EntryPoint = "vbGetNodeConfig", SetLastError = true)]
        public extern static bool GetNodeConfig(int node, ref TNodeConfig nc);
        [DllImport("wcvb.dll", EntryPoint = "vbGetNodeInfo", SetLastError = true)]
        public extern static bool GetNodeInfo(int node, ref TwcNodeInfo ni);
        [DllImport("wcvb.dll", EntryPoint = "vbGetNodeInfoByConnectionId", SetLastError = true)]
        public extern static bool GetNodeInfoByConnectionId(int id, ref TwcNodeInfo ni);
        [DllImport("wcvb.dll", EntryPoint = "vbGetNodeInfoByName", SetLastError = true)]
        public extern static bool GetNodeInfoByName(string name, ref TwcNodeInfo ni);
        [DllImport("wcvb.dll", EntryPoint = "vbGetNodeInfos", SetLastError = true)]
        public extern static bool GetNodeInfos(int node, int count, ref TwcNodeInfo ni);
        [DllImport("wcvb.dll", EntryPoint = "vbSetNodeInfo", SetLastError = true)]
        public extern static bool SetNodeInfo(ref TwcNodeInfo ni);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetNodeActivity(string activity);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetServerState(string port, int State);
        [DllImport("wcvb.dll", EntryPoint = "vbGetServerState", SetLastError = true)]
        public extern static bool GetServerState(int Index, ref TServerState ss);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetNodeServerState(int node, int State);
        [DllImport("wcvb.dll", EntryPoint = "vbAddFileRec", SetLastError = true)]
        public extern static bool AddFileRec(ref TFullFileRecord f);
        [DllImport("wcvb.dll", EntryPoint = "vbDeleteFileRec", SetLastError = true)]
        public extern static bool DeleteFileRec(ref TFileRecord f, int disktoo);
        [DllImport("wcvb.dll", EntryPoint = "vbFileSearch", SetLastError = true)]
        public extern static object FileSearch(string s);
        [DllImport("wcvb.dll", EntryPoint = "vbGetFileRecAbsolute", SetLastError = true)]
        public extern static bool GetFileRecAbsolute(int @ref, ref TFileRecord f);
        [DllImport("wcvb.dll", EntryPoint = "vbGetFileRecByNameArea", SetLastError = true)]
        public extern static bool GetFileRecByNameArea(string name, int area, ref TFileRecord f, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetFileRecByAreaName", SetLastError = true)]
        public extern static bool GetFileRecByAreaName(int area, string name, ref TFileRecord f, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetFileRecByAreaDate", SetLastError = true)]
        public extern static bool GetFileRecByAreaDate(int area, ref FileTime t, ref TFileRecord f, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetFileRecByUploader", SetLastError = true)]
        public extern static bool GetFileRecByUploader(int id, ref TFileRecord f, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetFirstFileRec", SetLastError = true)]
        public extern static bool GetFirstFileRec(int keynum, ref TFileRecord f, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetFullFileRec", SetLastError = true)]
        public extern static bool GetFullFileRec(ref TFileRecord f, ref TFullFileRecord full);
        [DllImport("wcvb.dll", EntryPoint = "vbGetLastFileRec", SetLastError = true)]
        public extern static bool GetLastFileRec(int keynum, ref TFileRecord f, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetNextFileRec", SetLastError = true)]
        public extern static bool GetNextFileRec(int keynum, ref TFileRecord f, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetPrevFileRec", SetLastError = true)]
        public extern static bool GetPrevFileRec(int keynum, ref TFileRecord f, ref int tid);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetTotalFiles();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetTotalFilesInArea(int area);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetTotalFilesInGroup(int group);
        [DllImport("wcvb.dll", EntryPoint = "vbIncrementDownloadCount", SetLastError = true)]
        public extern static bool IncrementDownloadCount(ref TFileRecord f);
        [DllImport("wcvb.dll", EntryPoint = "vbSearchFileRecByNameArea", SetLastError = true)]
        public extern static bool SearchFileRecByNameArea(string name, int area, ref TFileRecord f, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbSearchFileRecByAreaName", SetLastError = true)]
        public extern static bool SearchFileRecByAreaName(int area, string name, ref TFileRecord f, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbSearchFileRecByAreaDate", SetLastError = true)]
        public extern static bool SearchFileRecByAreaDate(int area, ref FileTime t, ref TFileRecord f, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbSearchFileRecByDateArea", SetLastError = true)]
        public extern static bool SearchFileRecByDateArea(ref FileTime t, int area, ref TFileRecord f, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbSearchFileRecByUploader", SetLastError = true)]
        public extern static bool SearchFileRecByUploader(int id, ref TFileRecord f, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbUpdateFileRec", SetLastError = true)]
        public extern static bool UpdateFileRec(ref TFileRecord f);
        [DllImport("wcvb.dll", EntryPoint = "vbUpdateFullFileRec", SetLastError = true)]
        public extern static bool UpdateFullFileRec(ref TFullFileRecord f);
        [DllImport("wcvb.dll", EntryPoint = "vbAddMessage", SetLastError = true)]
        public extern static bool AddMessage(ref TMsgHeader msg, string text);
        [DllImport("wcvb.dll", EntryPoint = "vbDeleteMessage", SetLastError = true)]
        public extern static bool DeleteMessage(ref TMsgHeader msg);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetHighMessageNumber(int conf);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetLowMessageNumber(int conf);
        [DllImport("wcvb.dll", EntryPoint = "vbGetMessageById", SetLastError = true)]
        public extern static bool GetMessageById(int conf, int MsgID, ref TMsgHeader msg);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetMsgIdFromNumber(int conf, int Number);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetMsgNumberFromId(int conf, int MsgID);
        [DllImport("wcvb.dll", EntryPoint = "vbGetNextMessage", SetLastError = true)]
        public extern static bool GetNextMessage(ref TMsgHeader msg);
        [DllImport("wcvb.dll", EntryPoint = "vbGetPrevMessage", SetLastError = true)]
        public extern static bool GetPrevMessage(ref TMsgHeader msg);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetTotalMessages();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetTotalMessagesInConference(int conf);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetTotalMessagesInGroup(int group);
        [DllImport("wcvb.dll", EntryPoint = "vbIncrementReplyCount", SetLastError = true)]
        public extern static bool IncrementReplyCount(ref TMsgHeader msg);
        [DllImport("wcvb.dll", EntryPoint = "vbIncrementReadCount", SetLastError = true)]
        public extern static bool IncrementReadCount(ref TMsgHeader msg);
        [DllImport("wcvb.dll", EntryPoint = "vbMarkMessageRead", SetLastError = true)]
        public extern static bool MarkMessageRead(ref TMsgHeader msg);
        [DllImport("wcvb.dll", EntryPoint = "vbMessageSearch", SetLastError = true)]
        public extern static bool MessageSearch(int conf, int MsgID, int msflags, string text, ref TMsgHeader msg);
        [DllImport("wcvb.dll", EntryPoint = "vbSearchMessageById", SetLastError = true)]
        public extern static bool SearchMessageById(int conf, int MsgID, ref TMsgHeader msg);
        [DllImport("wcvb.dll", EntryPoint = "vbSetMessagePrivate", SetLastError = true)]
        public extern static bool SetMessagePrivate(ref TMsgHeader msg, int pvt);
        [DllImport("wcvb.dll", EntryPoint = "vbUpdateMessageFidoInfo", SetLastError = true)]
        public extern static bool UpdateMessageFidoInfo(ref TMsgHeader msg);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool GetHighMessageIds(int count, ref int conferences, ref int ids);
        [DllImport("wcvb.dll", EntryPoint = "vbSetMessageExported", SetLastError = true)]
        public extern static bool SetMessageExported(ref TMsgHeader msg, int exported);
        [DllImport("wcvb.dll", EntryPoint = "vbAddNewUser", SetLastError = true)]
        public extern static bool AddNewUser(ref TUser u);
        [DllImport("wcvb.dll", EntryPoint = "vbDeleteOtherUser", SetLastError = true)]
        public extern static bool DeleteOtherUser(ref TUser u);
        [DllImport("wcvb.dll", EntryPoint = "vbGetUserById", SetLastError = true)]
        public extern static bool GetUserById(int id, ref TUser u, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetUserByLastName", SetLastError = true)]
        public extern static bool GetUserByLastName(string name, ref TUser u, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetUserByName", SetLastError = true)]
        public extern static bool GetUserByName(string name, ref TUser u, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetUserBySecurity", SetLastError = true)]
        public extern static bool GetUserBySecurity(string security, ref TUser u, ref int tid);

        [DllImport("wcvb.dll", EntryPoint = "vbGetUserVariable", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.AnsiBStr)]
        public extern static string GetUserVariable(int id, string section, string key, string def);

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool GetUserVariables(int id, ref string buffer, int requested, ref int Read);

        [DllImport("wcvb.dll", EntryPoint = "vbGetUserVariables", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.AnsiBStr)]
        public extern static string GetUserVariables(int id);

        [DllImport("wcvb.dll", EntryPoint = "vbGetFirstUser", SetLastError = true)]
        public extern static bool GetFirstUser(int keynum, ref TUser u, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetLastUser", SetLastError = true)]
        public extern static bool GetLastUser(int keynum, ref TUser u, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetNextUser", SetLastError = true)]
        public extern static bool GetNextUser(int keynum, ref TUser u, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbGetPrevUser", SetLastError = true)]
        public extern static bool GetPrevUser(int keynum, ref TUser u, ref int tid);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetTotalUsers();
        [DllImport("wcvb.dll", EntryPoint = "vbSearchUserById", SetLastError = true)]
        public extern static bool SearchUserById(int id, ref TUser u, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbSearchUserByLastName", SetLastError = true)]
        public extern static bool SearchUserByLastName(string name, ref TUser u, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbSearchUserByName", SetLastError = true)]
        public extern static bool SearchUserByName(string name, ref TUser u, ref int tid);
        [DllImport("wcvb.dll", EntryPoint = "vbSearchUserBySecurity", SetLastError = true)]
        public extern static bool SearchUserBySecurity(string security, ref TUser u, ref int tid);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetUserVariable(int id, string section, string key, string data);
        [DllImport("wcvb.dll", EntryPoint = "vbUpdateUser", SetLastError = true)]
        public extern static bool UpdateUser(ref TUser u);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetEffectiveConferenceGroupCount();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetEffectiveConferenceCount(int group, int flags);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetFirstConference(int group, int flags);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetLastConference(int group, int flags);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetNextConference(int group, int flags, int conf);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetPrevConference(int group, int flags, int conf);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetFirstConferenceUnread();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetNextConferenceUnread(int conf);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetPrevConferenceUnread(int conf);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool IsConferenceInGroup(int group, int conf);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetEffectiveFileGroupCount();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetEffectiveFileAreaCount(int group, int flags);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetFirstFileArea(int group, int flags);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetLastFileArea(int group, int flags);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetNextFileArea(int group, int flags, int area);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetPrevFileArea(int group, int flags, int area);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool IsFileAreaInGroup(int group, int area);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetLastRead(int conf);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetFirstUnread(int conf);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetConfFlags(int conf);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetLastRead(int conf, int lastread);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetConfFlags(int conf, int flags);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetUserLastRead(int UserId, int conf);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetUserFirstUnread(int UserId, int conf);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetUserConfFlags(int UserId, int conf);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetUserLastRead(int UserId, int conf, int lastread);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetUserConfFlags(int UserId, int conf, int flags);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WriteLogEntry(string fname, string text);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WriteActivityLogEntry(string text);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SpellCheckLine(string s, int startpos, ref int badpos, ref int badlen);
        [DllImport("wcvb.dll", EntryPoint = "vbSpellCheckSuggest", SetLastError = true)]
        public extern static int SpellCheckSuggest(string s, ref TSpellSuggestList sl);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SpellCheckAddWord(string s);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int OpenChannel(string name);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool CloseChannel(int chandle);

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WriteChannel(int chandle, int destid, int userdata, ref string data, int datasize);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WriteChannel(int chandle, int destid, int userdata, ref TPageMessage data, int datasize);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WriteChannel(int chandle, int destid, int userdata, ref TChatMessage data, int datasize);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WriteChannel(int chandle, int destid, int userdata, ref TChatControl data, int datasize);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WriteChannel(int chandle, int destid, int userdata, ref TChatControlSwitch data, int datasize);

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool GetQwkBaudLimits(ref int perpacket, ref int perconference);
        [DllImport("wcvb.dll", EntryPoint = "vbGetServiceByName", SetLastError = true)]
        public extern static bool GetServiceByName(string name, ref TWildcatService service);
        [DllImport("wcvb.dll", EntryPoint = "vbRegisterService", SetLastError = true)]
        public extern static bool RegisterService(ref TWildcatService service);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool CheckNetworkAddress(int clientip);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SubmitCopyRequest(int id, string fn);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int GetNextCopyRequest();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool RemoveCopyRequest(int id);
        [DllImport("wcvb.dll", EntryPoint = "vbGetConnectionInfo", SetLastError = true)]
        public extern static bool GetConnectionInfo(int connectionid, ref TConnectionInfo ci);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool AdjustUserTime(int minutes);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool RegisterPPPAddress(int Address);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool UnregisterPPPAddress(int Address);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool GetValidPPPAddresses(ref int addrs, ref int addrlen);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool GetWildcatServerInfo(ref TWildcatServerInfo si);
        [DllImport("wcvb.dll", EntryPoint = "vbGetUserByKeyIndex", SetLastError = true)]
        public extern static bool GetUserByKeyIndex(int keynum, int idx, ref TUser u, ref int tid);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool CheckClientAddress(int clientip, string szIPFile);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool CheckMailIntegrity(int conf, int level);
        [DllImport("wcvb.dll", EntryPoint = "vbUpdateMessageFlags", SetLastError = true)]
        public extern static bool UpdateMessageFlags(ref TMsgHeader msg);
        [DllImport("wcvb.dll", EntryPoint = "vbDeleteMessageAttachment", SetLastError = true)]
        public extern static bool DeleteMessageAttachment(ref TMsgHeader msg);


        ///////////////////////////////////////////////////////////////////////////
        //! Given computer name, return the server options for the particular machine.
        //! If computer name is "" or null, it will turn the default settings for the
        //! system wide services.  If you want the current computer server settings,
        //! use GetComputerConfig(cc) instead.
        ///////////////////////////////////////////////////////////////////////////

        [DllImport("wcvb.dll", EntryPoint = "vbGetComputerConfigEx", SetLastError = true)]
        public extern static bool GetComputerConfigEx(string szComputerName, ref TComputerConfig cc);

        ///////////////////////////////////////////////////////////////////////////
        //! User Extended Database/Profile Helper Functions
        ///////////////////////////////////////////////////////////////////////////

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool ProfileDateToFileDate(string szInt64, ref FileTime ft);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool GetUserVariableDate(int id, string section, string key, ref FileTime ft);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool GetUserProfileDate(int id, string key, ref FileTime ft);

        [DllImport("wcvb.dll", EntryPoint = "vbGetUserProfileDateStr", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.AnsiBStr)]
        public extern static string GetUserProfileDateStr(int id, string key, string pFormat);

        [DllImport("wcvb.dll", EntryPoint = "vbGetUserProfileDateStr", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.AnsiBStr)]
        public extern static string GetUserProfileTimeStr(int id, string key, string pFormat);

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetUserVariableDate(int id, string section, string key, ref FileTime ft);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetUserProfileDate(int id, string key, ref FileTime ft);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetUserProfileSystemTime(int id, string key, ref SYSTEMTIME st);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool GetUserProfileBool(int id, string key, ref int flag);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetUserProfileBool(int id, string key, int flag);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool wcCopyFileToTemp(int area, string fn);
        [DllImport("wcvb.dll", EntryPoint = "vbUpdateUserEx", SetLastError = true)]
        public extern static bool UpdateUserEx(ref TUser user, string oldpwd, string newpwd);

        ////!
        ////! 450.3 07/30/02
        ////! Wildcat! SASL functions for authentication services
        ////!
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcSASLGetMethodName(string szMethod, int dwSize, int dwIndex);
        //!
        //! Check the SASL Login credentials (user is logged in)
        //!
        [DllImport("wcvb.dll", EntryPoint = "vbWcSASLAuthenticateUser", SetLastError = true)]
        public extern static int WcSASLAuthenticateUser(TWildcatSASLContext ctx, string szFromClient, string szResponse, int dwResponseSize, TUser u);
        //!
        //! Check the SASL Login credentials (user is logged in)
        //!
        [DllImport("wcvb.dll", EntryPoint = "vbWcSASLAuthenticateUserEx", SetLastError = true)]
        public extern static int WcSASLAuthenticateUserEx(TWildcatSASLContext ctx, string szFromClient, string szResponse, int dwResponseSize, int dwCallType, string szSpeed, TUser u);

        //!
        //! Check the SASL Login credentials (user is not logged in)
        //!
        [DllImport("wcvb.dll", EntryPoint = "vbWcSASLCheckAuthentication", SetLastError = true)]
        public extern static int WcSASLCheckAuthentication(TWildcatSASLContext ctx, string szFromClient, string szResponse, int dwResponseSize);

        ////!
        ////! Get the wildcat server process running times
        ////!
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcGetProcessTimes(TWildcatProcessTimes pt);

        ////! Set the context peer address
        ////!
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool SetContextPeerAddress(int address);

        ////! Wildcat! INI File Functions. These Wildcat! INI file
        ////! functions work similar to the Win32 equivalent private
        ////! profile functions. The key difference is that Win32
        ////! INI files are local to the machine, where these Wildcat!
        ////! INI functions use server side files using the Wildcat!
        ////! file naming syntax, i.e., "wc:\data\productxyz.ini"
        ////!
        [DllImport("wcvb.dll", EntryPoint = "vbWcGetPrivateProfileString", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.AnsiBStr)]
        public extern static string WcGetPrivateProfileString(string section, string key, string def, string ini);

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcWritePrivateProfileString(string sect, string key, string value, string inifile);

        [DllImport("wcvb.dll", EntryPoint = "vbWcGetPrivateProfileSection", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.AnsiBStr)]
        public extern static string WcGetPrivateProfileSection(string section, string ini);

        ////! 451.2 07/18/04
        ////! Extended WcCreateFileEx() function returns TwcOpenFileInfo
        ////! structure. Useful when you need to open a file and obtain
        ////! file information in one single RPC call.
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int WcCreateFileEx(string fn, int access, int sharemode, int create, TwcOpenFileInfo pwcofi);

        ////! 451.5 10/04/05
        ////! GetConnectionInfoFromChallenge() function returns TConnectionInfo
        ////! for a given challenge.
        [DllImport("wcvb.dll", EntryPoint = "vbGetConnectionInfoFromChallenge", SetLastError = true)]
        public extern static bool GetConnectionInfoFromChallenge(string challenge, TConnectionInfo ci);

        ////! 451.6
        ////! DeleteUserVariable - delete extended user section or key
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool DeleteUserVariable(int id, string section, string key);

        ////! 451.9
        ////! WcCheckUserName - Return FALSE if user name has invalid characters
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcCheckUserName(string szName);

        ////! 451.9
        ////! WcSetMessageAttachments - helps prepare attachment field
        [DllImport("wcvb.dll", EntryPoint = "vbWcSetMessageAttachment", SetLastError = true)]
        public extern static bool WcSetMessageAttachment(TMsgHeader msg, string szFileName, int bCopyTo);

        ////!
        ////! WcLocalCopyToServer - copy local side file to server side wc:\ file
        ////!
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcLocalCopyToServer(string szLocal, string szServer, int msSlice);


        //! 454.12, Domain Server Functions

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool GetMakewildEx(string szDomain, bool setdomain, ref TMakewild mw);

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcSetCurrentDomain(string szDomain);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcGetCurrentDomain(ref string szDomain, int dwSize);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcGetDefaultDomain(ref string szBuffer, int dwSize);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static int WcGetDomainCount();
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool WcGetDomain(int index, ref string szDomain, int dwSize);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool   WcGetDomainConfigString(string szDomain, string szSection, string szKey, ref string szValue, int dwSize, string szDefault);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool   WcGetDomainConfigBool(string szDomain, string szSection, string szKey, ref bool bVal, bool bDef);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool   WcGetDomainConfigInt(string szDomain, string szSection, string szKey, ref int dwValue, int dwDefault);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool   WcGetDomainConfigSection(string szDomain, string szSection, ref string szBuffer, int dwBufSize, ref int dwSize);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool   WcGetHttpConfigVar(string szSection, string szKey, ref string szValue, int dwSize, string szDefault);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool   WcGetConfigFileVar(string szFile, string szSection, string szKey, ref string szValue, bool dwSize, string szDefault);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool   WcGetVirtualDomainBool(string szDomain, string szSection, string szKey, ref bool bVal, bool bDef);
        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool   WcGetVirtualDomainVar(string szDomain,string szSection,string szKey,ref string szValue, int dwSize,string szDefault);

        //! Set Context/Connection Status (activity)

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool   WcSetConnectionStatus(string activity);

        //! Get unique server guid across all clients, see structure TWildcatServerGuid
        //!

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool   WcGetWildcatServerGuid(ref TWildcatServerGuid wg);

        //! Get unique QUEUE guid, see structure TWildcatServerGuid
        //!

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool   WcGetWildcatQueueGuid(string qname, ref TWildcatServerGuid wg);

        //! Get Geographical Location Information by IP Address
        //!

        [DllImport("wcsrv2.dll", SetLastError = true)]
        public extern static bool   WcGetGeoIP(string ip, ref TWildcatGeoIP geoip, string lang);



        #endregion

        #region Public Helper Functions ...

        public static void TrimTUser(ref TUser User)
        {
            User.Address1 = User.Address1.Trim();
            User.Address2 = User.Address2.Trim();
            User.City = User.City.Trim();
            User.Company = User.Company.Trim();
            User.Country = User.Country.Trim();
            User.From = User.From.Trim();
            User.Info.Name = User.Info.Name.Trim();
            User.Info.Title = User.Info.Title.Trim();
            User.Language = User.Language.Trim();
            User.Password = User.Password.Trim();
            User.PhoneNumber = User.PhoneNumber.Trim();
            User.RealName = User.RealName.Trim();
            for (int i = 0; i < wcServerAPI.NUM_USER_SECURITY; i++)
            {
                User.Security[i].SecurityProfile = User.Security[i].SecurityProfile.Trim();
            }
        }

        #endregion
    }

} //end of root namespace

