//***********************************************************************
// (c) Copyright 1998-2025 Santronics Software, Inc. All Rights Reserved.
//***********************************************************************
// File Name : wctype.h
// version   : v10.0.500.1
//
// Revision History:
// Build  Date     Author  Comments
// -----  -------- ------  -------------------------------
// 454.15 07/17/24 HLS     Cleaned up
// 500.1  08/11/25 HLS     Start of wc10
////////////////////////////////////////////////////////////////////////

#ifndef __WCTYPE_H
#define __WCTYPE_H

#if !defined(WIN32) && !defined(__MIDL__)

#undef BOOL
#define BOOL long

#ifndef MAX_PATH
const DWORD MAX_PATH = 260;
#endif

#ifndef _FILETIME_
struct FILETIME {
  DWORD dwLowDateTime;
  DWORD dwHighDateTime;
};
#endif

#endif // WIN32

#ifdef __MIDL__

cpp_quote("#ifndef WINVER")

//+ Group: Client Structures

typedef struct tagFILETIME {
  DWORD dwLowDateTime;
  DWORD dwHighDateTime;
} FILETIME;

typedef struct tagWIN32_FIND_DATA {
  DWORD dwFileAttributes;
  FILETIME ftCreationTime;
  FILETIME ftLastAccessTime;
  FILETIME ftLastWriteTime;
  DWORD nFileSizeHigh;
  DWORD nFileSizeLow;
  DWORD dwReserved0;
  DWORD dwReserved1;
  char cFileName[ MAX_PATH ];
  char cAlternateFileName[ 14 ];
} WIN32_FIND_DATA;

#ifndef HANDLE
#define HANDLE unsigned long
#endif

#ifndef ULONG
#define ULONG unsigned long
#endif

cpp_quote("#endif // WINVER")

#endif // __MIDL__

//////////////////////////////////////////////////////////////////

const DWORD WILDCAT_FRAMEWORK_VERSION    = 2;
const DWORD WILDCAT_MKTG_VERSION         = 10;
#define WILDCAT_MARKETING_VERSION        "10.0"

const DWORD WILDCAT_COMPONENT_ICP        = 0x00000001;
const DWORD WILDCAT_COMPONENT_SSL        = 0x00000002;
const DWORD WILDCAT_COMPONENT_PCI        = 0x00000004;

//!--------------------------------------------------------------
//! SPECIAL NOTE ABOUT LONG vs SHORT FILE NAMES
//!
//! - v5.5 - File Database Only
//!
//!    MAX_PATH long file name support was implemented in v5.5
//!    Database conversion was required since TFileRecord size
//!    was changed
//!
//! - v6.1.451.9 - Message Database Only (Native storage)
//!
//!   A 80 (79 + 1 null) semi-long file name was implemented
//!   in v6.1.451.9 for TMsgHeader.Attachment.  The old
//!   short file name field was renamed to TMsgHeader.AttachmentSFN
//!
//!   Developers can use a sizeof(TMsgHeader.Header) check to see
//!   what is the current size of the API.
//!
//!--------------------------------------------------------------

const DWORD SIZE_SHORT_FILE_NAME          = 16;
const DWORD SIZE_LONG_FILE_NAME           = MAX_PATH;
const DWORD SIZE_ATTACH_FILE_NAME         = 80;
const DWORD SIZE_PROGRAM_NAME             = 64;

const DWORD CHANNEL_MESSAGE_HEADER_SIZE   = 12;
const DWORD NUM_USER_SECURITY             = 10;
const DWORD MAX_CHANNEL_MESSAGE_SIZE      = 500;
const DWORD MAX_FILE_LONGDESC_LINES       = 15;
const DWORD MAX_LANGUAGE_SUBCOMMAND_CHARS = 100;
const DWORD MAX_MENU_ITEMS                = 40;
const DWORD MAX_USER_NAME                 = 28;
const DWORD SIZE_CALLTYPE                 = 32;
const DWORD SIZE_COMPUTER_NAME            = 16;
const DWORD SIZE_CONFERENCEGROUP_NAME     = 32;
const DWORD SIZE_CONFERENCE_ECHOTAG       = 64;
const DWORD SIZE_CONFERENCE_NAME          = 60;
const DWORD SIZE_DOMAIN_NAME              = 64;
const DWORD SIZE_DOOR_NAME                = 40;
const DWORD SIZE_ENCODED_PASSWORD         = 20;
const DWORD SIZE_EXTENSION                = 4;
const DWORD SIZE_FILEAREA_NAME            = 32;
const DWORD SIZE_FILEGROUP_NAME           = 32;
const DWORD SIZE_FILE_DESCRIPTION         = 76;
const DWORD SIZE_FILE_LONGDESC            = 80;
const DWORD SIZE_LANGUAGE_DESCRIPTION     = 72;
const DWORD SIZE_LANGUAGE_NAME            = 12;
const DWORD SIZE_MAKEWILD_BBSNAME         = 52;
const DWORD SIZE_MAKEWILD_CITY            = 32;
const DWORD SIZE_MAKEWILD_FIRSTCALL       = 28;
const DWORD SIZE_MAKEWILD_PACKETID        = 12;
const DWORD SIZE_MAKEWILD_PHONE           = 28;
const DWORD SIZE_MAKEWILD_REGSTRING       = 8;
const DWORD SIZE_MENUITEM_COMMAND         = 48;
const DWORD SIZE_MENUITEM_DESCRIPTION     = 32;
const DWORD SIZE_MENUITEM_SELECTION       = 16;
const DWORD SIZE_MENU_DESCRIPTION         = 40;
const DWORD SIZE_MESSAGE_NETWORK          = 12;
const DWORD SIZE_MESSAGE_SUBJECT          = 72;
const DWORD SIZE_MODEM_NAME               = 32;
const DWORD SIZE_MODEM_STRING             = 64;
const DWORD SIZE_NODECONFIG_COMPUTER      = 16;
const DWORD SIZE_NODECONFIG_PORTNAME      = 16;
const DWORD SIZE_NODEINFO_ACTIVITY        = 32;
const DWORD SIZE_NODEINFO_LASTCALLER      = 48;
const DWORD SIZE_NODEINFO_SPEED           = 8;
const DWORD SIZE_PASSWORD                 = 32;
const DWORD SIZE_SASL_NAME                = 32;
const DWORD SIZE_SECURITY_NAME            = 24;
const DWORD SIZE_SERVERSTATE_PORT         = 80;
const DWORD SIZE_SERVICE_NAME             = 64;
const DWORD SIZE_SYSTEMPAGE_LINES         = 3;
const DWORD SIZE_SYSTEMPAGE_TEXT          = 80;
const DWORD SIZE_USER_ADDRESS             = 32;
const DWORD SIZE_USER_FROM                = 32;
const DWORD SIZE_USER_NAME                = 72;
const DWORD SIZE_USER_PHONE               = 16;
const DWORD SIZE_USER_STATE               = 16;
const DWORD SIZE_USER_TITLE               = 12;
const DWORD SIZE_USER_ZIP                 = 12;
const DWORD SIZE_VOLUME_NAME              = 16;

//!--------------------------------------------------------------------
//! Access Profiles Class Object identifiers (COID).
//! COIDS are used to identify a group/class of objects.
//!--------------------------------------------------------------------

const DWORD MASK_OBJECTCLASS            = 0xFF000000;
const DWORD OBJECTCLASS_RIGHTS          = 0x01000000;
const DWORD OBJECTCLASS_CONFERENCE      = 0x02000000;
const DWORD OBJECTCLASS_CONFERENCEGROUP = 0x03000000;
const DWORD OBJECTCLASS_FILEAREA        = 0x04000000;
const DWORD OBJECTCLASS_FILEGROUP       = 0x05000000;
const DWORD OBJECTCLASS_DOOR            = 0x06000000;
const DWORD OBJECTCLASS_MENU            = 0x07000000;
const DWORD OBJECTCLASS_CODE            = 0x08000000;
const DWORD OBJECTCLASS_CLIENT          = 0x09000000;
const DWORD OBJECTCLASS_SAPPHIRE_QUERY  = 0x0a000000;
const DWORD OBJECTCLASS_CHAT_CHANNEL    = 0x0b000000;
const DWORD OBJECTCLASS_RADIUS_CLIENT   = 0x0c000000;
const DWORD OBJECTCLASS_DOMAINS         = 0x0d000000;

//!--------------------------------------------------------------------
//! Access Profiles Object identifiers (OID).
//! Use with GetObjectFlags() during user sessions to determine if
//! logged in user has access to specific functionalities identified
//! by the OIDs
//!--------------------------------------------------------------------

const DWORD OBJECTID_BULLETINS_OPTIONAL          = OBJECTCLASS_RIGHTS + 1;
const DWORD OBJECTID_CHANGE_PHONE                = OBJECTCLASS_RIGHTS + 2;
//const DWORD OBJECTID_CHANGE_ALIAS              = OBJECTCLASS_RIGHTS + 3;
const DWORD OBJECTID_CHANGE_BIRTHDATE            = OBJECTCLASS_RIGHTS + 4;
const DWORD OBJECTID_QWK_ALLOW_BULLETINS         = OBJECTCLASS_RIGHTS + 5;
const DWORD OBJECTID_QWK_ALLOW_NEWS              = OBJECTCLASS_RIGHTS + 6;
const DWORD OBJECTID_QWK_ALLOW_FILES             = OBJECTCLASS_RIGHTS + 7;
const DWORD OBJECTID_QWK_DETAIL_DOWNLOAD         = OBJECTCLASS_RIGHTS + 8;
const DWORD OBJECTID_QWK_CHECK_DUPES             = OBJECTCLASS_RIGHTS + 9;
const DWORD OBJECTID_QWK_SAVE_PACKETS            = OBJECTCLASS_RIGHTS + 10;
const DWORD OBJECTID_MASTER_SYSOP                = OBJECTCLASS_RIGHTS + 11;
const DWORD OBJECTID_RATIO_ACTION                = OBJECTCLASS_RIGHTS + 12;
const DWORD OBJECTID_ALLOW_FAST_LOGIN            = OBJECTCLASS_RIGHTS + 13;
// Added back in 449.5, but not used yet. This is a common attribute
// that should be supported at the Access Profile level.
const DWORD OBJECTID_ALLOW_OVERWRITE_FILES       = OBJECTCLASS_RIGHTS + 14;
const DWORD OBJECTID_SHOW_PASSWORD_FILES         = OBJECTCLASS_RIGHTS + 15;
const DWORD OBJECTID_ALLOW_OFFLINE_FILE_REQUESTS = OBJECTCLASS_RIGHTS + 16;
const DWORD OBJECTID_ALLOW_UPLOAD_OVER_TIME      = OBJECTCLASS_RIGHTS + 17;
const DWORD OBJECTID_ALLOW_DOWNLOAD_OVER_TIME    = OBJECTCLASS_RIGHTS + 18;
//const DWORD OBJECTID_ALLOW_DISTRIBUTED_MAIL      = OBJECTCLASS_RIGHTS + 19;
const DWORD OBJECTID_ALLOW_UPLOADER_MODIFY_FILE  = OBJECTCLASS_RIGHTS + 20;
//const DWORD OBJECTID_ALLOW_VIEW_SCREENS          = OBJECTCLASS_RIGHTS + 21;
//const DWORD OBJECTID_ALLOW_NODE_INPUT            = OBJECTCLASS_RIGHTS + 22;
//const DWORD OBJECTID_ALLOW_TIME_CHANGE           = OBJECTCLASS_RIGHTS + 23;
//const DWORD OBJECTID_ALLOW_SECURITY_CHANGE       = OBJECTCLASS_RIGHTS + 24;
const DWORD OBJECTID_QWK_NETSTATUS               = OBJECTCLASS_RIGHTS + 26;
const DWORD OBJECTID_SYSOP_READ_PRIVATE_MAIL     = OBJECTCLASS_RIGHTS + 27;
const DWORD OBJECTID_ALLOW_INTERNET_EMAIL        = OBJECTCLASS_RIGHTS + 28;
const DWORD OBJECTID_ALLOW_ANY_TELNET            = OBJECTCLASS_RIGHTS + 29;
const DWORD OBJECTID_ALLOW_ANY_FTP               = OBJECTCLASS_RIGHTS + 30;
const DWORD OBJECTID_ALLOW_HTTP_PROXY            = OBJECTCLASS_RIGHTS + 31;
const DWORD OBJECTID_ALLOW_ALL_IP                = OBJECTCLASS_RIGHTS + 32;
const DWORD OBJECTID_ALLOW_DEFAULT_IP            = OBJECTCLASS_RIGHTS + 33;
const DWORD OBJECTID_ALLOW_PPP                   = OBJECTCLASS_RIGHTS + 34;
const DWORD OBJECTID_IGNORE_TIME_ONLINE          = OBJECTCLASS_RIGHTS + 35;
const DWORD OBJECTID_IGNORE_IDLE_TIME            = OBJECTCLASS_RIGHTS + 36;
const DWORD OBJECTID_ALLOW_SMTP_AUTH             = OBJECTCLASS_RIGHTS + 37;
const DWORD OBJECTID_ALLOW_NNTP_ACCESS           = OBJECTCLASS_RIGHTS + 38;
const DWORD OBJECTID_USERBIN_ACCESS              = OBJECTCLASS_RIGHTS + 39;
const DWORD OBJECTID_ALLOW_FTP_ACCESS            = OBJECTCLASS_RIGHTS + 40;
const DWORD OBJECTID_ALLOW_WEB_ACCESS            = OBJECTCLASS_RIGHTS + 41;
const DWORD OBJECTID_ALLOW_TELNET_ACCESS         = OBJECTCLASS_RIGHTS + 42;
const DWORD OBJECTID_CHANGE_EMAILADDRESS         = OBJECTCLASS_RIGHTS + 43;
const DWORD OBJECTID_CHANGE_SMTPFORWARD          = OBJECTCLASS_RIGHTS + 44;
const DWORD OBJECTID_ALLOW_CC_GROUPS             = OBJECTCLASS_RIGHTS + 45;
const DWORD OBJECTID_ALLOW_IMAP_AUTH             = OBJECTCLASS_RIGHTS + 37; // 46
//---------------------------------------------------------------------------------

const DWORD OBJECTID_PROTOCOL_ACCESS             = OBJECTCLASS_RIGHTS + 0x00010000; // plus protocol number
const DWORD OBJECTID_NODE_ACCESS                 = OBJECTCLASS_RIGHTS + 0x00020000; // plus node number

const DWORD OBJECTFLAGS_CONFERENCE_JOIN  = 0x00000001;
const DWORD OBJECTFLAGS_CONFERENCE_READ  = 0x00000002;
const DWORD OBJECTFLAGS_CONFERENCE_WRITE = 0x00000004;
const DWORD OBJECTFLAGS_CONFERENCE_SYSOP = 0x00000008;

const DWORD OBJECTFLAGS_FILEAREA_LIST     = 0x00000001;
const DWORD OBJECTFLAGS_FILEAREA_DOWNLOAD = 0x00000002;
const DWORD OBJECTFLAGS_FILEAREA_UPLOAD   = 0x00000004;
const DWORD OBJECTFLAGS_FILEAREA_SYSOP    = 0x00000008;

//!
//! MessageSearch() search attributes
//!

const DWORD MSF_FORWARD = 0x00000001;
const DWORD MSF_FROM    = 0x00000002;
const DWORD MSF_TO      = 0x00000004;
const DWORD MSF_SUBJECT = 0x00000008;
const DWORD MSF_BODY    = 0x00000010;

//!
//! wcBASIC Telnet connection options
//!

const DWORD CONNECT_RAW          = 0;
const DWORD CONNECT_TELNET_ASCII = 1;
const DWORD CONNECT_TELNET_7BIT  = 2;
const DWORD CONNECT_TELNET_8BIT  = 3;

//!
//! User Database Function Keys
//!

const int UserIdKey       = 0;
const int UserNameKey     = 1;
const int UserLastNameKey = 2;
const int UserSecurityKey = 3;
const int UserLastCallKey = 4;    // 452.1f

//!
//! Files Database Function Keys
//!

const int FileNameAreaKey = 0;
const int FileAreaNameKey = 1;
const int FileAreaDateKey = 2;
const int FileUploaderKey = 3;
const int FileDateAreaKey = 4;

// DECLARE_HANDLE(WCHANDLE);
struct WCHANDLE__ { int unused; }; typedef struct WCHANDLE__ *WCHANDLE;
#define INVALID_WCHANDLE_VALUE  WCHANDLE(INVALID_HANDLE_VALUE)

#ifndef WIN32
#define __stdcall
#endif

//!
//! Channel message structure for Callbacks
//!

typedef struct tagTChannelMessage {
  DWORD Channel;
  DWORD SenderId;
  WORD UserData;
  WORD DataSize;
#ifdef __MIDL__
  [length_is(DataSize)]
#endif
  BYTE Data[MAX_CHANNEL_MESSAGE_SIZE];
} TChannelMessage;

//!
//! Data structure for Paging Channel Events
//! passed via TChannelMessage.Data field
//!

typedef struct tagTPageMessage {
   char From[28];
   char message[3][80];
   BOOL InviteToChat;
} TPageMessage;

//!
//! Data structure for Chat Channel Events
//! passed via TChannelMessage.Data field
//!

typedef struct tagTChatMessage {
      char From[28];
      char Text[256];
      BYTE Whisper;
} TChatMessage;

typedef DWORD (__stdcall *TWildcatCallback)(DWORD userdata, const TChannelMessage *msg);

// changes to this need to be reflected in dbname.cpp
typedef struct tagTObjectName {
  DWORD Status;
  DWORD ObjectId;
  DWORD Number;
  char Name[MAX_PATH];
} TObjectName;

//$SDK(0)
//!
//! TPackerRec is Obselete
//!

const DWORD SIZE_PACKER_DESCRIPTION = 32;
const DWORD SIZE_PACKER_COMMAND     = 40;
const DWORD MAX_PACKER_COUNT        = 10;

typedef struct tagTPackerRec {
  DWORD Letter; // really a char
  char Description[SIZE_PACKER_DESCRIPTION];
  char Extension[SIZE_EXTENSION];
  char Packer[SIZE_PACKER_COMMAND];
  char Unpacker[SIZE_PACKER_COMMAND];
} TPackerRec;

//$SDK(1)

//!
//! System Operation Type
//!

enum {saOpen,                 // Open, accounts created
      saClosed,               // Closed, accounts must exist
      saClosedQuestionnaire,  // Closed, run questionaire
      saClosedValidation      // Closed, non-validated accounts Created
      };

enum {dusNone, dusAsk, dusAllow};


enum {mhcUpperCase, mhcLowerCase, mhcAsIs};

//!
//! TMakeWild Structure (Main Configuration File)
//! See GetMakewild() function
//!

typedef struct tagTWildcatTimeouts {
  WORD dwVersion;       // should be 0x0603 after initialization
  WORD dwRevision;      // should be 3      after initialization
  DWORD Web;
  DWORD WebQues;
  DWORD Telnet;
  DWORD TelnetLogin;
  DWORD Ftp;
  DWORD wcPPP;
  DWORD wcNAV;
  DWORD Pop3;
  DWORD Pop3Login;
  DWORD FtpLogin;
  DWORD FtpData;
  char Reserved[76];
} TWildcatTimeouts;
//

//!
//! LogPeriod options
//!

typedef enum {
      wclogNone   = 0,
      wclogHourly,
      wclogDaily,
      wclogWeekly,
      wclogMonthly,
      wclogUnlimitedSize,
      wclogMaxSize} TWildcatLogPeriod;

typedef struct tagTWildcatLogOptions {
  BOOL EnableSessionTrace;
  TWildcatLogPeriod LogPeriod;
  DWORD dwMaxSize;
  DWORD dwVerbosity;   // 0 - normal, 1 - enabled
  BYTE Reserved[16];
} TWildcatLogOptions;

typedef struct tagTHttpAuthOptions {
    BOOL AllowPlainText;        // = 0;
    BOOL AllowPlainTextWithSSL; // = 1;
    BOOL AllowPlainMD5;         // = 1;
    BOOL AllowDigest;           // = 1;
    BOOL AllowWcChallenge;      // = 1;
    BOOL RequireSSL;            // = 0;
} THttpAuthOptions;

typedef struct tagTWildcatHttpd {
  WORD  dwVersion;           // should be 0x0600 after initialization
  WORD  dwRevision;          // should be 1      after initialization
  BOOL _CommonLogFile;       // deprecated
  BOOL _DeutschIVW;          // deprecated
  TWildcatLogOptions LogOptions;
  DWORD dwOptions;
  DWORD MaximumBandWidth;    // Bandwidth Throttling options
  DWORD SendBufferSize1K;    // Bandwidth Throttling options
  DWORD RcvdBufferSize1K;    // Bandwidth Throttling options
  BOOL  TrackPerformance;    // Bandwidth Throttling options
  THttpAuthOptions HttpAuth;
  BOOL  EnablePCISession;
  char Reserved[20];
} TWildcatHttpd;

typedef struct tagTWildcatSMTP {
  WORD  dwVersion;      // should be 0x0800 after initialization with 454.15
  WORD  dwRevision;     // should be 1 with 454.15
  DWORD port;
  WORD sendthreads;
  WORD acceptthreads;
  DWORD dwOptions;      // see smtpXXXXX bit options
  BOOL acceptonly;
  DWORD retries;
  DWORD retrywait;
  char smarthost[52];
  DWORD sizelimit;
  BOOL localonly;
  BOOL MAPSRBL;
  char MAPSRBLServer[52];
  BOOL ESMTP;
  BOOL reqauth;          // [_] Require AUTH for all Connections
  BOOL VRFY;
  BOOL AllowRelay;       // default FALSE;
  BOOL CheckRCPT;        // default FALSE;
  BOOL EnableBadFilter;  // default TRUE
  BOOL RequireMX;        // default FALSE
  BOOL RequireHostMatch; // default FALSE
} TWildcatSMTP;

typedef struct tagTWildcatNNTP {
  WORD  dwVersion;       // should be 0x0506 after initialization
  WORD  dwRevision;      // should be 4
  DWORD dwPort;
  DWORD dwOptions;
  DWORD MaxCrossPost;
  TWildcatLogOptions LogOptions;
  char Reserved[80];
} TWildcatNNTP;

typedef struct tagTWildcatPOP3 {
  WORD  dwVersion;      // should be 0x0602 after initialization
  WORD  dwRevision;     // should be 8
  BOOL  EnablePopBeforeSmtp;
  DWORD dwPopBeforeSmtpTimeout;
  DWORD dwOptions;
  TWildcatLogOptions LogOptions;
  DWORD MaximumBandWidth;   // Bandwidth Throttling options
  DWORD SendBufferSize1K;
  DWORD RcvdBufferSize1K;
  BOOL  TrackPerformance;
  char Reserved[64];
} TWildcatPOP3;
//

typedef struct tagTWildcatTelnet {
  WORD  dwVersion;      // should be 0x0602 after initialization
  WORD  dwRevision;     // should be 8
  DWORD dwOptions;
  TWildcatLogOptions LogOptions;
  DWORD MaximumBandWidth;   // Bandwidth Throttling options
  DWORD SendBufferSize1K;
  DWORD RcvdBufferSize1K;
  BOOL  TrackPerformance;
  char Reserved[72];
} TWildcatTelnet;


typedef enum {
      listUnixFormat   = 0,
      listMSDOSFormat
} TFtpListTextFormat;

typedef struct tagTWildcatFTP {
  WORD  dwVersion;          // should be 0x0506 after initialization
  WORD  dwRevision;         // should be 4
  BOOL  AllowAnonymous;
  BOOL  ShowFileGroups;
  BOOL  UseUnderScore;
  BOOL  UseSingleAreaChange;
  DWORD MaxAnonymousConnects;
  TWildcatLogOptions LogOptions;
  TFtpListTextFormat ListFormat;
  DWORD dwOptions;                 // see ftpXXXXX bit options
  DWORD MaximumBandWidth;          // Bandwidth Throttling options
  DWORD SendBufferSize1K;
  DWORD RcvdBufferSize1K;
  BOOL  TrackPerformance;
  DWORD MaxConnects;
  char Reserved[44];
} TWildcatFTP;
//

typedef struct tagTMakewild {
  DWORD Version;
  char BBSName[SIZE_MAKEWILD_BBSNAME];
  char SysopName[MAX_USER_NAME];
  char City[SIZE_MAKEWILD_CITY];
  char Phone[SIZE_MAKEWILD_PHONE];
  char FirstCall[SIZE_MAKEWILD_FIRSTCALL];
  char PacketId[SIZE_MAKEWILD_PACKETID];
  char RegString[SIZE_MAKEWILD_REGSTRING];
  DWORD SystemAccess;
  DWORD MaxLoginAttempts;
  BOOL FreeFormPhone;
  BOOL HideAnonFtpPassword;
  BOOL LogonLanguagePrompt;
  BOOL Assume8N1;
  BOOL LoginAskLocation;
  char NewUserSecurity[SIZE_SECURITY_NAME];
  char DefaultExt[SIZE_EXTENSION];
  char ThumbnailFile[SIZE_SHORT_FILE_NAME];
  char OldDoorPath[MAX_PATH];
  BOOL _EnableHttpProxy;                 // deprecated
  DWORD SmtpMaxAcceptLoad;
  char DateFormat[24];
  char TimeFormat[24];
  char DefaultDomain[SIZE_DOMAIN_NAME];
  char Reserved[12];
  TWildcatTelnet TelnetConfig;
  TWildcatFTP  FTPConfig;
  TWildcatPOP3 POP3Config;
  TWildcatLogOptions MAILLogOptions;
  char Reserved2[32];
  char Reserved1[32];
  TWildcatLogOptions SMTPLogOptions;
  TWildcatNNTP NNTPConfig;
  BOOL AllowLogonEmail;
  BOOL CaseSensitivePasswords;
  DWORD MsgHeaderCaseMode;                  // see mhcXXXXX flags
  BOOL SpamAllowAuth;
  TWildcatSMTP SMTPConfig;
  TWildcatHttpd HttpdConfig;
  TWildcatTimeouts Timeouts;
  BYTE DefaultColors[28];
  DWORD ExcludeBulletins[40];
  DWORD InstalledComponents;
  BOOL _ResolveHostnames;                   // deprecated
  char BuildDate[16];
  char DomainName[SIZE_DOMAIN_NAME];
  BOOL WindowsCharset;
  BOOL LogonUserNameOnly;
} TMakewild;

typedef struct tagTWildcatComputerIpPort {
    DWORD dwPort;
    DWORD dwIpAddress;
} TWildcatComputerIpPort;

typedef struct tagTComputerConfig {
  char Name[SIZE_COMPUTER_NAME];
  char DoorPath[MAX_PATH];
  char CgiPath[MAX_PATH];
  DWORD HttpPort;
  DWORD FtpPort;
  char WWWHostname[80];
  DWORD Servers;        // values from CALLTYPE_xxxxxxxxxxxx
  DWORD HttpProxyPort;

  WORD  dwVersion;      // should be 0x0506 after initialization
  WORD  dwRevision;     // should be 1
  TWildcatComputerIpPort ipportHttp;
  TWildcatComputerIpPort ipportFtp;
  TWildcatComputerIpPort ipportPop3;
  TWildcatComputerIpPort ipportTelnet;
  TWildcatComputerIpPort ipportSmtp;
  TWildcatComputerIpPort ipportNntp;

  BYTE Reserved[332];
  DWORD TelnetPort;
  DWORD Pop3Port;
} TComputerConfig;

enum {
  pNone,
  pAscii,
  pXmodem,
  pXmodemCRC,
  pXmodem1K,
  pXmodem1KG,
  pYmodem,
  pYmodemG,
  pKermit,
  pZmodem,
  NumProtocols
};

enum {fiaAllow, fiaLogoff, fiaLockout};

// Returned by CheckClientAddressEx()
//
enum {ipfilterDeny,ipfilterAllow,ipfilterNone,ipfilterBlock};
//

//!
//! TWildcatPOP3.dwOptions Bit Flags
//!

const DWORD pop3MarkRcvd    = 0x0001;   //! Mark downloads as received
const DWORD pop3HonorRR     = 0x0002;   //! Honor Return Request
const DWORD pop3ResolveHost = 0x0020;   //! resolve host name

//!
//! TWildcatSMTP.dwOptions Bit Flags
//!

const DWORD smtpBit0         = 0x0001;   //! ignore this bit
const DWORD smtpRcvdBin      = 0x0002;   //! Enable Receiver Bin
const DWORD smtpNoMXOnce     = 0x0004;   //! Enable RFC821 No MX try once rule
const DWORD smtpIpFilter     = 0x0008;   //! Enable IP Filter
const DWORD smtpIncMXTries   = 0x0010;   //! MXs included in total attempts
const DWORD smtpResolveHost  = 0x0020;   //! resolve host name
const DWORD smtpDisableETRN  = 0x0040;   //! Disable ETRN command
const DWORD smtpAllowLocal   = 0x0080;   //! Allow (auth) Local Email
const DWORD smtpCheckHello   = 0x0100;   //! Enable Helo/Ehlo Check
const DWORD smtpEnableWCSAP  = 0x0200;   //! Enable WCSAP
const DWORD smtpEnableSFHook = 0x0400;   //! Enable SMTPFILTER Hook
const DWORD smtpUsePort587   = 0x0800;   //! Submit Protocol
const DWORD smtpReadBadFilter= 0x1000;   //! Read only BadFilter (don't add)
const DWORD smtpReqSSLAuth   = 0x2000;   //! Require SSL for SMTP AUTH

//!
//! TWildcatFTP.dwOptions Bit Flags
//!

const DWORD ftpBit0          = 0x0001;   //! ignore this bit
const DWORD ftpUnixFileAge   = 0x0002;   //! Use Unix-style File Age Range
const DWORD ftpUseFtpLimit   = 0x0004;   //! Use Security Profile Limits
const DWORD ftpCheckForDIZ   = 0x0008;   //! Check for DIZ in zip uploads
const DWORD ftpResolveHost   = 0x0020;   //! resolve host name
const DWORD ftpDisableIndex  = 0x0040;   //! Disable Index Files

//!
//! Password Bit Options for Security Profile and User Record
//!

const DWORD pwdChangeForce     = 0x0001;   // Force change at next logon
const DWORD pwdChangeDisallow  = 0x0002;   // Do not allow password change
const DWORD pwdChangeExpire    = 0x0004;   // Force Change when pwd expires
const DWORD pwdExpireLockout   = 0x0008;   // Lockout account when pwd expires
const DWORD pwdAttemptsLockout = 0x0010;   // TBD. Lockout for max pwds. FUTURE.

//!
//! TWildcatNNTP.dwOptions Bit Flags
//!

const DWORD nntpAllowAnony     = 0x0001;   //! Allow Anonymous
const DWORD nntpResolveHost    = 0x0020;   //! resolve host name

//!
//! TWildcatHttpd.dwOptions Bit Flags
//!

const DWORD httpEnableProxy    = 0x0001;   //! Enable http proxy
const DWORD httpCommonLogFile  = 0x0002;   //! Enable Common Log File
const DWORD httpDeutschIVW     = 0x0004;   //! Enable DeutschIVW
const DWORD httpResolveHost    = 0x0020;   //! resolve host name
const DWORD httpEnableChunking = 0x0008;   //! resolve host name

//!
//! TWildcatTelnet.dwOptions Bit Flags
//!

const DWORD telnetEnableRLogin   = 0x0001;   //! Enable rlogin
const DWORD telnetResolveHost    = 0x0020;   //! resolve host name

//!
//! Structure and constants used for User's Logon Hours
//! Profile Data
//!

typedef struct tagTLogonHours {
    DWORD day[7];                  // size 28
} TLogonHours;

const DWORD  lh12am              = 0x00000001;
const DWORD  lh1am               = 0x00000002;
const DWORD  lh2am               = 0x00000004;
const DWORD  lh3am               = 0x00000008;
const DWORD  lh4am               = 0x00000010;
const DWORD  lh5am               = 0x00000020;
const DWORD  lh6am               = 0x00000040;
const DWORD  lh7am               = 0x00000080;
const DWORD  lh8am               = 0x00000100;
const DWORD  lh9am               = 0x00000200;
const DWORD  lh10am              = 0x00000400;
const DWORD  lh11am              = 0x00000800;
const DWORD  lh12pm              = 0x00001000;
const DWORD  lh1pm               = 0x00002000;
const DWORD  lh2pm               = 0x00004000;
const DWORD  lh3pm               = 0x00008000;
const DWORD  lh4pm               = 0x00010000;
const DWORD  lh5pm               = 0x00020000;
const DWORD  lh6pm               = 0x00040000;
const DWORD  lh7pm               = 0x00080000;
const DWORD  lh8pm               = 0x00100000;
const DWORD  lh9pm               = 0x00200000;
const DWORD  lh10pm              = 0x00400000;
const DWORD  lh11pm              = 0x00800000;
const DWORD  lhAllHours          = 0x00FFFFFF;
const DWORD  lhSun               = 0x01;
const DWORD  lhMon               = 0x02;
const DWORD  lhTue               = 0x04;
const DWORD  lhWed               = 0x08;
const DWORD  lhThu               = 0x10;
const DWORD  lhFri               = 0x20;
const DWORD  lhSat               = 0x40;
const DWORD  lhAllDays           = 0x7F;
const DWORD  lhStartofWeek       = lhSun;   // based on Win32 Sun = 0
const DWORD  lhEndofWeek         = lhSat;

typedef struct tagTSecurityProfile {
  char Name[SIZE_SECURITY_NAME];
  char ExpiredName[SIZE_SECURITY_NAME];
  char DisplayFileName[SIZE_SHORT_FILE_NAME];
  char DoorSysProfileName[SIZE_SECURITY_NAME];
  char MenuDisplaySet[SIZE_SHORT_FILE_NAME];
  DWORD DailyTimeLimit;
  DWORD PerCallTimeLimit;
  DWORD VerifyPhoneInterval;
  DWORD VerifyBirthdateInterval;
  DWORD FailedInfoAction;
  DWORD MaxDownloadCountPerDay;
  DWORD DownloadRatioLimit;
  DWORD MaxDownloadKbytesPerDay;
  DWORD DownloadKbytesRatioLimit;
  DWORD UploadTimeCredit;
  DWORD ExpireDays;
  WORD PasswordOptions;                  // Password Options
  WORD PasswordExpireDays;               // Password Expiration Days
  DWORD FtpSpaceKbytes;
  char EmailDomainName[SIZE_DOMAIN_NAME];
  DWORD MaximumLogons;
  BOOL RestrictedHours;
  TLogonHours LogonHours;
} TSecurityProfile;

enum {
  mtNormalPublicPrivate,
  mtNormalPublic,
  mtNormalPrivate,
  mtFidoNetmail,
  mtEmailOnly,
  mtUsenetNewsgroup,
  mtUsenetNewsgroupModerated,
  mtInternetMailingList,
  mtFidoEcho,
  mtListServeForum,
// mtUserEmail is similar to mtInternetMailingList for single user email
  mtUserEmail,
  mtEND = 256
};

enum {vnYes, vnNo, vnPrompt};

//!
//! The following maXXXXXXXXX bit flags are used in the
//! TConfDesc.Options field.
//!

const DWORD maAllowMailSnooping = 0x00000001;   // non-sysop can snoop mail
const DWORD maPreserveMime      = 0x00000002;   // Conference raw storage
const DWORD maAllowReplyOnly    = 0x00000004;   // 451.6, User can reply only
const DWORD maAllowMacros       = 0x00000008;   // 452.1, Allow User macros
const DWORD maAllowMsgDelete    = 0x00000010;   // 452.2, Allow User delete
const DWORD maAllowDupes        = 0x00000020;   // 452.3, No Conference dupe checking

//!
//! Option for TConfDesc.AuthorType field. This will define the
//! conference option for how the From field will be defined when
//! a message is created.
//!

enum {
  authorDefaultName,           // default logic,
  authorForceUserName,         // force the user name
  authorForceAliasName,        // force the user's alias (profile string)
  authorAllowBoth,             // allow either the user or alias
  authorAnonymousName          // anonymous from name (any name allowed)
};

typedef struct tagTConfDesc {
  DWORD ObjectId;
  DWORD Number;
  char Name[SIZE_CONFERENCE_NAME];
  char Reserved1[16];
  char ConferenceSysop[MAX_USER_NAME];
  char EchoTag[SIZE_CONFERENCE_ECHOTAG];
  char ReplyToAddress[SIZE_USER_NAME];
  char Distribution[SIZE_USER_NAME];
  DWORD MailType;
  BOOL PromptToKillMsg;
  BOOL PromptToKillAttach;
  BOOL AllowHighAscii;
  BOOL AllowCarbon;
  BOOL AllowReturnReceipt;
  BOOL LongHeaderFormat;
  BOOL AllowAttach;
  BOOL ShowCtrlLines;
  DWORD ValidateNames;
  DWORD DefaultFileGroup;
  DWORD MaxMessages;
  DWORD DaysToKeepReceivedMail;
  DWORD DaysToKeepPublicMail;
  DWORD RenumberThreshold;
  DWORD DaysToKeepExternalMail;
  BOOL  DeleteSMTPDelivered;
  BOOL  PublishAsLocalNewsGroup;
  DWORD Options;                              // see maXXXX flags
  DWORD AuthorType;                           // see authorXXXXX type
  DWORD UnixCreationTime;
  BYTE Reserved[6];
  char DefaultFromAddress[SIZE_USER_NAME];
  WORD  wVersion;                             // should be 0 at start
} TConfDesc;

typedef struct tagTShortConfDesc {
  DWORD ObjectId;
  char Name[SIZE_CONFERENCE_NAME];
  DWORD MailType;
} TShortConfDesc;

typedef struct tagTConferenceGroup {
  DWORD ObjectId;
  DWORD Number;
  char Name[SIZE_CONFERENCEGROUP_NAME];
  BYTE Reserved[24];
} TConferenceGroup;

//!
//! TFileArea.Options attributes
//!

const DWORD faIsVolume          = 0x00000001;  // Readonly: Set by server for GetFileArea()
const DWORD faAllowPrivateFiles = 0x00000002;  // Allow files with PrivateUserId != 0
const DWORD faAllowFolderWatch  = 0x00000004;  // 450.7, Watch physical folders (see wcfwatch)
const DWORD faAllowFileComments = 0x00000008;  // 453.2, Allow File Comments

typedef struct tagTFileArea {
  DWORD ObjectId;
  DWORD Number;
  char Name[SIZE_FILEAREA_NAME];
  BOOL ExcludeFromNewFiles;
  BOOL PromptForPasswordProtect;
  char FtpDirectoryName[SIZE_FILEAREA_NAME];
  DWORD Options;   // see faXXXXXXXXXX flags
} TFileArea;

typedef struct tagTShortFileArea {
  DWORD ObjectId;
  char Name[SIZE_FILEAREA_NAME];
} TShortFileArea;

typedef struct tagTFileGroup {
  DWORD ObjectId;
  DWORD Number;
  char Name[SIZE_FILEGROUP_NAME];
  BYTE Reserved[24];
} TFileGroup;

enum {dtGeneric16, dtDoor32, dtDoorway};

typedef struct tagTDoorInfo {
  DWORD ObjectId;
  char Name[SIZE_DOOR_NAME];
  char Batch[SIZE_SHORT_FILE_NAME];
  char Display[SIZE_SHORT_FILE_NAME];
  DWORD DoorMenuIndex;
  BOOL MultiUser;
  BOOL SmallDoorSys;
  DWORD DoorType;
  BYTE Reserved[36];
} TDoorInfo;

const DWORD LSC_YES   = 0;
const DWORD LSC_NO    = 1;

typedef struct tagTLanguageInfo {
  char Name[SIZE_LANGUAGE_NAME];
  char Description[SIZE_LANGUAGE_DESCRIPTION];
  char SubcommandChars[MAX_LANGUAGE_SUBCOMMAND_CHARS];
  BYTE Reserved[72];
} TLanguageInfo;

enum {aRing, aResult, aAutoAnswer};

typedef struct tagTShortModemProfile {
  BOOL UserDefined;
  char Name[SIZE_MODEM_NAME];
} TShortModemProfile;

typedef struct tagTModemProfile {
  DWORD Version;
  BOOL UserDefined;
  char Name[SIZE_MODEM_NAME];
  DWORD InitBaud;
  BOOL LockDTE;
  BOOL HardwareFlow;
  BOOL ExitOffHook;
  DWORD CarrierDelay;
  DWORD RingDelay;
  DWORD DropDtrDelay;
  DWORD PrelogDelay;
  DWORD ResultDelay;
  DWORD ResetDelay;
  DWORD AnswerMethod;
  DWORD EnableCallerId;
  char ResetCommand[SIZE_MODEM_STRING];
  char AnswerCommand[SIZE_MODEM_STRING];
  char Reserved1[SIZE_MODEM_STRING];
  char OffHook[SIZE_MODEM_STRING];
  char RingResult[SIZE_MODEM_STRING];
  char ConnectResult[SIZE_MODEM_STRING];
  char Reserved2[SIZE_MODEM_STRING]; //CallerIdResult[SIZE_MODEM_STRING];
  char ErrorFreeResult[SIZE_MODEM_STRING];
  char ExtraBaudResults[10][SIZE_MODEM_STRING];
  DWORD ExtraBaudResultNumbers[10];
  char Reserved3[SIZE_MODEM_STRING]; //DumpCommand[SIZE_MODEM_STRING];
  char InitCommand[SIZE_MODEM_STRING];
  char Reserved4[SIZE_MODEM_STRING]; //WriteCommand[SIZE_MODEM_STRING];
  char Reserved5[3][SIZE_MODEM_STRING]; //SetupCommands[3][SIZE_MODEM_STRING];
  char Reserved6[256]; //Notes[256];
  BYTE Reserved[128];
} TModemProfile;


const DWORD CALLTYPE_LOCAL    = 0x00000001;   // Local mode
const DWORD CALLTYPE_DIALUP   = 0x00000002;   // Ansi/TTY Direct Dialup Client
const DWORD CALLTYPE_TELNET   = 0x00000004;   // Ansi/TTY Telnet Client
const DWORD CALLTYPE_FTP      = 0x00000008;   // FTP client
const DWORD CALLTYPE_HTTP     = 0x00000010;   // Web client
const DWORD CALLTYPE_FRONTEND = 0x00000020;   // Connection Hook
const DWORD CALLTYPE_POP3     = 0x00000040;   // POP3 client
const DWORD CALLTYPE_SMTP     = 0x00000080;   // !!! SMTP client
const DWORD CALLTYPE_PPP      = 0x00000100;   // !!! PPP client
const DWORD CALLTYPE_RADIUS   = 0x00000200;   // !!! RADIUS client
const DWORD CALLTYPE_NNTP     = 0x00000400;   // !!! NNTP client
const DWORD CALLTYPE_HTTPS    = 0x00000800;   // !!! HTTPS client
const DWORD CALLTYPE_IMAP     = 0x00001000;   // !!! IMAP client

enum { ccAuto,ccRLSD,ccDSR };

typedef struct tagTNodeConfig {
  // The only meaningful flag in CallTypesAllowed is CALLTYPE_FRONTEND, since other
  // connection types are now handled through computer/server config.
  DWORD CallTypesAllowed;
  char ModemName[SIZE_MODEM_NAME];
  char Computer[SIZE_NODECONFIG_COMPUTER];
  char Port[SIZE_NODECONFIG_PORTNAME];
  DWORD PermanentLineID;                 // id of line for tapi
  char VirtualDoorPort[8];
  BOOL NodeDisabled;                     //
  DWORD CarrierCheckMethod;              // modems/tapi only, see ccXXXX enum
  BYTE Reserved[40];
} TNodeConfig;

const DWORD SERVERSTATE_OFFLINE = 0; // remove server from list
const DWORD SERVERSTATE_DOWN    = 1; // red
const DWORD SERVERSTATE_REFUSE  = 2; // yellow
const DWORD SERVERSTATE_UP      = 3; // green

typedef struct tagTServerState {
  DWORD OwnerId;
  char Computer[SIZE_NODECONFIG_COMPUTER];
  char Port[SIZE_SERVERSTATE_PORT];
  DWORD State;
} TServerState;

// Tmenu.Flags
const DWORD MENU_TOPLEVEL  = 0x00000002;

typedef struct tagTwcMenuItem {
  char Selection[SIZE_MENUITEM_SELECTION];
  char Description[SIZE_MENUITEM_DESCRIPTION];
  char Command[SIZE_MENUITEM_COMMAND];
  char Parameters[SIZE_MENUITEM_COMMAND];
  BYTE Reserved[4];
} TwcMenuItem;

typedef struct tagTMenu {
  DWORD ObjectId;
  char Description[SIZE_MENU_DESCRIPTION];
  char DisplayName[SIZE_SHORT_FILE_NAME];
  DWORD Flags;
  DWORD Count;
  TwcMenuItem Items[MAX_MENU_ITEMS];
  DWORD FastLoginChar; // really a char
  char SecurityEntryName[SIZE_SECURITY_NAME];
  BYTE Reserved[128];
} TMenu;

typedef struct tagTUserInfo {
  DWORD Id;
  char Name[SIZE_USER_NAME];
  char Title[SIZE_USER_TITLE];
} TUserInfo;

enum {clSessionNone, clSessionUser, clSessionSystem, clSessionConfig};

enum {nsDown, nsUp, nsSigningOn, nsLoggedIn};

typedef struct tagTwcNodeInfo {
  DWORD NodeStatus;
  DWORD ServerState;
  DWORD ConnectionId;
  char LastCaller[SIZE_NODEINFO_LASTCALLER];
  TUserInfo User;
  char UserFrom[SIZE_USER_FROM];
  BOOL UserPageAvailable;
  BOOL Reserved1; //UserAccountHidden;
  char Activity[SIZE_NODEINFO_ACTIVITY];
  char Speed[SIZE_NODEINFO_SPEED];
  FILETIME TimeCalled;
  FILETIME CurrentTime;
  DWORD Reserved2;
  DWORD NodeNumber;
  DWORD MinutesLeft;
} TwcNodeInfo;

const DWORD ucstNone        = 0;
const DWORD ucstPersonal    = 1;
const DWORD ucstPersonalAll = 2;
const DWORD ucstAll         = 3;

const DWORD ucstMask     = 0x0F;
const DWORD ucfReserved1 = 0x10;
const DWORD ucfReserved2 = 0x20;
const DWORD ucfReserved3 = 0x40;
const DWORD ucfAllAttach = 0x80;

enum {sNotDisclosed, sMale, sFemale};
enum {ePrompt, eLine, eFullScreen};
enum {hlNovice, hlRegular, hlExpert};
enum {ttAuto, ttTTY, ttAnsi};
enum {fdSingle, fdDouble, fdFull, fdAnsi};
enum {mdScroll, mdClear, mdKeepHeader};
enum {ptText, ptQwk, ptOPX};

//!
//! User validation states for ssClosedValidation setup
//!

enum {vsNone,                  // No validation required
      vsValidationRequired,    // Validation required
      vsPrevalidated,          // User has been prevalidated
      vsValidated              // User is validated
      };

typedef struct tagTUser {
  DWORD Status;
  // general info
  TUserInfo Info;
  char From[SIZE_USER_FROM];

  // security
  char Password[SIZE_PASSWORD];
  char Security[NUM_USER_SECURITY][SIZE_SECURITY_NAME];
  DWORD Reserved1; //CanReadPrivateMail;
  BOOL AllowMultipleLogins;
  BOOL LogonHoursOverride;         // data in User Profile

  // user info
  char RealName[SIZE_USER_NAME];
  char PhoneNumber[SIZE_USER_PHONE];
  char Company[SIZE_USER_ADDRESS];
  char Address1[SIZE_USER_ADDRESS];
  char Address2[SIZE_USER_ADDRESS];
  char City[SIZE_USER_ADDRESS];
  char State[SIZE_USER_STATE];
  char Zip[SIZE_USER_ZIP];
  char Country[SIZE_USER_ADDRESS];
  DWORD Sex;

  // user preferences
  DWORD Editor;
  DWORD HelpLevel;
  DWORD Protocol;
  DWORD TerminalType;
  DWORD FileDisplay;
  DWORD MsgDisplay;
  DWORD PacketType;
  DWORD LinesPerPage;
  BOOL HotKeys;
  BOOL QuoteOnReply;
  BOOL SortedListings;
  BOOL PageAvailable;
  BOOL EraseMorePrompt;
  BOOL Reserved3; //MenuClearScreen;
  char Language[SIZE_LANGUAGE_NAME];

  // history and accounting
  FILETIME LastCall;
  FILETIME LastNewFiles;
  FILETIME ExpireDate;
  FILETIME FirstCall;
  FILETIME BirthDate;
  DWORD Conference;
  DWORD MsgsWritten;
  DWORD Uploads;
  DWORD TotalUploadKbytes;
  DWORD Downloads;
  DWORD TotalDownloadKbytes;
  DWORD DownloadCountToday;
  DWORD DownloadKbytesToday;
  DWORD TimesOn;
  DWORD TimeLeftToday;
  DWORD MinutesLogged;
  long SubscriptionBalance;
  long NetmailBalance;

  // more stuff
  BOOL AccountLockedOut;
  BOOL PreserveMimeMessages;
  BOOL ShowEmailHeaders;
  FILETIME LastUpdate;          // used to refresh records
  WORD SystemFlags;             // system sfXXXXX bit flags
  WORD UserFlags;               // public ufXXXXX bit flags
  DWORD Validation;             // see vsXXXXXXXX options
  WORD PasswordOptions;         // see pwdXXXXXXX bit options
  WORD PasswordExpireDays;
  FILETIME PasswordChangeDate;
  BOOL AnonymousOnly;           // if TRUE must login with LoginAnonymous()
  BOOL AllowUserDirectory;
} TUser;

typedef struct tagTFidoAddress {
  WORD Zone;
  WORD Net;
  WORD Node;
  WORD Point;
} TFidoAddress;

//!
//! The following mfXXXXXXXXX bit flags are used in the
//! TMsgHeader.MailFlags field.  Bits are defined as required
//! for unique/special mail processing.
//!

const DWORD mfPOP3Received      = 0x01000000;   // msg was received by a POP3 client
const DWORD mfReceiptCreated    = 0x02000000;   // Return Receipt was created
const DWORD mfSmtpDelivered     = 0x04000000;   // Message was sent by smtp
const DWORD mfNNTPPost          = 0x08000000;   // Message was posted by wcNNTP
const DWORD mfIMAPPost          = 0x10000000;   // Message was posted by wcIMAP
const DWORD mfMimeSaved         = 0x00000001;   // Mime Preserved
const DWORD mfNoDupeChecking    = 0x00000002;   // No dupe checking when adding msg (450.6)
const DWORD mfNoReplying        = 0x00000004;   // No Comments/Replies allowed (451.4)

typedef struct tagTMsgHeader {
  DWORD Status;
  DWORD Conference;
  DWORD Id;
  DWORD Number;
  TUserInfo From;
  TUserInfo To;
  char Subject[SIZE_MESSAGE_SUBJECT];
  FILETIME PostedTimeGMT;
  FILETIME MsgTime;
  FILETIME ReadTime;
  BOOL Private;
  BOOL Received;
  BOOL ReceiptRequested;
  BOOL Deleted;
  BOOL Tagged;
  DWORD Reference;
  DWORD ReplyCount;
  TFidoAddress FidoFrom;
  TFidoAddress FidoTo;
  DWORD FidoFlags;
  DWORD MsgSize;
  DWORD PrevUnread;
  DWORD NextUnread;
  char Network[SIZE_MESSAGE_NETWORK];
  char AttachmentSFN[SIZE_SHORT_FILE_NAME];
  BOOL AllowDisplayMacros;
  DWORD AddedByUserId;
  BOOL Exported;
  DWORD MailFlags;                          // see mfXXXXXXXXX flags above
  DWORD NextAttachment;
  DWORD ReadCount;
  //------------------------
  char Attachment[SIZE_ATTACH_FILE_NAME];   // almost long file name
  DWORD ExtraCRC32;                         // optional CRC32
  DWORD Reserved[7];
  //------------------------
  // the message body
  // null
} TMsgHeader;


//!
//! TFileRecord.FileFlags Bits
//!
const DWORD ffAbortedUpload      = 0x00000001;  // signifies incomplete file.
const DWORD ffAllowFileComments  = 0x00000002;  // allows file comments


//!
//! File Comment
//!

typedef struct tagTFileComment {
   DWORD area;
   DWORD id;
} TFileComment;

//!
//! TFileRecord
//!

typedef struct tagTFileRecord {
  DWORD Status;
  DWORD Area;
  char SFName[SIZE_SHORT_FILE_NAME];
  char Description[SIZE_FILE_DESCRIPTION];
  char Password[SIZE_PASSWORD];
  DWORD FileFlags;
  DWORD Size;
  FILETIME FileTime;
  FILETIME LastAccessed;
  BOOL NeverOverwrite;
  BOOL NeverDelete;
  BOOL FreeFile;
  BOOL CopyBeforeDownload;          // clients should copy first before dload
  BOOL Offline;                     // physical file not on disk,
  BOOL FailedScan;                  // file failed a virus scan
  BOOL FreeTime;                    // online time not adjusted
  DWORD Downloads;                  // # of times downloaded
  DWORD Cost;                       // cost to download file
  TUserInfo Uploader;
  DWORD UserInfo;
  BOOL HasLongDescription;
  FILETIME PostTime;                // Local Time
  DWORD PrivateUserId;              // for faOwnerReadAccess Areas
  TFileComment FirstComment;
  BYTE Reserved[24];
  char Name[SIZE_LONG_FILE_NAME];   // long file name
  BYTE Reserved2[100];
} TFileRecord;

//!
//! TFullFileRecord
//!

typedef struct tagTFullFileRecord {
  TFileRecord Info;
  char StoredPath[MAX_PATH];
  char LongDescription[MAX_FILE_LONGDESC_LINES][SIZE_FILE_LONGDESC];
} TFullFileRecord;

//!---------------------------------------------------------
//! 454.8
//! TFileSearchRecord is a helper structure to be used with the
//! SDK function, FileSearch().  FileSearch() returns an array
//! of TFileSearchRecord representing the file area and file
//! database record number.
//!---------------------------------------------------------

typedef struct tagTFileSearchRecord {
    DWORD ref;
    DWORD area;
} TFileSearchRecord;

//!---------------------------------------------------------
//! TFullFileRecord5 and TFileRecord5 is made available
//! here for SDK java/foxpro conversion purposes only
//!---------------------------------------------------------

typedef struct tagTFileRecord5 {
  DWORD Status;
  DWORD Area;
  char Name[SIZE_SHORT_FILE_NAME];
  char Description[SIZE_FILE_DESCRIPTION];
  char Password[SIZE_PASSWORD];
  DWORD Reserved1;
  DWORD Size;
  FILETIME FileTime;
  FILETIME LastAccessed;
  BOOL NeverOverwrite;
  BOOL NeverDelete;
  BOOL FreeFile;
  BOOL CopyBeforeDownload;
  BOOL Offline;
  BOOL FailedScan;
  BOOL FreeTime;
  DWORD Downloads;
  DWORD Cost;
  TUserInfo Uploader;
  DWORD UserInfo;
  BOOL HasLongDescription;
  BYTE Reserved[44];
} TFileRecord5;

typedef struct tagTFullFileRecord5 {
  TFileRecord5 Info;
  char StoredPath[MAX_PATH];
  char LongDescription[MAX_FILE_LONGDESC_LINES][SIZE_FILE_LONGDESC];
} TFullFileRecord5;

//!---------------------------------------------------------

typedef struct tagTSpellSuggestList {
  char Words[10][32];
} TSpellSuggestList;

//!
//! System.Control or System.Control.# Signals
//!

const DWORD SC_WATCH_REQUEST        = 0;     // Used by WcView Monitor
const DWORD SC_DISPLAY_UPDATE       = 1;     // Used by WcView Monitor
const DWORD SC_PUSH_KEY             = 2;     // Used by WcView Monitor
const DWORD SC_SECURITY_CHANGE      = 3;     // user security changed
const DWORD SC_DISCONNECT           = 4;     // disconnect the user
const DWORD SC_TIME_CHANGE          = 5;     // user time online changed
const DWORD SC_USER_RECORD_CHANGE   = 6;     // user record was updated

//!
//! System.Page Signals
//!

const DWORD SP_USER_PAGE            = 0;   // page user (send short message)
const DWORD SP_SYSOP_CHAT           = 1;   // sysop chat request
const DWORD SP_NEW_MESSAGE          = 2;   // signal user of new direct message
const DWORD SP_ALT_NUMBER_FILE      = 3;   // display disp\alt##.bbs

//!
//! System.Event Signals: File Database Signals
//!

const DWORD SE_FILE_UPLOAD          = 10;  // file uploaded
const DWORD SE_FILE_DOWNLOAD        = 11;  // file downloaded
const DWORD SE_FILE_DELETE          = 12;  // file deleted
const DWORD SE_FILE_UPDATE          = 13;  // file was updated/moved

//!
//! System.Event Signals: Miscellaneous Client Control Signals
//! Note: Currently, there is no implementation. However, the
//! signals are defined to begin a standard signal number set.
//!

const DWORD SE_SHUTDOWN_REQUEST     = 20;  // request to shutdown
const DWORD SE_RESTART              = 21;  // request to restart
const DWORD SE_CONFIG_CHANGE        = 22;  // Makewild has changed, minimum
const DWORD SE_POPCONNECT           = 23;  // POP3 Client has connected, 450.3

//!
//! System.Event Signals: Server Status Change
//!

const DWORD SE_SERVER_STATE_CHANGE  = 30;  // server state has changed
const DWORD SE_NODE_STATE_CHANGE    = 31;  // node state has changed

//!
//! System.MailServer Signals: This channel is specifically
//! designed for events between wcmail/wcsmtp and configuration
//! components so that wcmail/wcsmtp can automatically reread
//! internal data.  NOTE: wcSMTP port info changes requires
//! a restart. Only non-essential data is reread
//!

const DWORD SE_MAILSERVER_UPDATE    = 40;  // signals for wcmail/wcsmtp, 450.6


//!
//! Data Structure used for SE_FILE_xxxxxx channel signals.
//!

typedef struct tagTSystemEventFileInfo {
    DWORD FileArea;
    DWORD ConnectionId;
    FILETIME TimeStamp;
    char  szFileName[SIZE_LONG_FILE_NAME];
} TSystemEventFileInfo;

//!
//! Structure used by WCVIEW to display screen data sent by
//! Host clients.  WCVIEW will send SC_WATCH_REQUEST to clients
//! asking them to provide screen data. If the clients are listening,
//! they can fill in the structure and send the data with the
//! SC_DISPLAY_UPDATE channel signal which will then signal WCVIEW
//! to update its display screens.
//!

typedef struct tagTSystemControlViewMsg {
  WORD Line;
  WORD Count;
  WORD Text[3][80];
  WORD CursorX;
  WORD CursorY;
  WORD MinutesLeft;
} TSystemControlViewMsg;

//!
//! Data Structure used for SP_xxxxxx channel signals
//!

typedef struct tagTSystemPageNewMessage {
  DWORD Conference;
  char ConferenceName[SIZE_CONFERENCE_NAME];
  DWORD Id;
  TUserInfo From;
  char Subject[SIZE_MESSAGE_SUBJECT];
} TSystemPageNewMessage;


//!
//! Data Structure used for instant messages, channel "System.Page"
//!

typedef struct tagTSystemPageInstantMessage {
  char From[MAX_USER_NAME];
  char Text[SIZE_SYSTEMPAGE_LINES][SIZE_SYSTEMPAGE_TEXT];
  BOOL InviteToChat;
} TSystemPageInstantMessage;

//!
//! Structure for Wildcat! Service Creations
//!

typedef struct tagTWildcatService {
  char Name[SIZE_SERVICE_NAME];
  char Vendor[SIZE_SERVICE_NAME];
  DWORD Version;
  DWORD Address;
  DWORD Port;
} TWildcatService;

//!
//! Structure for Connection Information
//! Set GetConnectionInfo() SDK function
//!

typedef struct tagTConnectionInfo {
  DWORD ConnectionId;
  DWORD Node;
  DWORD Time;
  DWORD IdleTime;
  DWORD Calls;
  char WindowsUserName[80];
  char Computer[SIZE_COMPUTER_NAME];
  DWORD IpAddress;                         // process machine IP address
  char ProgramName[SIZE_PROGRAM_NAME];     // WCSDK application process name
  char Domain[SIZE_DOMAIN_NAME];           // Virtual Domain Host Name
  BYTE Reserved1[132];
  DWORD RefCount;
  TUserInfo User;
  DWORD HandlesOpen;
  DWORD ChannelsOpen;
  DWORD CurrentTid;
  DWORD PeerAddress;                       // 450.7 Remote User IP address
  DWORD CallType;                          // 451.3M
  char Status[SIZE_NODEINFO_ACTIVITY];     // 453.3a
  BYTE Reserved[60];                       // 453.3a was 92
} TConnectionInfo;

//!
//! Structure for GetWildcatServerInfo() function
//! Combines multiple server calls to get server totals in 1 call
//!

typedef struct tagTWildcatServerInfo {
  DWORD TotalCalls;
  DWORD TotalUsers;
  DWORD TotalMessages;
  DWORD TotalFiles;
  DWORD MemoryUsage;
  DWORD MemoryLoad;
  DWORD LastMessageId;
  DWORD LastUserId;
  DWORD ServerVersion;   // example, 6.1   --> 00060001
  DWORD ServerBuild;     // example, 451.9 --> 01C30009
  BYTE Reserved[84];
} TWildcatServerInfo;

//!
//! Structure for WcGetProcessTimes()
//! Returns server process running times information
//!

typedef struct tagTWildcatProcessTimes {
    FILETIME ftSystem;
    FILETIME ftStart;
    FILETIME ftExit;
    FILETIME ftKernel;
    FILETIME ftUser;
    BYTE Reserved[24];
} TWildcatProcessTimes;


//! v5.5.450.3
//! Options and structures for Wildcat! SASL Authentication functions.
//!

const DWORD WCSASL_SUCCESS        = 0;
const DWORD WCSASL_AUTH_OK        = WCSASL_SUCCESS;
const DWORD WCSASL_AUTH_FAIL      = 1;
const DWORD WCSASL_INVALID_METHOD = 2;
const DWORD WCSASL_GET_RESPONSE   = 3;
const DWORD WCSASL_GET_PASSWORD   = 4;
const DWORD WCSASL_LOOKUPUSER     = 5;

//!
//! TWildcatSASLContext.dwOptions Bit Flags
//!

const DWORD saslTranslate         = 0x00000001;   //! Undot user name
const DWORD saslTranslateBoth     = 0x00000011;   //! Check Dot/Undot name

//!
//! TWildcatSASLContext is used to store any context specific
//! data we need in SASL based connections
//!

typedef struct tagTWildcatSASLContext {
  char szSaslMethod[SIZE_SASL_NAME];    // method name set in the server
  char szChallenge[256];                // matches ChallengeString size from wcsclient.cpp
  DWORD dwOptions;                      // see saslXXXXX options
  DWORD dwState;                        // current authentication state set in the sasl module
  DWORD dwUserid;                       // userid set in the sasl module
  BYTE Data[4096];                      // module specific context data set in the sasl module
  char szUsername[SIZE_USER_NAME];
  char szRealm[MAX_PATH];
  char szDomain[MAX_PATH];
  char szNonce[MAX_PATH];
  char szCNonce[MAX_PATH];
  DWORD dwCNonceCount;
  char szURI[MAX_PATH];
  char szMethod[20];
  char szAlg[64];
  char szQop[64];
} TWildcatSASLContext;

//!
//! Structure for wcCreateFileEx() function
//!

typedef struct tagTwcOpenFileInfo {
   ULONG    hFile;
   DWORD    dwSize;
   FILETIME ftWriteTime;
   DWORD    dwAttributes;
   DWORD    dwSizeHigh;
   BYTE     reserved[232];
} TwcOpenFileInfo;

//!
//! Structure for WcGetWildcatServerGuid() function
//!

typedef struct tagTWildcatServerGuid {
    FILETIME Time;
    DWORD    Count;
    char     szGuid[MAX_PATH];
} TWildcatServerGuid;

//!
//! Structure for WcGetGeoIP()
//!
typedef struct tagTWildcatGeoIP {
   BOOL has_data;
   char ipaddr[16];
   char city[32];
	char continent[52];
	char country[52];
	char latitude[16];
	char longitude[16];
	char metro_code[16];
	char tzone[52];
	char postal[16];
	char country_code[8];
	char region_code[16];
	char region_name[52];
} TWildcatGeoIP;


#ifndef __MIDL__
typedef void *TWildcatContextHandle;
#endif

#if !defined(WIN32) && !defined(__MIDL__)
#undef BOOL
#define BOOL int
#endif

#endif
