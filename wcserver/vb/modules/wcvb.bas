Attribute VB_Name = "wcvb" 

'------------------------------------------------------------------------
'Visual Basic Wildcat! SDK API v8.0.454.8
'(c) copyright 1998-2019 by Santronics Software Inc.. All Rights Reserved.
'
'Automatically generated from wcserror.h by CPP2BAS
'------------------------------------------------------------------------


public const WC_STATUS_BASE as Long = &H20000000

public const WC_SUCCESS as Long                     = 0
public const WC_UNSUPPORTED_VERSION as Long         = WC_STATUS_BASE + 1
public const WC_CONTEXT_NOT_INITIALIZED as Long     = WC_STATUS_BASE + 2
public const WC_INVALID_NODE_NUMBER as Long         = WC_STATUS_BASE + 3
public const WC_USER_NOT_FOUND as Long              = WC_STATUS_BASE + 4
public const WC_INCORRECT_PASSWORD as Long          = WC_STATUS_BASE + 5
public const WC_USER_NOT_LOGGED_IN as Long          = WC_STATUS_BASE + 6
public const WC_INVALID_INDEX as Long               = WC_STATUS_BASE + 7
public const WC_INVALID_OBJECT_ID as Long           = WC_STATUS_BASE + 8
public const WC_GROUP_ALREADY_EXISTS as Long        = WC_STATUS_BASE + 9
public const WC_GROUP_NOT_FOUND as Long             = WC_STATUS_BASE + 10
public const WC_DBASE_NOT_AVAILABLE as Long         = WC_STATUS_BASE + 11
public const WC_OBJECTID_ALREADY_EXISTS as Long     = WC_STATUS_BASE + 12
public const WC_NAME_NOT_FOUND as Long              = WC_STATUS_BASE + 13
public const WC_NAME_ALREADY_EXISTS as Long         = WC_STATUS_BASE + 14
public const WC_ALREADY_LOGGED_IN as Long           = WC_STATUS_BASE + 15
public const WC_ITEM_NOT_FOUND as Long              = WC_STATUS_BASE + 16
public const WC_ITEM_REQUIRES_NAME as Long          = WC_STATUS_BASE + 17
public const WC_ITEM_ALREADY_EXISTS as Long         = WC_STATUS_BASE + 18
public const WC_ITEM_NAME_DIFFERENT as Long         = WC_STATUS_BASE + 19
public const WC_RECORD_NOT_FOUND as Long            = WC_STATUS_BASE + 20
public const WC_ACCESS_DENIED as Long               = WC_STATUS_BASE + 21
public const WC_NODE_ALREADY_IN_USE as Long         = WC_STATUS_BASE + 22
public const WC_USER_ALREADY_LOGGED_IN as Long      = WC_STATUS_BASE + 23
public const WC_INVALID_CONNECTION_ID as Long       = WC_STATUS_BASE + 24
public const WC_INVALID_CONFERENCE as Long          = WC_STATUS_BASE + 25
public const WC_INVALID_CONFERENCEGROUP as Long     = WC_STATUS_BASE + 26
public const WC_INVALID_FILEAREA as Long            = WC_STATUS_BASE + 27
public const WC_INVALID_FILEGROUP as Long           = WC_STATUS_BASE + 28
public const WC_DUPLICATE_RECORD as Long            = WC_STATUS_BASE + 29
public const WC_NO_ACTION_TAKEN as Long             = WC_STATUS_BASE + 30
public const WC_ACCOUNT_LOCKED_OUT as Long          = WC_STATUS_BASE + 31
public const WC_FILE_SEARCH_SYNTAX as Long          = WC_STATUS_BASE + 32
public const WC_REQUEST_NOT_ADDED as Long           = WC_STATUS_BASE + 33
public const WC_CONTEXT_MULTI_REFS as Long          = WC_STATUS_BASE + 34
public const WC_CONTEXT_ALREADY_INITIALIZED as Long = WC_STATUS_BASE + 35
public const WC_NO_NODES_AVAILABLE as Long          = WC_STATUS_BASE + 36
public const WC_COMPUTERNAME_NOT_FOUND as Long      = WC_STATUS_BASE + 37
public const WC_DBASE_IX_MISMATCH as Long           = WC_STATUS_BASE + 38
public const WC_DBASE_UPDATE_ERROR as Long          = WC_STATUS_BASE + 39
public const WC_DBASE_RESERVED40 as Long            = WC_STATUS_BASE + 40
public const WC_DBASE_RESERVED41 as Long            = WC_STATUS_BASE + 41
public const WC_DBASE_RESERVED42 as Long            = WC_STATUS_BASE + 42
public const WC_DBASE_RESERVED43 as Long            = WC_STATUS_BASE + 43
public const WC_USER_OUT_OF_TIME as Long            = WC_STATUS_BASE + 44
public const WC_ACCOUNT_NOT_VALIDATED as Long       = WC_STATUS_BASE + 45
public const WC_DOMAIN_ACCESS_DENIED as Long        = WC_STATUS_BASE + 46
public const WC_BUFFER_TOO_SMALL as Long            = WC_STATUS_BASE + 47
public const WC_DOMAIN_NOT_FOUND as Long            = WC_STATUS_BASE + 48
public const WC_PASSWORD_EXPIRED as Long            = WC_STATUS_BASE + 49
public const WC_PASSWORD_CHANGE_REQUIRED as Long    = WC_STATUS_BASE + 50
public const WC_ANONYMOUS_DENIED as Long            = WC_STATUS_BASE + 51
public const WC_HOURS_RESTRICTED as Long            = WC_STATUS_BASE + 52
public const WC_SECURITY_NOT_FOUND as Long          = WC_STATUS_BASE + 53
public const WC_INVALID_USERNAME as Long            = WC_STATUS_BASE + 54

public const WC_NOT_CONFIGURED as Long              = WC_STATUS_BASE + 55

public const WC_NO_PUBLIC_KEYS as Long              = WC_STATUS_BASE + 56
public const WC_PUBLIC_KEY_NOT_LISTED as Long       = WC_STATUS_BASE + 57


'------------------------------------------------------------------------
'Visual Basic Wildcat! SDK API v8.0.454.8
'(c) copyright 1998-2019 by Santronics Software Inc.. All Rights Reserved.
'
'Automatically generated from wctype.h by CPP2BAS
'------------------------------------------------------------------------


public const MAX_PATH as Long = 260

'//! Group: Client Structures


type FILETIME
  dwLowDateTime as Long
  dwHighDateTime as Long
end type


type WIN32_FIND_DATA
  dwFileAttributes as Long
  ftCreationTime as FILETIME
  ftLastAccessTime as FILETIME
  ftLastWriteTime as FILETIME
  nFileSizeHigh as Long
  nFileSizeLow as Long
  dwReserved0 as Long
  dwReserved1 as Long
  cFileName as String* MAX_PATH 
  cAlternateFileName as String* 14 
end type


public const WILDCAT_FRAMEWORK_VERSION as Long    = 2
public const WILDCAT_MKTG_VERSION as Long         = 10

public const WILDCAT_COMPONENT_ICP as Long        = &H00000001
public const WILDCAT_COMPONENT_SSL as Long        = &H00000002
public const WILDCAT_COMPONENT_PCI as Long        = &H00000004

'//!--------------------------------------------------------------
'//! SPECIAL NOTE ABOUT LONG vs SHORT FILE NAMES
'//!
'//! - v5.5 - File Database Only
'//!
'//!    MAX_PATH long file name support was implemented in v5.5
'//!    Database conversion was required since TFileRecord size
'//!    was changed
'//!
'//! - v6.1.451.9 - Message Database Only (Native storage)
'//!
'//!   A 80 (79 + 1 null) semi-long file name was implemented
'//!   in v6.1.451.9 for TMsgHeader.Attachment.  The old
'//!   short file name field was renamed to TMsgHeader.AttachmentSFN
'//!
'//!   Developers can use a sizeof(TMsgHeader.Header) check to see
'//!   what is the current size of the API.
'//!
'//!--------------------------------------------------------------

public const SIZE_SHORT_FILE_NAME as Long          = 16
public const SIZE_LONG_FILE_NAME as Long           = MAX_PATH
public const SIZE_ATTACH_FILE_NAME as Long         = 80
public const SIZE_PROGRAM_NAME as Long             = 64

public const CHANNEL_MESSAGE_HEADER_SIZE as Long   = 12
public const NUM_USER_SECURITY as Long             = 10
public const MAX_CHANNEL_MESSAGE_SIZE as Long      = 500
public const MAX_FILE_LONGDESC_LINES as Long       = 15
public const MAX_LANGUAGE_SUBCOMMAND_CHARS as Long = 100
public const MAX_MENU_ITEMS as Long                = 40
public const MAX_USER_NAME as Long                 = 28
public const SIZE_CALLTYPE as Long                 = 32
public const SIZE_COMPUTER_NAME as Long            = 16
public const SIZE_CONFERENCEGROUP_NAME as Long     = 32
public const SIZE_CONFERENCE_ECHOTAG as Long       = 64
public const SIZE_CONFERENCE_NAME as Long          = 60
public const SIZE_DOMAIN_NAME as Long              = 64
public const SIZE_DOOR_NAME as Long                = 40
public const SIZE_ENCODED_PASSWORD as Long         = 20
public const SIZE_EXTENSION as Long                = 4
public const SIZE_FILEAREA_NAME as Long            = 32
public const SIZE_FILEGROUP_NAME as Long           = 32
public const SIZE_FILE_DESCRIPTION as Long         = 76
public const SIZE_FILE_LONGDESC as Long            = 80
public const SIZE_LANGUAGE_DESCRIPTION as Long     = 72
public const SIZE_LANGUAGE_NAME as Long            = 12
public const SIZE_MAKEWILD_BBSNAME as Long         = 52
public const SIZE_MAKEWILD_CITY as Long            = 32
public const SIZE_MAKEWILD_FIRSTCALL as Long       = 28
public const SIZE_MAKEWILD_PACKETID as Long        = 12
public const SIZE_MAKEWILD_PHONE as Long           = 28
public const SIZE_MAKEWILD_REGSTRING as Long       = 8
public const SIZE_MENUITEM_COMMAND as Long         = 48
public const SIZE_MENUITEM_DESCRIPTION as Long     = 32
public const SIZE_MENUITEM_SELECTION as Long       = 16
public const SIZE_MENU_DESCRIPTION as Long         = 40
public const SIZE_MESSAGE_NETWORK as Long          = 12
public const SIZE_MESSAGE_SUBJECT as Long          = 72
public const SIZE_MODEM_NAME as Long               = 32
public const SIZE_MODEM_STRING as Long             = 64
public const SIZE_NODECONFIG_COMPUTER as Long      = 16
public const SIZE_NODECONFIG_PORTNAME as Long      = 16
public const SIZE_NODEINFO_ACTIVITY as Long        = 32
public const SIZE_NODEINFO_LASTCALLER as Long      = 48
public const SIZE_NODEINFO_SPEED as Long           = 8
public const SIZE_PASSWORD as Long                 = 32
public const SIZE_SASL_NAME as Long                = 32
public const SIZE_SECURITY_NAME as Long            = 24
public const SIZE_SERVERSTATE_PORT as Long         = 80
public const SIZE_SERVICE_NAME as Long             = 64
public const SIZE_SYSTEMPAGE_LINES as Long         = 3
public const SIZE_SYSTEMPAGE_TEXT as Long          = 80
public const SIZE_USER_ADDRESS as Long             = 32
public const SIZE_USER_FROM as Long                = 32
public const SIZE_USER_NAME as Long                = 72
public const SIZE_USER_PHONE as Long               = 16
public const SIZE_USER_STATE as Long               = 16
public const SIZE_USER_TITLE as Long               = 12
public const SIZE_USER_ZIP as Long                 = 12
public const SIZE_VOLUME_NAME as Long              = 16

'//!--------------------------------------------------------------------
'//! Access Profiles Class Object identifiers (COID).
'//! COIDS are used to identify a group/class of objects.
'//!--------------------------------------------------------------------

public const MASK_OBJECTCLASS as Long            = &HFF000000
public const OBJECTCLASS_RIGHTS as Long          = &H01000000
public const OBJECTCLASS_CONFERENCE as Long      = &H02000000
public const OBJECTCLASS_CONFERENCEGROUP as Long = &H03000000
public const OBJECTCLASS_FILEAREA as Long        = &H04000000
public const OBJECTCLASS_FILEGROUP as Long       = &H05000000
public const OBJECTCLASS_DOOR as Long            = &H06000000
public const OBJECTCLASS_MENU as Long            = &H07000000
public const OBJECTCLASS_CODE as Long            = &H08000000
public const OBJECTCLASS_CLIENT as Long          = &H09000000
public const OBJECTCLASS_SAPPHIRE_QUERY as Long  = &H0a000000
public const OBJECTCLASS_CHAT_CHANNEL as Long    = &H0b000000
public const OBJECTCLASS_RADIUS_CLIENT as Long   = &H0c000000
public const OBJECTCLASS_DOMAINS as Long         = &H0d000000

'//!--------------------------------------------------------------------
'//! Access Profiles Object identifiers (OID).
'//! Use with GetObjectFlags() during user sessions to determine if
'//! logged in user has access to specific functionalities identified
'//! by the OIDs
'//!--------------------------------------------------------------------

public const OBJECTID_BULLETINS_OPTIONAL as Long          = OBJECTCLASS_RIGHTS + 1
public const OBJECTID_CHANGE_PHONE as Long                = OBJECTCLASS_RIGHTS + 2
public const OBJECTID_CHANGE_BIRTHDATE as Long            = OBJECTCLASS_RIGHTS + 4
public const OBJECTID_QWK_ALLOW_BULLETINS as Long         = OBJECTCLASS_RIGHTS + 5
public const OBJECTID_QWK_ALLOW_NEWS as Long              = OBJECTCLASS_RIGHTS + 6
public const OBJECTID_QWK_ALLOW_FILES as Long             = OBJECTCLASS_RIGHTS + 7
public const OBJECTID_QWK_DETAIL_DOWNLOAD as Long         = OBJECTCLASS_RIGHTS + 8
public const OBJECTID_QWK_CHECK_DUPES as Long             = OBJECTCLASS_RIGHTS + 9
public const OBJECTID_QWK_SAVE_PACKETS as Long            = OBJECTCLASS_RIGHTS + 10
public const OBJECTID_MASTER_SYSOP as Long                = OBJECTCLASS_RIGHTS + 11
public const OBJECTID_RATIO_ACTION as Long                = OBJECTCLASS_RIGHTS + 12
public const OBJECTID_ALLOW_FAST_LOGIN as Long            = OBJECTCLASS_RIGHTS + 13
public const OBJECTID_ALLOW_OVERWRITE_FILES as Long       = OBJECTCLASS_RIGHTS + 14
public const OBJECTID_SHOW_PASSWORD_FILES as Long         = OBJECTCLASS_RIGHTS + 15
public const OBJECTID_ALLOW_OFFLINE_FILE_REQUESTS as Long = OBJECTCLASS_RIGHTS + 16
public const OBJECTID_ALLOW_UPLOAD_OVER_TIME as Long      = OBJECTCLASS_RIGHTS + 17
public const OBJECTID_ALLOW_DOWNLOAD_OVER_TIME as Long    = OBJECTCLASS_RIGHTS + 18
public const OBJECTID_ALLOW_UPLOADER_MODIFY_FILE as Long  = OBJECTCLASS_RIGHTS + 20
public const OBJECTID_QWK_NETSTATUS as Long               = OBJECTCLASS_RIGHTS + 26
public const OBJECTID_SYSOP_READ_PRIVATE_MAIL as Long     = OBJECTCLASS_RIGHTS + 27
public const OBJECTID_ALLOW_INTERNET_EMAIL as Long        = OBJECTCLASS_RIGHTS + 28
public const OBJECTID_ALLOW_ANY_TELNET as Long            = OBJECTCLASS_RIGHTS + 29
public const OBJECTID_ALLOW_ANY_FTP as Long               = OBJECTCLASS_RIGHTS + 30
public const OBJECTID_ALLOW_HTTP_PROXY as Long            = OBJECTCLASS_RIGHTS + 31
public const OBJECTID_ALLOW_ALL_IP as Long                = OBJECTCLASS_RIGHTS + 32
public const OBJECTID_ALLOW_DEFAULT_IP as Long            = OBJECTCLASS_RIGHTS + 33
public const OBJECTID_ALLOW_PPP as Long                   = OBJECTCLASS_RIGHTS + 34
public const OBJECTID_IGNORE_TIME_ONLINE as Long          = OBJECTCLASS_RIGHTS + 35
public const OBJECTID_IGNORE_IDLE_TIME as Long            = OBJECTCLASS_RIGHTS + 36
public const OBJECTID_ALLOW_SMTP_AUTH as Long             = OBJECTCLASS_RIGHTS + 37
public const OBJECTID_ALLOW_NNTP_ACCESS as Long           = OBJECTCLASS_RIGHTS + 38
public const OBJECTID_USERBIN_ACCESS as Long              = OBJECTCLASS_RIGHTS + 39
public const OBJECTID_ALLOW_FTP_ACCESS as Long            = OBJECTCLASS_RIGHTS + 40
public const OBJECTID_ALLOW_WEB_ACCESS as Long            = OBJECTCLASS_RIGHTS + 41
public const OBJECTID_ALLOW_TELNET_ACCESS as Long         = OBJECTCLASS_RIGHTS + 42
public const OBJECTID_CHANGE_EMAILADDRESS as Long         = OBJECTCLASS_RIGHTS + 43
public const OBJECTID_CHANGE_SMTPFORWARD as Long          = OBJECTCLASS_RIGHTS + 44
public const OBJECTID_ALLOW_CC_GROUPS as Long             = OBJECTCLASS_RIGHTS + 45
public const OBJECTID_ALLOW_IMAP_AUTH as Long             = OBJECTCLASS_RIGHTS + 37
public const OBJECTID_ALLOW_SFTP_ACCESS			 as Long = OBJECTCLASS_RIGHTS + 46
public const OBJECTID_ALLOW_STELNET_ACCESS		 as Long = OBJECTCLASS_RIGHTS + 47

public const OBJECTID_PROTOCOL_ACCESS as Long             = OBJECTCLASS_RIGHTS + &H00010000
public const OBJECTID_NODE_ACCESS as Long                 = OBJECTCLASS_RIGHTS + &H00020000

public const OBJECTFLAGS_CONFERENCE_JOIN as Long  = &H00000001
public const OBJECTFLAGS_CONFERENCE_READ as Long  = &H00000002
public const OBJECTFLAGS_CONFERENCE_WRITE as Long = &H00000004
public const OBJECTFLAGS_CONFERENCE_SYSOP as Long = &H00000008

public const OBJECTFLAGS_FILEAREA_LIST as Long     = &H00000001
public const OBJECTFLAGS_FILEAREA_DOWNLOAD as Long = &H00000002
public const OBJECTFLAGS_FILEAREA_UPLOAD as Long   = &H00000004
public const OBJECTFLAGS_FILEAREA_SYSOP as Long    = &H00000008

'//!
'//! MessageSearch() search attributes
'//!

public const MSF_FORWARD as Long = &H00000001
public const MSF_FROM as Long    = &H00000002
public const MSF_TO as Long      = &H00000004
public const MSF_SUBJECT as Long = &H00000008
public const MSF_BODY as Long    = &H00000010

'//!
'//! wcBASIC Telnet connection options
'//!

public const CONNECT_RAW as Long          = 0
public const CONNECT_TELNET_ASCII as Long = 1
public const CONNECT_TELNET_7BIT as Long  = 2
public const CONNECT_TELNET_8BIT as Long  = 3

'//!
'//! User Database Function Keys
'//!

public const UserIdKey as Long       = 0
public const UserNameKey as Long     = 1
public const UserLastNameKey as Long = 2
public const UserSecurityKey as Long = 3
public const UserLastCallKey as Long = 4

'//!
'//! Files Database Function Keys
'//!

public const FileNameAreaKey as Long = 0
public const FileAreaNameKey as Long = 1
public const FileAreaDateKey as Long = 2
public const FileUploaderKey as Long = 3
public const FileDateAreaKey as Long = 4

'//!
'//! Channel message structure for Callbacks
'//!


type TChannelMessage
  Channel as Long
  SenderId as Long
  UserData as Integer
  DataSize as Integer
  Data(1 to MAX_CHANNEL_MESSAGE_SIZE) as Byte
end type

'//!
'//! Data structure for Paging Channel Events
'//! passed via TChannelMessage.Data field
'//!


type TPageMessage
  From as String*28
  message(1 to 3) as String*80
  InviteToChat as Long
end type

'//!
'//! Data structure for Chat Channel Events
'//! passed via TChannelMessage.Data field
'//!


type TChatMessage
  From as String*28
  Text as String*256
  Whisper as Byte
end type


type TObjectName
  Status as Long
  ObjectId as Long
  Number as Long
  Name as String*MAX_PATH
end type

'//!
'//! System Operation Type
'//!


public const saOpen = 0
public const saClosed = 1
public const saClosedQuestionnaire = 2
public const saClosedValidation = 3


public const dusNone = 0
public const dusAsk = 1
public const dusAllow = 2


public const mhcUpperCase = 0
public const mhcLowerCase = 1
public const mhcAsIs = 2


'//!
'//! TMakeWild Structure (Main Configuration File)
'//! See GetMakewild() function
'//!


type TWildcatTimeouts
  dwVersion as Integer
  dwRevision as Integer
  Web as Long
  WebQues as Long
  Telnet as Long
  TelnetLogin as Long
  Ftp as Long
  wcPPP as Long
  wcNAV as Long
  Pop3 as Long
  Pop3Login as Long
  FtpLogin as Long
  FtpData as Long
  Reserved as String*76
end type

'//!
'//! LogPeriod options
'//!

public const wclogNone = 0
public const wclogHourly = 1
public const wclogDaily = 2
public const wclogWeekly = 3
public const wclogMonthly = 4
public const wclogUnlimitedSize = 5
public const wclogMaxSize = 6



type TWildcatLogOptions
  EnableSessionTrace as Long
  LogPeriod as Long
  dwMaxSize as Long
  dwVerbosity as Long
  Reserved(1 to 16) as Byte
end type


type THttpAuthOptions
  AllowPlainText as Long
  AllowPlainTextWithSSL as Long
  AllowPlainMD5 as Long
  AllowDigest as Long
  AllowWcChallenge as Long
  RequireSSL as Long
end type


type TWildcatHttpd
  dwVersion as Integer
  dwRevision as Integer
  obs_CommonLogF as Long
  obs_Deutsch as Long
  LogOptions as TWildcatLogOptions
  dwOptions as Long
  MaximumBandWidth as Long
  SendBufferSize1K as Long
  RcvdBufferSize1K as Long
  TrackPerformance as Long
  HttpAuth as THttpAuthOptions
  EnablePCISession as Long
  Reserved as String*20
end type


type TWildcatSMTP
  dwVersion as Integer
  dwRevision as Integer
  port as Long
  sendthreads as Integer
  acceptthreads as Integer
  dwOptions as Long
  acceptonly as Long
  retries as Long
  retrywait as Long
  smarthost as String*52
  sizelimit as Long
  localonly as Long
  MAPSRBL as Long
  MAPSRBLServer as String*52
  ESMTP as Long
  reqauth as Long
  VRFY as Long
  AllowRelay as Long
  CheckRCPT as Long
  EnableBadFilter as Long
  RequireMX as Long
  RequireHostMatch as Long
end type


type TWildcatNNTP
  dwVersion as Integer
  dwRevision as Integer
  dwPort as Long
  dwOptions as Long
  MaxCrossPost as Long
  LogOptions as TWildcatLogOptions
  Reserved as String*80
end type


type TWildcatPOP3
  dwVersion as Integer
  dwRevision as Integer
  EnablePopBeforeSmtp as Long
  dwPopBeforeSmtpTimeout as Long
  dwOptions as Long
  LogOptions as TWildcatLogOptions
  MaximumBandWidth as Long
  SendBufferSize1K as Long
  RcvdBufferSize1K as Long
  TrackPerformance as Long
  Reserved as String*64
end type


type TWildcatTelnet
  dwVersion as Integer
  dwRevision as Integer
  dwOptions as Long
  LogOptions as TWildcatLogOptions
  MaximumBandWidth as Long
  SendBufferSize1K as Long
  RcvdBufferSize1K as Long
  TrackPerformance as Long
  Reserved as String*72
end type

public const listUnixFormat = 0
public const listMSDOSFormat = 1



type TWildcatFTP
  dwVersion as Integer
  dwRevision as Integer
  AllowAnonymous as Long
  ShowFileGroups as Long
  UseUnderScore as Long
  UseSingleAreaChange as Long
  MaxAnonymousConnects as Long
  LogOptions as TWildcatLogOptions
  ListFormat as Long
  dwOptions as Long
  MaximumBandWidth as Long
  SendBufferSize1K as Long
  RcvdBufferSize1K as Long
  TrackPerformance as Long
  MaxConnects as Long
  Reserved as String*44
end type


type TWildcatSSH
  dwVersion as Integer
  dwRevision as Integer
  dwOptions as Long
  MaxConnects as Long
  LogOptions as TWildcatLogOptions
end type


type TMakewild
  Version as Long
  BBSName as String*SIZE_MAKEWILD_BBSNAME
  SysopName as String*MAX_USER_NAME
  City as String*SIZE_MAKEWILD_CITY
  Phone as String*SIZE_MAKEWILD_PHONE
  FirstCall as String*SIZE_MAKEWILD_FIRSTCALL
  PacketId as String*SIZE_MAKEWILD_PACKETID
  RegString as String*SIZE_MAKEWILD_REGSTRING
  SystemAccess as Long
  MaxLoginAttempts as Long
  FreeFormPhone as Long
  HideAnonFtpPassword as Long
  LogonLanguagePrompt as Long
  Assume8N1 as Long
  LoginAskLocation as Long
  NewUserSecurity as String*SIZE_SECURITY_NAME
  DefaultExt as String*SIZE_EXTENSION
  ThumbnailFile as String*SIZE_SHORT_FILE_NAME
  OldDoorPath as String*MAX_PATH
  obs_EnableHttpPr as Long
  SmtpMaxAcceptLoad as Long
  DateFormat as String*24
  TimeFormat as String*24
  DefaultDomain as String*SIZE_DOMAIN_NAME
  Reserved as String*12
  TelnetConfig as TWildcatTelnet
  FTPConfig as TWildcatFTP
  POP3Config as TWildcatPOP3
  MAILLogOptions as TWildcatLogOptions
  SSHConfig as TWildcatSSH
  Reserved1 as String*20
  SMTPLogOptions as TWildcatLogOptions
  NNTPConfig as TWildcatNNTP
  AllowLogonEmail as Long
  CaseSensitivePasswords as Long
  MsgHeaderCaseMode as Long
  SpamAllowAuth as Long
  SMTPConfig as TWildcatSMTP
  HttpdConfig as TWildcatHttpd
  Timeouts as TWildcatTimeouts
  DefaultColors(0 to 28-1) as Byte
  ExcludeBulletins(1 to 40) as Long
  InstalledComponents as Long
  obs_ResolveHostna as Long
  BuildDate as String*16
  DomainName as String*SIZE_DOMAIN_NAME
  WindowsCharset as Long
  LogonUserNameOnly as Long
end type


type TWildcatComputerIpPort
  dwPort as Long
  dwIpAddress as Long
end type


type TComputerConfig
  Name as String*SIZE_COMPUTER_NAME
  DoorPath as String*MAX_PATH
  CgiPath as String*MAX_PATH
  HttpPort as Long
  FtpPort as Long
  WWWHostname as String*80
  Servers as Long
  HttpProxyPort as Long

  dwVersion as Integer
  dwRevision as Integer
  ipportHttp as TWildcatComputerIpPort
  ipportFtp as TWildcatComputerIpPort
  ipportPop3 as TWildcatComputerIpPort
  ipportTelnet as TWildcatComputerIpPort
  ipportSmtp as TWildcatComputerIpPort
  ipportNntp as TWildcatComputerIpPort
  ipportSsh as TWildcatComputerIpPort
  SshPort as Long
  Reserved(1 to 320) as Byte
  TelnetPort as Long
  Pop3Port as Long
end type


public const pNone = 0
public const pAscii = 1
public const pXmodem = 2
public const pXmodemCRC = 3
public const pXmodem1K = 4
public const pXmodem1KG = 5
public const pYmodem = 6
public const pYmodemG = 7
public const pKermit = 8
public const pZmodem = 9
public const NumProtocols = 10


public const fiaAllow = 0
public const fiaLogoff = 1
public const fiaLockout = 2


public const ipfilterDeny = 0
public const ipfilterAllow = 1
public const ipfilterNone = 2
public const ipfilterBlock = 3


'//!
'//! TWildcatPOP3.dwOptions Bit Flags
'//!


public const pop3MarkRcvd as Long    = &H0001
public const pop3HonorRR as Long     = &H0002
public const pop3ResolveHost as Long = &H0020

'//!
'//! TWildcatSMTP.dwOptions Bit Flags
'//!

public const smtpBit0 as Long         = &H0001
public const smtpRcvdBin as Long      = &H0002
public const smtpNoMXOnce as Long     = &H0004
public const smtpIpFilter as Long     = &H0008
public const smtpIncMXTries as Long   = &H0010
public const smtpResolveHost as Long  = &H0020
public const smtpDisableETRN as Long  = &H0040
public const smtpAllowLocal as Long   = &H0080
public const smtpCheckHello as Long   = &H0100
public const smtpEnableWCSAP as Long  = &H0200
public const smtpEnableSFHook as Long = &H0400
public const smtpUsePort587 as Long   = &H0800
public const smtpReadBadFilter= as Long &H1000
public const smtpReqSSLAuth as Long   = &H2000

'//!
'//! TWildcatFTP.dwOptions Bit Flags
'//!

public const ftpBit0 as Long          = &H0001
public const ftpUnixFileAge as Long   = &H0002
public const ftpUseFtpLimit as Long   = &H0004
public const ftpCheckForDIZ as Long   = &H0008
public const ftpResolveHost as Long   = &H0020
public const ftpDisableIndex as Long  = &H0040

'//!
'//! TWildcatSSH.dwOptions Bit Flags     500.3 26.9.15
'//!
'//! The first four values MATCH their ftpXXXX equivalents on purpose, so the
'//! two option words can be compared or copied without a translation table.
'//! Today wcSFTP BORROWS these four from FTPConfig.dwOptions, which means a
'//! sysop cannot configure SFTP listings independently of FTP -- that is the
'//! main functional gain from this struct.
'//!

public const sftpBit0 as Long            = &H0001
public const sftpUnixFileAge as Long     = &H0002
public const sftpUseSecLimit as Long     = &H0004
public const sftpCheckForDIZ as Long     = &H0008
public const sshResolveHost as Long     = &H0020
public const sftpDisableIndex as Long    = &H0040
public const sshIdleDisconnect as Long  = &H0080
public const sshEnableWcxConnect= as Long &H0100
public const sshAllowPassword as Long   = &H0200
public const sshAllowPublicKey as Long  = &H0400
public const sshRequirePublicKey= as Long &H0800

'//! 500.3 26.9.15  NAMESPACE OPTIONS -- revision 2.
'//!
'//! These three decide the SHAPE of the directory tree a client sees and
'//! how an area name becomes a path component.  They were read from
'//! TWildcatFTP (ShowFileGroups / UseUnderScore / UseSingleAreaChange)
'//! until now, deliberately, so that a partner migrating from FTP saw
'//! identical paths.
'//!
'//! They are separate as of revision 2 because a site may want SFTP to
'//! present a DIFFERENT namespace -- typically a flatter one for a new
'//! partner -- without disturbing the FTP paths their existing partners
'//! already have hardcoded.
'//!
'//! THE MIGRATION MATTERS MORE THAN THE BITS.  An installation upgrading
'//! from revision 1 has these bits ZERO, which would silently turn file
'//! groups OFF and change every path a partner uses.  wcserver copies the
'//! FTP values across when it sees dwRevision < 2; do not remove that.
'//! 500.3 26.9.16  PUBLICKEY TRUST MODEL -- see saslPUBKEY.
'//!
'//! CLEAR (the default, and the recommended setting) means the signature
'//! is verified a SECOND time inside wcServer by the saslPUBKEY module.
'//! wcoSSH's own libssh verification is then not load-bearing: a client
'//! that reaches wcServer over RPC cannot assert an identity it cannot
'//! cryptographically prove.
'//!
'//! SET means wcServer ACCEPTS wcoSSH's word for it.  That is faster and
'//! avoids verifying twice, but it turns a real trust boundary into an
'//! assertion: ANY wcSDK client able to reach wcServer could then claim
'//! to be any user.  Only set it where the RPC channel itself is trusted
'//! end to end.
public const sshTrustModuleAuth as Long = &H8000

'//! 500.3 26.10.4  SSH Public Keys constants:
'//! SSH_KEYS_SECTION    - default "SSH_KEYS"
'//!
'//! SSH_MAX_KEYS        - max public keys for user's extended variables in
'//!                       section [SSH_KEYS_SECTION]. Index 1 to SSH_MAX_KEYS
'//!                       AuthorizedKey1=publickey[ comment]
'//!                       ..
'//!                       AuthorizedKey<SSH_MAX_KEYS>=publickey[ comment]
'//!
'//! SSH_MAX_KEY_LEN     - An ed25519 line is about 110 characters,
'//!                       but an RSA-4096 key alone can be over 700.
'//!                       This max is uses by consumers as a default for
'//!                       the biggest key a partner may reasonably send,
'//!                       plus the comment.

public const SSH_MAX_KEYS as Long       = 16
public const SSH_MAX_KEY_LEN as Long    = 2048

'//!
'//! SFTP listing options
'//!

public const sftpShowFileGroups as Long  = &H1000
public const sftpUseUnderScore as Long   = &H2000
public const sftpSingleAreaChange= as Long &H4000

'//!
'//! Password Bit Options for Security Profile and User Record
'//!

public const pwdChangeForce as Long     = &H0001
public const pwdChangeDisallow as Long  = &H0002
public const pwdChangeExpire as Long    = &H0004
public const pwdExpireLockout as Long   = &H0008
public const pwdAttemptsLockout as Long = &H0010

'//!
'//! TWildcatNNTP.dwOptions Bit Flags
'//!

public const nntpAllowAnony as Long     = &H0001
public const nntpResolveHost as Long    = &H0020

'//!
'//! TWildcatHttpd.dwOptions Bit Flags
'//!

public const httpEnableProxy as Long    = &H0001
public const httpCommonLogFile as Long  = &H0002
public const httpDeutschIVW as Long     = &H0004
public const httpResolveHost as Long    = &H0020
public const httpEnableChunking as Long = &H0008

'//!
'//! TWildcatTelnet.dwOptions Bit Flags
'//!

public const telnetEnableRLogin as Long   = &H0001
public const telnetResolveHost as Long    = &H0020

'//!
'//! Structure and constants used for User's Logon Hours
'//! Profile Data
'//!


type TLogonHours
  day(1 to 7) as Long
end type


public const lh12am as Long              = &H00000001
public const lh1am as Long               = &H00000002
public const lh2am as Long               = &H00000004
public const lh3am as Long               = &H00000008
public const lh4am as Long               = &H00000010
public const lh5am as Long               = &H00000020
public const lh6am as Long               = &H00000040
public const lh7am as Long               = &H00000080
public const lh8am as Long               = &H00000100
public const lh9am as Long               = &H00000200
public const lh10am as Long              = &H00000400
public const lh11am as Long              = &H00000800
public const lh12pm as Long              = &H00001000
public const lh1pm as Long               = &H00002000
public const lh2pm as Long               = &H00004000
public const lh3pm as Long               = &H00008000
public const lh4pm as Long               = &H00010000
public const lh5pm as Long               = &H00020000
public const lh6pm as Long               = &H00040000
public const lh7pm as Long               = &H00080000
public const lh8pm as Long               = &H00100000
public const lh9pm as Long               = &H00200000
public const lh10pm as Long              = &H00400000
public const lh11pm as Long              = &H00800000
public const lhAllHours as Long          = &H00FFFFFF
public const lhSun as Long               = &H01
public const lhMon as Long               = &H02
public const lhTue as Long               = &H04
public const lhWed as Long               = &H08
public const lhThu as Long               = &H10
public const lhFri as Long               = &H20
public const lhSat as Long               = &H40
public const lhAllDays as Long           = &H7F
public const lhStartofWeek as Long       = lhSun
public const lhEndofWeek as Long         = lhSat


type TSecurityProfile
  Name as String*SIZE_SECURITY_NAME
  ExpiredName as String*SIZE_SECURITY_NAME
  DisplayFileName as String*SIZE_SHORT_FILE_NAME
  DoorSysProfileName as String*SIZE_SECURITY_NAME
  MenuDisplaySet as String*SIZE_SHORT_FILE_NAME
  DailyTimeLimit as Long
  PerCallTimeLimit as Long
  VerifyPhoneInterval as Long
  VerifyBirthdateInterval as Long
  FailedInfoAction as Long
  MaxDownloadCountPerDay as Long
  DownloadRatioLimit as Long
  MaxDownloadKbytesPerDay as Long
  DownloadKbytesRatioLimit as Long
  UploadTimeCredit as Long
  ExpireDays as Long
  PasswordOptions as Integer
  PasswordExpireDays as Integer
  FtpSpaceKbytes as Long
  EmailDomainName as String*SIZE_DOMAIN_NAME
  MaximumLogons as Long
  RestrictedHours as Long
  LogonHours as TLogonHours
end type


public const mtNormalPublicPrivate = 0
public const mtNormalPublic = 1
public const mtNormalPrivate = 2
public const mtFidoNetmail = 3
public const mtEmailOnly = 4
public const mtUsenetNewsgroup = 5
public const mtUsenetNewsgroupModerated = 6
public const mtInternetMailingList = 7
public const mtFidoEcho = 8
public const mtListServeForum = 9


public const vnYes = 0
public const vnNo = 1
public const vnPrompt = 2


'//!
'//! The following maXXXXXXXXX bit flags are used in the
'//! TConfDesc.Options field.
'//!


public const maAllowMailSnooping as Long = &H00000001
public const maPreserveMime as Long      = &H00000002
public const maAllowReplyOnly as Long    = &H00000004
public const maAllowMacros as Long       = &H00000008
public const maAllowMsgDelete as Long    = &H00000010
public const maAllowDupes as Long        = &H00000020

'//!
'//! Option for TConfDesc.AuthorType field. This will define the
'//! conference option for how the From field will be defined when
'//! a message is created.
'//!


public const authorDefaultName = 0
public const authorForceUserName = 1
public const authorForceAliasName = 2
public const authorAllowBoth = 3
public const authorAnonymousName = 4



type TConfDesc
  ObjectId as Long
  Number as Long
  Name as String*SIZE_CONFERENCE_NAME
  Reserved1 as String*16
  ConferenceSysop as String*MAX_USER_NAME
  EchoTag as String*SIZE_CONFERENCE_ECHOTAG
  ReplyToAddress as String*SIZE_USER_NAME
  Distribution as String*SIZE_USER_NAME
  MailType as Long
  PromptToKillMsg as Long
  PromptToKillAttach as Long
  AllowHighAscii as Long
  AllowCarbon as Long
  AllowReturnReceipt as Long
  LongHeaderFormat as Long
  AllowAttach as Long
  ShowCtrlLines as Long
  ValidateNames as Long
  DefaultFileGroup as Long
  MaxMessages as Long
  DaysToKeepReceivedMail as Long
  DaysToKeepPublicMail as Long
  RenumberThreshold as Long
  DaysToKeepExternalMail as Long
  DeleteSMTPDelivered as Long
  PublishAsLocalNewsGroup as Long
  Options as Long
  AuthorType as Long
  UnixCreationTime as Long
  Reserved(1 to 6) as Byte
  DefaultFromAddress as String*SIZE_USER_NAME
  wVersion as Integer
end type


type TShortConfDesc
  ObjectId as Long
  Name as String*SIZE_CONFERENCE_NAME
  MailType as Long
end type


type TConferenceGroup
  ObjectId as Long
  Number as Long
  Name as String*SIZE_CONFERENCEGROUP_NAME
  Reserved(1 to 24) as Byte
end type

'//!
'//! TFileArea.Options attributes
'//!


public const faIsVolume as Long          = &H00000001
public const faAllowPrivateFiles as Long = &H00000002
public const faAllowFolderWatch as Long  = &H00000004
public const faAllowFileComments as Long = &H00000008


type TFileArea
  ObjectId as Long
  Number as Long
  Name as String*SIZE_FILEAREA_NAME
  ExcludeFromNewFiles as Long
  PromptForPasswordProtect as Long
  FtpDirectoryName as String*SIZE_FILEAREA_NAME
  Options as Long
end type


type TShortFileArea
  ObjectId as Long
  Name as String*SIZE_FILEAREA_NAME
end type


type TFileGroup
  ObjectId as Long
  Number as Long
  Name as String*SIZE_FILEGROUP_NAME
  Reserved(1 to 24) as Byte
end type


public const dtGeneric16 = 0
public const dtDoor32 = 1
public const dtDoorway = 2



type TDoorInfo
  ObjectId as Long
  Name as String*SIZE_DOOR_NAME
  Batch as String*SIZE_SHORT_FILE_NAME
  Display as String*SIZE_SHORT_FILE_NAME
  DoorMenuIndex as Long
  MultiUser as Long
  SmallDoorSys as Long
  DoorType as Long
  Reserved(1 to 36) as Byte
end type


public const LSC_YES as Long   = 0
public const LSC_NO as Long    = 1


type TLanguageInfo
  Name as String*SIZE_LANGUAGE_NAME
  Description as String*SIZE_LANGUAGE_DESCRIPTION
  SubcommandChars as String*MAX_LANGUAGE_SUBCOMMAND_CHARS
  Reserved(1 to 72) as Byte
end type


public const aRing = 0
public const aResult = 1
public const aAutoAnswer = 2



type TShortModemProfile
  UserDefined as Long
  Name as String*SIZE_MODEM_NAME
end type


type TModemProfile
  Version as Long
  UserDefined as Long
  Name as String*SIZE_MODEM_NAME
  InitBaud as Long
  LockDTE as Long
  HardwareFlow as Long
  ExitOffHook as Long
  CarrierDelay as Long
  RingDelay as Long
  DropDtrDelay as Long
  PrelogDelay as Long
  ResultDelay as Long
  ResetDelay as Long
  AnswerMethod as Long
  EnableCallerId as Long
  ResetCommand as String*SIZE_MODEM_STRING
  AnswerCommand as String*SIZE_MODEM_STRING
  Reserved1 as String*SIZE_MODEM_STRING
  OffHook as String*SIZE_MODEM_STRING
  RingResult as String*SIZE_MODEM_STRING
  ConnectResult as String*SIZE_MODEM_STRING
  Reserved2 as String*SIZE_MODEM_STRING
  ErrorFreeResult as String*SIZE_MODEM_STRING
  ExtraBaudResults(1 to 10) as String*SIZE_MODEM_STRING
  ExtraBaudResultNumbers(1 to 10) as Long
  Reserved3 as String*SIZE_MODEM_STRING
  InitCommand as String*SIZE_MODEM_STRING
  Reserved4 as String*SIZE_MODEM_STRING
  Reserved5(1 to 3) as String*SIZE_MODEM_STRING
  Reserved6 as String*256
  Reserved(1 to 128) as Byte
end type


public const CALLTYPE_LOCAL as Long    = &H00000001
public const CALLTYPE_DIALUP as Long   = &H00000002
public const CALLTYPE_TELNET as Long   = &H00000004
public const CALLTYPE_FTP as Long      = &H00000008
public const CALLTYPE_HTTP as Long     = &H00000010
public const CALLTYPE_FRONTEND as Long = &H00000020
public const CALLTYPE_POP3 as Long     = &H00000040
public const CALLTYPE_SMTP as Long     = &H00000080
public const CALLTYPE_PPP as Long      = &H00000100
public const CALLTYPE_RADIUS as Long   = &H00000200
public const CALLTYPE_NNTP as Long     = &H00000400
public const CALLTYPE_HTTPS as Long    = &H00000800
public const CALLTYPE_IMAP as Long     = &H00001000
public const CALLTYPE_SFTP as Long     = &H00002000
public const CALLTYPE_STELNET as Long  = &H00004000


public const ccAuto = 0
public const ccRLSD = 1
public const ccDSR = 2



type TNodeConfig
  CallTypesAllowed as Long
  ModemName as String*SIZE_MODEM_NAME
  Computer as String*SIZE_NODECONFIG_COMPUTER
  Port as String*SIZE_NODECONFIG_PORTNAME
  PermanentLineID as Long
  VirtualDoorPort as String*8
  NodeDisabled as Long
  CarrierCheckMethod as Long
  Reserved(1 to 40) as Byte
end type


public const SERVERSTATE_OFFLINE as Long = 0
public const SERVERSTATE_DOWN as Long    = 1
public const SERVERSTATE_REFUSE as Long  = 2
public const SERVERSTATE_UP as Long      = 3


type TServerState
  OwnerId as Long
  Computer as String*SIZE_NODECONFIG_COMPUTER
  Port as String*SIZE_SERVERSTATE_PORT
  State as Long
end type


public const MENU_TOPLEVEL as Long  = &H00000002


type TwcMenuItem
  Selection as String*SIZE_MENUITEM_SELECTION
  Description as String*SIZE_MENUITEM_DESCRIPTION
  Command as String*SIZE_MENUITEM_COMMAND
  Parameters as String*SIZE_MENUITEM_COMMAND
  Reserved(1 to 4) as Byte
end type


type TMenu
  ObjectId as Long
  Description as String*SIZE_MENU_DESCRIPTION
  DisplayName as String*SIZE_SHORT_FILE_NAME
  Flags as Long
  Count as Long
  Items(0 to MAX_MENU_ITEMS-1) as TwcMenuItem
  FastLoginChar as Long
  SecurityEntryName as String*SIZE_SECURITY_NAME
  Reserved(1 to 128) as Byte
end type


type TUserInfo
  Id as Long
  Name as String*SIZE_USER_NAME
  Title as String*SIZE_USER_TITLE
end type


public const clSessionNone = 0
public const clSessionUser = 1
public const clSessionSystem = 2
public const clSessionConfig = 3


public const nsDown = 0
public const nsUp = 1
public const nsSigningOn = 2
public const nsLoggedIn = 3



type TwcNodeInfo
  NodeStatus as Long
  ServerState as Long
  ConnectionId as Long
  LastCaller as String*SIZE_NODEINFO_LASTCALLER
  User as TUserInfo
  UserFrom as String*SIZE_USER_FROM
  UserPageAvailable as Long
  Reserved1 as Long
  Activity as String*SIZE_NODEINFO_ACTIVITY
  Speed as String*SIZE_NODEINFO_SPEED
  TimeCalled as FILETIME
  CurrentTime as FILETIME
  Reserved2 as Long
  NodeNumber as Long
  MinutesLeft as Long
end type


public const ucstNone as Long        = 0
public const ucstPersonal as Long    = 1
public const ucstPersonalAll as Long = 2
public const ucstAll as Long         = 3

public const ucstMask as Long     = &H0F
public const ucfReserved1 as Long = &H10
public const ucfReserved2 as Long = &H20
public const ucfReserved3 as Long = &H40
public const ucfAllAttach as Long = &H80


public const sNotDisclosed = 0
public const sMale = 1
public const sFemale = 2

public const ePrompt = 0
public const eLine = 1
public const eFullScreen = 2

public const hlNovice = 0
public const hlRegular = 1
public const hlExpert = 2

public const ttAuto = 0
public const ttTTY = 1
public const ttAnsi = 2

public const fdSingle = 0
public const fdDouble = 1
public const fdFull = 2
public const fdAnsi = 3

public const mdScroll = 0
public const mdClear = 1
public const mdKeepHeader = 2

public const ptText = 0
public const ptQwk = 1
public const ptOPX = 2


'//!
'//! User validation states for ssClosedValidation setup
'//!

public const vsNone = 0
public const vsValidationRequired = 1
public const vsPrevalidated = 2
public const vsValidated = 3



type TUser
  Status as Long
  Info as TUserInfo
  From as String*SIZE_USER_FROM

  Password as String*SIZE_PASSWORD
  Security(1 to NUM_USER_SECURITY) as String*SIZE_SECURITY_NAME
  Reserved1 as Long
  AllowMultipleLogins as Long
  LogonHoursOverride as Long

  RealName as String*SIZE_USER_NAME
  PhoneNumber as String*SIZE_USER_PHONE
  Company as String*SIZE_USER_ADDRESS
  Address1 as String*SIZE_USER_ADDRESS
  Address2 as String*SIZE_USER_ADDRESS
  City as String*SIZE_USER_ADDRESS
  State as String*SIZE_USER_STATE
  Zip as String*SIZE_USER_ZIP
  Country as String*SIZE_USER_ADDRESS
  Sex as Long

  Editor as Long
  HelpLevel as Long
  Protocol as Long
  TerminalType as Long
  FileDisplay as Long
  MsgDisplay as Long
  PacketType as Long
  LinesPerPage as Long
  HotKeys as Long
  QuoteOnReply as Long
  SortedListings as Long
  PageAvailable as Long
  EraseMorePrompt as Long
  Reserved3 as Long
  Language as String*SIZE_LANGUAGE_NAME

  LastCall as FILETIME
  LastNewFiles as FILETIME
  ExpireDate as FILETIME
  FirstCall as FILETIME
  BirthDate as FILETIME
  Conference as Long
  MsgsWritten as Long
  Uploads as Long
  TotalUploadKbytes as Long
  Downloads as Long
  TotalDownloadKbytes as Long
  DownloadCountToday as Long
  DownloadKbytesToday as Long
  TimesOn as Long
  TimeLeftToday as Long
  MinutesLogged as Long
  SubscriptionBalance as Long
  NetmailBalance as Long

  AccountLockedOut as Long
  PreserveMimeMessages as Long
  ShowEmailHeaders as Long
  LastUpdate as FILETIME
  SystemFlags as Integer
  UserFlags as Integer
  Validation as Long
  PasswordOptions as Integer
  PasswordExpireDays as Integer
  PasswordChangeDate as FILETIME
  AnonymousOnly as Long
  AllowUserDirectory as Long
end type


type TFidoAddress
  Zone as Integer
  Net as Integer
  Node as Integer
  Point as Integer
end type

'//!
'//! The following mfXXXXXXXXX bit flags are used in the
'//! TMsgHeader.MailFlags field.  Bits are defined as required
'//! for unique/special mail processing.
'//!


public const mfPOP3Received as Long      = &H01000000
public const mfReceiptCreated as Long    = &H02000000
public const mfSmtpDelivered as Long     = &H04000000
public const mfNNTPPost as Long          = &H08000000
public const mfIMAPPost as Long          = &H10000000
public const mfDigestSent as Long        = &H20000000
public const mfMimeSaved as Long         = &H00000001
public const mfNoDupeChecking as Long    = &H00000002
public const mfNoReplying as Long        = &H00000004


type TMsgHeader
  Status as Long
  Conference as Long
  Id as Long
  Number as Long
  From as TUserInfo
  To as TUserInfo
  Subject as String*SIZE_MESSAGE_SUBJECT
  PostedTimeGMT as FILETIME
  MsgTime as FILETIME
  ReadTime as FILETIME
  Private as Long
  Received as Long
  ReceiptRequested as Long
  Deleted as Long
  Tagged as Long
  Reference as Long
  ReplyCount as Long
  FidoFrom as TFidoAddress
  FidoTo as TFidoAddress
  FidoFlags as Long
  MsgSize as Long
  PrevUnread as Long
  NextUnread as Long
  Network as String*SIZE_MESSAGE_NETWORK
  AttachmentSFN as String*SIZE_SHORT_FILE_NAME
  AllowDisplayMacros as Long
  AddedByUserId as Long
  Exported as Long
  MailFlags as Long
  NextAttachment as Long
  ReadCount as Long
  Attachment as String*SIZE_ATTACH_FILE_NAME
  ExtraCRC32 as Long
  Reserved(1 to 7) as Long
end type

'//!
'//! TFileRecord.FileFlags Bits
'//!

public const ffAbortedUpload as Long      = &H00000001
public const ffAllowFileComments as Long  = &H00000002

'//!
'//! File Comment
'//!


type TFileComment
  area as Long
  id as Long
end type

'//!
'//! TFileRecord
'//!


type TFileRecord
  Status as Long
  Area as Long
  SFName as String*SIZE_SHORT_FILE_NAME
  Description as String*SIZE_FILE_DESCRIPTION
  Password as String*SIZE_PASSWORD
  FileFlags as Long
  Size as Long
  FileTime as FILETIME
  LastAccessed as FILETIME
  NeverOverwrite as Long
  NeverDelete as Long
  FreeFile as Long
  CopyBeforeDownload as Long
  Offline as Long
  FailedScan as Long
  FreeTime as Long
  Downloads as Long
  Cost as Long
  Uploader as TUserInfo
  UserInfo as Long
  HasLongDescription as Long
  PostTime as FILETIME
  PrivateUserId as Long
  FirstComment as TFileComment
  Reserved(1 to 24) as Byte
  Name as String*SIZE_LONG_FILE_NAME
  Reserved2(1 to 100) as Byte
end type

'//!
'//! TFullFileRecord
'//!


type TFullFileRecord
  Info as TFileRecord
  StoredPath as String*MAX_PATH
  LongDescription(1 to MAX_FILE_LONGDESC_LINES) as String*SIZE_FILE_LONGDESC
end type

'//!---------------------------------------------------------
'//! 454.8
'//! TFileSearchRecord is a helper structure to be used with the
'//! SDK function, FileSearch().  FileSearch() returns an array
'//! of TFileSearchRecord representing the file area and file
'//! database record number.
'//!---------------------------------------------------------


type TFileSearchRecord
  ref as Long
  area as Long
end type

'//!---------------------------------------------------------
'//! TFullFileRecord5 and TFileRecord5 is made available
'//! here for SDK java/foxpro conversion purposes only
'//!---------------------------------------------------------


type TFileRecord5
  Status as Long
  Area as Long
  Name as String*SIZE_SHORT_FILE_NAME
  Description as String*SIZE_FILE_DESCRIPTION
  Password as String*SIZE_PASSWORD
  Reserved1 as Long
  Size as Long
  FileTime as FILETIME
  LastAccessed as FILETIME
  NeverOverwrite as Long
  NeverDelete as Long
  FreeFile as Long
  CopyBeforeDownload as Long
  Offline as Long
  FailedScan as Long
  FreeTime as Long
  Downloads as Long
  Cost as Long
  Uploader as TUserInfo
  UserInfo as Long
  HasLongDescription as Long
  Reserved(1 to 44) as Byte
end type


type TFullFileRecord5
  Info as TFileRecord5
  StoredPath as String*MAX_PATH
  LongDescription(1 to MAX_FILE_LONGDESC_LINES) as String*SIZE_FILE_LONGDESC
end type

'//!---------------------------------------------------------


type TSpellSuggestList
  Words(1 to 10) as String*32
end type

'//!
'//! System.Control or System.Control.# Signals
'//!


public const SC_WATCH_REQUEST as Long        = 0
public const SC_DISPLAY_UPDATE as Long       = 1
public const SC_PUSH_KEY as Long             = 2
public const SC_SECURITY_CHANGE as Long      = 3
public const SC_DISCONNECT as Long           = 4
public const SC_TIME_CHANGE as Long          = 5
public const SC_USER_RECORD_CHANGE as Long   = 6

'//!
'//! System.Page Signals
'//!

public const SP_USER_PAGE as Long            = 0
public const SP_SYSOP_CHAT as Long           = 1
public const SP_NEW_MESSAGE as Long          = 2
public const SP_ALT_NUMBER_FILE as Long      = 3

'//!
'//! System.Event Signals: File Database Signals
'//!

public const SE_FILE_UPLOAD as Long          = 10
public const SE_FILE_DOWNLOAD as Long        = 11
public const SE_FILE_DELETE as Long          = 12
public const SE_FILE_UPDATE as Long          = 13

'//!
'//! System.Event Signals: Miscellaneous Client Control Signals
'//! Note: Currently, there is no implementation. However, the
'//! signals are defined to begin a standard signal number set.
'//!

public const SE_SHUTDOWN_REQUEST as Long     = 20
public const SE_RESTART as Long              = 21
public const SE_CONFIG_CHANGE as Long        = 22
public const SE_POPCONNECT as Long           = 23

'//!
'//! System.Event Signals: Server Status Change
'//!

public const SE_SERVER_STATE_CHANGE as Long  = 30
public const SE_NODE_STATE_CHANGE as Long    = 31

'//!
'//! System.MailServer Signals: This channel is specifically
'//! designed for events between wcmail/wcsmtp and configuration
'//! components so that wcmail/wcsmtp can automatically reread
'//! internal data.  NOTE: wcSMTP port info changes requires
'//! a restart. Only non-essential data is reread
'//!

public const SE_MAILSERVER_UPDATE as Long    = 40

'//!
'//! Data Structure used for SE_FILE_xxxxxx channel signals.
'//!


type TSystemEventFileInfo
  FileArea as Long
  ConnectionId as Long
  TimeStamp as FILETIME
  szFileName as String*SIZE_LONG_FILE_NAME
end type

'//!
'//! Structure used by WCVIEW to display screen data sent by
'//! Host clients.  WCVIEW will send SC_WATCH_REQUEST to clients
'//! asking them to provide screen data. If the clients are listening,
'//! they can fill in the structure and send the data with the
'//! SC_DISPLAY_UPDATE channel signal which will then signal WCVIEW
'//! to update its display screens.
'//!


type TSystemControlViewMsg
  Line as Integer
  Count as Integer
  Text(1 to 3*80) as Integer
  CursorX as Integer
  CursorY as Integer
  MinutesLeft as Integer
end type

'//!
'//! Data Structure used for SP_xxxxxx channel signals
'//!


type TSystemPageNewMessage
  Conference as Long
  ConferenceName as String*SIZE_CONFERENCE_NAME
  Id as Long
  From as TUserInfo
  Subject as String*SIZE_MESSAGE_SUBJECT
end type

'//!
'//! Data Structure used for instant messages, channel "System.Page"
'//!


type TSystemPageInstantMessage
  From as String*MAX_USER_NAME
  Text(1 to SIZE_SYSTEMPAGE_LINES) as String*SIZE_SYSTEMPAGE_TEXT
  InviteToChat as Long
end type

'//!
'//! Structure for Wildcat! Service Creations
'//!


type TWildcatService
  Name as String*SIZE_SERVICE_NAME
  Vendor as String*SIZE_SERVICE_NAME
  Version as Long
  Address as Long
  Port as Long
end type

'//!
'//! Structure for Connection Information
'//! Set GetConnectionInfo() SDK function
'//!


type TConnectionInfo
  ConnectionId as Long
  Node as Long
  Time as Long
  IdleTime as Long
  Calls as Long
  WindowsUserName as String*80
  Computer as String*SIZE_COMPUTER_NAME
  IpAddress as Long
  ProgramName as String*SIZE_PROGRAM_NAME
  Domain as String*SIZE_DOMAIN_NAME
  Reserved1(1 to 132) as Byte
  RefCount as Long
  User as TUserInfo
  HandlesOpen as Long
  ChannelsOpen as Long
  CurrentTid as Long
  PeerAddress as Long
  CallType as Long
  Status as String*SIZE_NODEINFO_ACTIVITY
  Reserved(1 to 60) as Byte
end type

'//!
'//! Structure for GetWildcatServerInfo() function
'//! Combines multiple server calls to get server totals in 1 call
'//!


type TWildcatServerInfo
  TotalCalls as Long
  TotalUsers as Long
  TotalMessages as Long
  TotalFiles as Long
  MemoryUsage as Long
  MemoryLoad as Long
  LastMessageId as Long
  LastUserId as Long
  ServerVersion as Long
  ServerBuild as Long
  Reserved(1 to 84) as Byte
end type

'//!
'//! Structure for WcGetProcessTimes()
'//! Returns server process running times information
'//!


type TWildcatProcessTimes
  ftSystem as FILETIME
  ftStart as FILETIME
  ftExit as FILETIME
  ftKernel as FILETIME
  ftUser as FILETIME
  Reserved(1 to 24) as Byte
end type

'//! v5.5.450.3
'//! Options and structures for Wildcat! SASL Authentication functions.
'//!


public const WCSASL_SUCCESS as Long        = 0
public const WCSASL_AUTH_OK as Long        = WCSASL_SUCCESS
public const WCSASL_AUTH_FAIL as Long      = 1
public const WCSASL_INVALID_METHOD as Long = 2
public const WCSASL_GET_RESPONSE as Long   = 3
public const WCSASL_GET_PASSWORD as Long   = 4
public const WCSASL_LOOKUPUSER as Long     = 5

'//!
'//! TWildcatSASLContext.dwOptions Bit Flags
'//!

public const saslTranslate as Long         = &H00000001
public const saslTranslateBoth as Long     = &H00000011

'//!
'//! TWildcatSASLContext is used to store any context specific
'//! data we need in SASL based connections
'//!


type TWildcatSASLContext
  szSaslMethod as String*SIZE_SASL_NAME
  szChallenge as String*256
  dwOptions as Long
  dwState as Long
  dwUserid as Long
  Data(1 to 4096) as Byte
  szUsername as String*SIZE_USER_NAME
  szRealm as String*MAX_PATH
  szDomain as String*MAX_PATH
  szNonce as String*MAX_PATH
  szCNonce as String*MAX_PATH
  dwCNonceCount as Long
  szURI as String*MAX_PATH
  szMethod as String*20
  szAlg as String*64
  szQop as String*64
end type

'//!
'//! Structure for wcCreateFileEx() function
'//!


type TwcOpenFileInfo
  hFile as ULONG
  dwSize as Long
  ftWriteTime as FILETIME
  dwAttributes as Long
  dwSizeHigh as Long
  reserved(1 to 232) as Byte
end type

'//!
'//! Structure for WcGetWildcatServerGuid() function
'//!


type TWildcatServerGuid
  Time as FILETIME
  Count as Long
  szGuid as String*MAX_PATH
end type

'//!
'//! Structure for WcGetGeoIP()
'//!

type TWildcatGeoIP
  has_data as Long
  ipaddr as String*16
  city as String*32
  continent(1 to 52) as 	char
  country(1 to 52) as 	char
  latitude(1 to 16) as 	char
  longitude(1 to 16) as 	char
  metro_code(1 to 16) as 	char
  tzone(1 to 52) as 	char
  postal(1 to 16) as 	char
  country_code(1 to 8) as 	char
  region_code(1 to 16) as 	char
  region_name(1 to 52) as 	char
end type


'------------------------------------------------------------------------
'Visual Basic Wildcat! SDK API v8.0.454.8
'(c) copyright 1998-2019 by Santronics Software Inc.. All Rights Reserved.
'
'Automatically generated from wcserver.h by CPP2BAS
'------------------------------------------------------------------------

'//! Group: Client SDK Functions

'//! Return the RPC Server 32 or 64 bit mode.

Declare Function WcGetServerPlatform Lib "wcsrv2.dll" () As Long

'//! The functions to get the Wildcat version and build can be called before
'//! WildcatServerConnect.

Declare Function GetWildcatVersion Lib "wcsrv2.dll" () As Long
Declare Function GetWildcatBuild Lib "wcsrv2.dll" () As Long

'//! The functions to get the Wildcat version and build at the server and
'//! can only be called after a context is created

Declare Function WcGetServerVersion Lib "wcsrv2.dll" () As Long
Declare Function WcGetServerBuild Lib "wcsrv2.dll" () As Long

'//! WildcatServerConnect should be called once per application to connect to
'//! the Wildcat server.  The window handle is used as the parent window when
'//! the server connect dialog box is displayed.  If there is no convenient
'//! window handle available, pass NULL.  Console mode applications should
'//! also pass NULL.  WildcatServerConnectSpecific can be called if you know
'//! the machine name of the server you would like to connect to.
'//! WildcatServerDialog allows the user to pick a server from a dialog box.
'//!
'//! WildcatServerConnectLocal() was added in v5.7 to support connections
'//! only to the local computer. Performs no broadcasting.

Declare Function WildcatServerConnect Lib "wcvb.dll" Alias "vbWildcatServerConnect" (ByVal parent As Long) As Boolean
Declare Function WildcatServerConnectSpecific Lib "wcvb.dll" Alias "vbWildcatServerConnectSpecific" (ByVal parent As Long, ByVal computername As String) As Boolean
Declare Function WildcatServerConnectLocal Lib "wcsrv2.dll" (ByVal parent As Long) As Boolean
Declare Function WildcatServerDialog Lib "wcsrv2.dll" (ByVal parent As Long, ByVal computername As String, ByVal namesize As Long) As Boolean
Declare Function SetWildcatErrorMode Lib "wcsrv2.dll" (ByVal verbose As Long) As Boolean
Declare Function WildcatServerShutdown Lib "wcsrv2.dll" (ByVal pwd As String, ByVal force As Long) As Boolean

'//! GetConnectedServer retrieves the computer name of the connected server

Declare Function GetConnectedServer Lib "wcvb.dll" Alias "vbGetConnectedServer" () As String

'//! These functions start and stop a thread-specific context for this client
'//! on the server.  Even if an application only has one thread, the
'//! WildcatServerCreateContext function must be called before any other
'//! functions will work.
'//!
'//! WildcatServerCreateContextFromHandle creates a new client context that
'//! refers to an existing context on the server.  The handle is generally
'//! retrieved using GetWildcatServerContextHandle in one application, and
'//! passed to WildcatServerCreateContextFromHandle in another application.

Declare Function WildcatServerCreateContext Lib "wcsrv2.dll" () As Boolean
Declare Function WildcatServerCreateContextFromHandle Lib "wcsrv2.dll" (ByVal context As Long) As Boolean
Declare Function WildcatServerCreateContextFromChallenge Lib "wcsrv2.dll" (ByVal challenge As String) As Boolean
Declare Function GetWildcatServerContextHandle Lib "wcsrv2.dll" () As Long
Declare Function WildcatServerDeleteContext Lib "wcsrv2.dll" () As Boolean

'//! This function sets up a callback for the client application.
'//! Channel messages are presented to the client through this
'//! callback mechanism.

Declare Function SetupWildcatCallback Lib "wcsrv2.dll" (ByVal cbproc As Long, ByVal userdata As Long) As Boolean
Declare Function RemoveWildcatCallback Lib "wcsrv2.dll" () As Boolean

'//! This function is used to grant another thread in the same application
'//! equivalent access as the thread that calls this function.  It causes the
'//! other thread to refer to the same server context.  This is a lightweight
'//! version of WildcatServerCreateContextFromHandle.  One difference is that
'//! since this function does not create a new client context,
'//! WildcatServerDeleteContext must only be called once for this context,
'//! even though there may be more than one thread accessing it.

Declare Function GrantThreadAccess Lib "wcsrv2.dll" (ByVal tid As Long) As Boolean

'//! These two functions allow you to more directly manipulate the Wildcat
'//! server context associated with the current thread.  Like
'//! GrantThreadAccess, the Wildcat server is only aware of one instance of
'//! the context, so WildcatServerDeleteContext must only be called once per
'//! server context.

Declare Function GetWildcatThreadContext Lib "wcsrv2.dll" () As Long
Declare Function SetWildcatThreadContext Lib "wcsrv2.dll" (ByVal context As Long) As Boolean

'//! Returns the current node number, or 0 if no node number has been
'//! allocated.

Declare Function GetNode Lib "wcsrv2.dll" () As Long

'//! Set the current node status (nsDown, nsUp, nsSigningOn, nsLoggedIn).

Declare Function SetNodeStatus Lib "wcsrv2.dll" (ByVal nodestatus As Long) As Boolean

'//! Set the node down status (ndNone, ndRefuseLogin, ndDown).

'//! Get the TMakewild global configuration record.

Declare Function GetMakewild Lib "wcvb.dll" Alias "vbGetMakewild" (mw As TMakewild) As Boolean
Declare Function GetComputerConfig Lib "wcvb.dll" Alias "vbGetComputerConfig" (cc As TComputerConfig) As Boolean

'//! Get the challenge string used for MD5 password authentication.

Declare Function GetChallengeString Lib "wcvb.dll" Alias "vbGetChallengeString" () As String

'//! Log in to the Wildcat server as the 'system'.  This gives unrestricted
'//! access to all aspects of the server.  The computer from which this
'//! function is called must have been set up with the Wildcat System
'//! password, if any.

Declare Function LoginSystem Lib "wcsrv2.dll" () As Boolean

'//! Look up a user account by name, and return basic account information.

Declare Function LookupName Lib "wcvb.dll" Alias "vbLookupName" (ByVal name As String, uinfo As TUserInfo) As Boolean

'//! Allocate a node for a particular call type.  If a specific node is
'//! required, pass it in the 'node' parameter, otherwise pass zero.

Declare Function AllocateNode Lib "wcsrv2.dll" (ByVal node As Long, ByVal calltype As Long, ByVal speed As String) As Boolean

'//! Log in to the userver under a user account.  All further access to the
'//! server is checked based on the access profile(s) of the user.  The
'//! password can either be plaintext or an MD5 digest string.

Declare Function LoginUser Lib "wcvb.dll" Alias "vbLoginUser" (ByVal userid As Long, ByVal password As String, user As TUser) As Boolean
Declare Function LoginUserEx Lib "wcvb.dll" Alias "vbLoginUserEx" (ByVal userid As Long, ByVal password As String, ByVal calltype As Long, ByVal speed As String, user As TUser) As Boolean
Declare Function LoginRadiusUser Lib "wcvb.dll" Alias "vbLoginRadiusUser" (ByVal userid As Long, ByVal chapid As Byte, challenge As Byte, ByVal challengesize As Long, challresponse As Byte, user As TUser) As Boolean

'//! 500.3 26.9.17  SSH PUBLIC KEY LOGIN -- RFC 4252 section 7.
'//!
'//! Log a user in on the strength of an SSH public key they have PROVEN
'//! they hold.  Used by wcoSFTP after libssh has verified the client's
'//! signature over the SSH session id.
'//!
'//! WHAT EACH SIDE IS RESPONSIBLE FOR:
'//!   the CALLER proves POSSESSION of the private key (libssh does this,
'//!     and frees the signature in the process -- which is why no
'//!     signature is passed here and why the server cannot re-verify);
'//!   the SERVER decides AUTHORIZATION, by matching the offered key
'//!     against that user's [SFTP] AuthorizedKey<n> profile variables.
'//!     A caller can therefore PRESENT a key but never AUTHORIZE one.
'//!
'//! keytype   is the SSH key type token, e.g. "ssh-ed25519" or "ssh-rsa"
'//! keybase64 is the base64 public key blob
'//! Together they are the first two fields of an authorized_keys line.
'//!
'//! REQUIRES A SYSTEM PASSWORD to be configured.  Unlike
'//! LoginRadiusUser -- which still verifies a CHAP response and so is
'//! safe without one -- this call has no second credential check, so it
'//! returns WC_NOT_CONFIGURED rather than proceeding when none is set.
'//!
'//! Key refusals: WC_NO_PUBLIC_KEYS (user has none installed),
'//! WC_PUBLIC_KEY_NOT_LISTED (not one of the user's keys).
Declare Function LoginUserPublicKey Lib "wcvb.dll" Alias "vbLoginUserPublicKey" (ByVal userid As Long, ByVal keytype As String, ByVal keybase64 As String, ByVal calltype As Long, ByVal speed As String, user As TUser) As Boolean

'//! 500.3 26.9.17  Publickey phase 1 -- "WOULD this key be accepted?"
'//!
'//! Answers the UNSIGNED probe an SSH client sends while deciding which
'//! of its keys to sign with.  Changes NO login state, so it is callable
'//! before any login exists.
'//!
'//! Answer it truthfully: a client with several keys signs with the FIRST
'//! one the server says it would accept, so saying yes to everything makes
'//! it sign with the wrong key and fail without trying the right one.
'//!
'//! FALSE with GetLastError() WC_NO_PUBLIC_KEYS, WC_PUBLIC_KEY_NOT_LISTED
'//! or WC_NOT_CONFIGURED.  An older wcServer gives FALSE with 0.
Declare Function IsUserPublicKeyAuthorized Lib "wcsrv2.dll" (ByVal userid As Long, ByVal keytype As String, ByVal keybase64 As String) As Boolean

'//! 500.3 26.9.18  SSH PUBLIC KEY MANAGEMENT
'//!
'//! The keys live in the user record as [SFTP] AuthorizedKey<n>, scanned
'//! 1,2,3... and STOPPING AT THE FIRST GAP.  The SERVER owns that
'//! invariant: delete renumbers, add appends, and a malformed or PRIVATE
'//! key is refused before it can be stored.
'//!
'//! That is why these exist rather than each client using
'//! Get/SetUserVariable.  wcWEB, wcConfig, a wcBASIC utility and a
'//! partner self-service page would otherwise each have to renumber
'//! correctly -- and one mistake locks a partner out while their key
'//! still LOOKS installed.
'//!
'//! Index is 1-based, matching the AuthorizedKey<n> a sysop sees.
'//! Reading needs a system login; MODIFYING another user's record needs
'//! MASTER SYSOP.
'//!
'//! WcAddUserPublicKey returns the slot used, or 0 on failure.
Declare Function WcGetUserPublicKeyCount Lib "wcsrv2.dll" (ByVal userid As Long) As Long
Declare Function WcGetUserPublicKey Lib "wcsrv2.dll" (ByVal userid As Long, ByVal index As Long, ByVal dest As String, ByVal destsize As Long) As Boolean
Declare Function WcAddUserPublicKey Lib "wcsrv2.dll" (ByVal userid As Long, ByVal keyline As String) As Long
Declare Function WcDeleteUserPublicKey Lib "wcsrv2.dll" (ByVal userid As Long, ByVal index As Long) As Boolean

'//! 500.3 26.9.18  Is a System Password configured?
'//!
'//! Publickey login REQUIRES one and refuses with WC_NOT_CONFIGURED
'//! otherwise.  Ask BEFORE enabling publickey auth so a sysop is warned
'//! at the point of the decision, rather than meeting a refused login
'//! that looks exactly like a bad key.
'//!
'//! Reports only that a password is SET -- wcsyspw must also have
'//! stamped it on the machine.
Declare Function WcIsSystemPasswordConfigured Lib "wcsrv2.dll" () As Boolean

'//! Log out of the server.  This is called no matter whether you log in to
'//! the server using LoginSystem or LoginUser.

Declare Function LogoutUser Lib "wcsrv2.dll" () As Boolean

'//! Checks to see whether the current context is logged in or not.  Returns
'//! the user record if it is logged in as a user.  See clSessionXXXX
'//! constants

Declare Function WildcatLoggedIn Lib "wcvb.dll" Alias "vbWildcatLoggedIn" (user As TUser) As Long

'//! Gets the number of users currently online.

Declare Function GetUsersOnline Lib "wcsrv2.dll" () As Long

'//! Get the object flags for a particular access profile.  This may be
'//! called before a user is logged in.

Declare Function GetProfileObjectFlags Lib "wcsrv2.dll" (ByVal profile As String, ByVal objectid As Long) As Long

'//! The Wildcat server file API functions are modeled after the Win32 file
'//! API functions.  See the Win32 API documentation for details regarding
'//! these functions. See WCPATHS.DOC for information regarding the format of
'//! the path names that may be used with these functions.

Declare Function WcCloseHandle Lib "wcsrv2.dll" (ByVal h As Long) As Boolean
Declare Function WcCreateDirectory Lib "wcsrv2.dll" (ByVal dir As String) As Boolean
Declare Function WcRemoveDirectory Lib "wcsrv2.dll" (ByVal dir As String) As Boolean
Declare Function WcCreateFile Lib "wcsrv2.dll" (ByVal fn As String, ByVal access As Long, ByVal sharemode As Long, ByVal create As Long) As Long
Declare Function WcDeleteFile Lib "wcsrv2.dll" (ByVal fn As String) As Boolean
Declare Function WcExistFile Lib "wcsrv2.dll" (ByVal fn As String) As Boolean
Declare Function WcFindFirstFile Lib "wcvb.dll" Alias "vbWcFindFirstFile" (ByVal fn As String, fd As WIN32_FIND_DATA) As Long
Declare Function WcFindNextFile Lib "wcvb.dll" Alias "vbWcFindNextFile" (ByVal ff As Long, fd As WIN32_FIND_DATA) As Boolean
Declare Function WcFindClose Lib "wcsrv2.dll" (ByVal ff As Long) As Boolean
Declare Function WcGetFileSize Lib "wcsrv2.dll" (ByVal h As Long) As Long
Declare Function WcGetFileTime Lib "wcsrv2.dll" (ByVal h As Long, ft As FILETIME) As Boolean
Declare Function WcGetFileTimeByName Lib "wcsrv2.dll" (ByVal fn As String, ft As FILETIME) As Boolean
Declare Function WcMoveFile Lib "wcsrv2.dll" (ByVal src As String, ByVal dest As String) As Boolean
Declare Function WcReadFile Lib "wcsrv2.dll" (ByVal h As Long, buffer As Any, ByVal requested As Long, read As Long) As Boolean
Declare Function WcReadLine Lib "wcsrv2.dll" (ByVal h As Long, buffer As Any, ByVal buflen As Long) As Boolean
Declare Function WcSetEndOfFile Lib "wcsrv2.dll" (ByVal h As Long) As Boolean
Declare Function WcSetFilePointer Lib "wcsrv2.dll" (ByVal h As Long, ByVal dist As LONG, ByVal movemethod As Long) As Long
Declare Function WcSetFileTime Lib "wcsrv2.dll" (ByVal h As Long, ft As FILETIME) As Boolean
Declare Function WcWriteFile Lib "wcsrv2.dll" (ByVal h As Long, buffer As Any, ByVal requested As Long, written As Long) As Boolean
Declare Function WcRenameFile Lib "wcsrv2.dll" (ByVal from As String, ByVal toname As String) As Boolean

Declare Function WcResolvePathName Lib "wcsrv2.dll" (ByVal wfname As String, access As Long, share As Long, create As Long, ByVal dest As String, ByVal destsize As Long) As Boolean

'//! Get the connection Id for the current context.  Connection Ids are
'//! unique and can reasonably be assumed not to repeat during the time the
'//! server is up.

Declare Function GetConnectionId Lib "wcsrv2.dll" () As Long

'//! Get the total number of calls made to the system (not server API calls,
'//! user calls). The 'increment' parameter determines whether or not the
'//! count is increased by one before returning the result.

Declare Function GetTotalCalls Lib "wcsrv2.dll" (ByVal increment As Long) As Long

'//! This function combines a WcCreateFile, WcReadFile, and WcCloseHandle
'//! into one operation.

Declare Function GetText Lib "wcvb.dll" Alias "vbGetText" (byval fn As String) As String

'//! The following functions access the security data in the Wildcat server.
'//! Each 'securable' object (conference, file area, door, etc) has a unique
'//! Object Id stored with it.  Access profiles are tables of Object Ids and
'//! access flags. When a user logs in, a composite access table consisting
'//! of the logical OR of all the flags in the user' access profiles is
'//! created.  These functions access the information in that composite
'//! array.
'//!
'//! Object flags are often simply zero or one to indicate no access or allow
'//! access, but the individual bits may mean different things such as
'//! Join/Read/Write/Sysop access in a conference area.

Declare Function GetObjectFlags Lib "wcsrv2.dll" (ByVal objectid As Long) As Long
Declare Function GetMultipleObjectFlags Lib "wcsrv2.dll" (objectid As Long, ByVal count As Long, flags As Long) As Boolean
Declare Function GetObjectById Lib "wcvb.dll" Alias "vbGetObjectById" (ByVal objectid As Long, objectname As TObjectName) As Boolean
Declare Function GetMultipleObjectsById Lib "wcvb.dll" Alias "vbGetMultipleObjectsById" (objectid As Long, ByVal count As Long, objectname As TObjectName) As Boolean
Declare Function GetObjectByName Lib "wcvb.dll" Alias "vbGetObjectByName" (ByVal classid As Long, ByVal name As String, objectname As TObjectName, tid As Long) As Boolean
Declare Function GetNextObjectByName Lib "wcvb.dll" Alias "vbGetNextObjectByName" (objectname As TObjectName, tid As Long) As Boolean
Declare Function GetStringObjectId Lib "wcsrv2.dll" (ByVal objectclass As Long, ByVal name As String) As Long
Declare Function GetStringObjectFlags Lib "wcsrv2.dll" (ByVal objectclass As Long, ByVal name As String) As Long

'//! These functions access the list of security profiles in the server.

Declare Function GetSecurityProfileCount Lib "wcsrv2.dll" () As Long
Declare Function GetSecurityProfileNames Lib "wcvb.dll" Alias "vbGetSecurityProfileNames" () As Variant
Declare Function GetSecurityProfileByIndex Lib "wcvb.dll" Alias "vbGetSecurityProfileByIndex" (ByVal index As Long, profile As TSecurityProfile) As Boolean
Declare Function GetSecurityProfileByName Lib "wcvb.dll" Alias "vbGetSecurityProfileByName" (ByVal name As String, profile As TSecurityProfile) As Boolean

'//! These functions access the list of access profile names in the server.

Declare Function GetAccessProfileCount Lib "wcsrv2.dll" () As Long
Declare Function GetAccessProfileNames Lib "wcvb.dll" Alias "vbGetAccessProfileNames" () As Variant
Declare Function GetAccessProfileName Lib "wcvb.dll" Alias "vbGetAccessProfileName" (ByVal index As Long) As String

'//! These functions access the list of conferences (message areas) in
'//! the server.

Declare Function GetConferenceCount Lib "wcsrv2.dll" () As Long
Declare Function GetConfDesc Lib "wcvb.dll" Alias "vbGetConfDesc" (ByVal conference As Long, cd As TConfDesc) As Boolean

'//! These functions access the list of conference groups in the server.

Declare Function GetConferenceGroupCount Lib "wcsrv2.dll" () As Long
Declare Function GetConferenceGroup Lib "wcvb.dll" Alias "vbGetConferenceGroup" (ByVal index As Long, cg As TConferenceGroup) As Boolean

'//! These functions access the list of file areas in the server.

Declare Function GetFileAreaCount Lib "wcsrv2.dll" () As Long
Declare Function GetFileArea Lib "wcvb.dll" Alias "vbGetFileArea" (ByVal area As Long, fa As TFileArea) As Boolean

'//! These functions access the list of file groups in the server.

Declare Function GetFileGroupCount Lib "wcsrv2.dll" () As Long
Declare Function GetFileGroup Lib "wcvb.dll" Alias "vbGetFileGroup" (ByVal index As Long, fg As TFileGroup) As Boolean

'//! These functions access the list of doors in the server.

Declare Function GetDoorCount Lib "wcsrv2.dll" () As Long
Declare Function GetDoor Lib "wcvb.dll" Alias "vbGetDoor" (ByVal index As Long, di As TDoorInfo) As Boolean

'//! These functions access the list of languages in the server.

Declare Function GetLanguageCount Lib "wcsrv2.dll" () As Long
Declare Function GetLanguage Lib "wcvb.dll" Alias "vbGetLanguage" (ByVal index As Long, li As TLanguageInfo) As Boolean

'//! This function gets a specific modem profile from the server.

Declare Function GetModemProfile Lib "wcvb.dll" Alias "vbGetModemProfile" (ByVal name As String, mp As TModemProfile) As Boolean

'//! Get the current maximum number of nodes that have been allocated.

Declare Function GetNodeCount Lib "wcsrv2.dll" () As Long

'//! Get the maximum number of concurrent users supported by this
'//! installation of Wildcat.

Declare Function GetMaximumUserCount Lib "wcsrv2.dll" () As Long

'//! Get a node configuration record for the specified node.  Use
'//! by Wconline to start modem nodes.

Declare Function GetNodeConfig Lib "wcvb.dll" Alias "vbGetNodeConfig" (ByVal node As Long, nc As TNodeConfig) As Boolean

'//! Get a node information record for a specific node.

Declare Function GetNodeInfo Lib "wcvb.dll" Alias "vbGetNodeInfo" (ByVal node As Long, ni As TwcNodeInfo) As Boolean

'//! Get a node information record for a specific connection Id.

Declare Function GetNodeInfoByConnectionId Lib "wcvb.dll" Alias "vbGetNodeInfoByConnectionId" (ByVal id As Long, ni As TwcNodeInfo) As Boolean

'//! Get a node information record for a specific name.

Declare Function GetNodeInfoByName Lib "wcvb.dll" Alias "vbGetNodeInfoByName" (ByVal name As String, ni As TwcNodeInfo) As Boolean

'//! Get multiple node information records starting at a specific node.

Declare Function GetNodeInfos Lib "wcvb.dll" Alias "vbGetNodeInfos" (ByVal node As Long, ByVal count As Long, ni As TwcNodeInfo) As Boolean

'//! Set the current node's information record.  Only non-critical fields are
'//! allowed to be changed by this function.

Declare Function SetNodeInfo Lib "wcvb.dll" Alias "vbSetNodeInfo" (ni As TwcNodeInfo) As Boolean

'//! Set the current activity string for the current node.

Declare Function SetNodeActivity Lib "wcsrv2.dll" (ByVal activity As String) As Boolean

'//! Server State Functions

Declare Function SetServerState Lib "wcsrv2.dll" (ByVal port As String, ByVal state As Long) As Boolean
Declare Function GetServerState Lib "wcvb.dll" Alias "vbGetServerState" (ByVal index As Long, ss As TServerState) As Boolean
Declare Function SetNodeServerState Lib "wcsrv2.dll" (ByVal node As Long, ByVal state As Long) As Boolean

'//! The following functions access the file database in Wildcat.  The
'//! functions should be straightforward with the following notes:
'//!
'//! - GetFileRecByXxx gets a specific record by key.  SearchFileRecByXxx
'//!   searches for matching record, or the next record in the database,
'//!   based on a key.
'//!
'//! - FileSearch returns an array of __int64 (64-bit integers).  The high 32
'//!   bits indicates the file area of the record, and the low 32 bits
'//!   indicates the absolute reference number of the record.
'//!   GetFileRecAbsolute gets a specific file record.
'//!
'//! - Most functions return a TFileRecord which does not contain the long
'//!   file description. To retrieve the long file description, use
'//!   GetFullFileRec.

Declare Function AddFileRec Lib "wcvb.dll" Alias "vbAddFileRec" (f As TFullFileRecord) As Boolean
Declare Function DeleteFileRec Lib "wcvb.dll" Alias "vbDeleteFileRec" (f As TFileRecord, ByVal disktoo As Long) As Boolean
Declare Function FileSearch Lib "wcvb.dll" Alias "vbFileSearch" (byval s As String) As Variant
Declare Function GetFileRecAbsolute Lib "wcvb.dll" Alias "vbGetFileRecAbsolute" (ByVal ref As Long, f As TFileRecord) As Boolean
Declare Function GetFileRecByNameArea Lib "wcvb.dll" Alias "vbGetFileRecByNameArea" (ByVal name As String, ByVal area As Long, f As TFileRecord, tid As Long) As Boolean
Declare Function GetFileRecByAreaName Lib "wcvb.dll" Alias "vbGetFileRecByAreaName" (ByVal area As Long, ByVal name As String, f As TFileRecord, tid As Long) As Boolean
Declare Function GetFileRecByAreaDate Lib "wcvb.dll" Alias "vbGetFileRecByAreaDate" (ByVal area As Long, t As FILETIME, f As TFileRecord, tid As Long) As Boolean
Declare Function GetFileRecByUploader Lib "wcvb.dll" Alias "vbGetFileRecByUploader" (ByVal id As Long, f As TFileRecord, tid As Long) As Boolean
Declare Function GetFirstFileRec Lib "wcvb.dll" Alias "vbGetFirstFileRec" (ByVal keynum As Long, f As TFileRecord, tid As Long) As Boolean
Declare Function GetFullFileRec Lib "wcvb.dll" Alias "vbGetFullFileRec" (f As TFileRecord, full As TFullFileRecord) As Boolean
Declare Function GetLastFileRec Lib "wcvb.dll" Alias "vbGetLastFileRec" (ByVal keynum As Long, f As TFileRecord, tid As Long) As Boolean
Declare Function GetNextFileRec Lib "wcvb.dll" Alias "vbGetNextFileRec" (ByVal keynum As Long, f As TFileRecord, tid As Long) As Boolean
Declare Function GetPrevFileRec Lib "wcvb.dll" Alias "vbGetPrevFileRec" (ByVal keynum As Long, f As TFileRecord, tid As Long) As Boolean
Declare Function GetTotalFiles Lib "wcsrv2.dll" () As Long
Declare Function GetTotalFilesInArea Lib "wcsrv2.dll" (ByVal area As Long) As Long
Declare Function GetTotalFilesInGroup Lib "wcsrv2.dll" (ByVal group As Long) As Long
Declare Function IncrementDownloadCount Lib "wcvb.dll" Alias "vbIncrementDownloadCount" (f As TFileRecord) As Boolean
Declare Function SearchFileRecByNameArea Lib "wcvb.dll" Alias "vbSearchFileRecByNameArea" (ByVal name As String, ByVal area As Long, f As TFileRecord, tid As Long) As Boolean
Declare Function SearchFileRecByAreaName Lib "wcvb.dll" Alias "vbSearchFileRecByAreaName" (ByVal area As Long, ByVal name As String, f As TFileRecord, tid As Long) As Boolean
Declare Function SearchFileRecByAreaDate Lib "wcvb.dll" Alias "vbSearchFileRecByAreaDate" (ByVal area As Long, t As FILETIME, f As TFileRecord, tid As Long) As Boolean
Declare Function SearchFileRecByDateArea Lib "wcvb.dll" Alias "vbSearchFileRecByDateArea" (t As FILETIME, ByVal area As Long, f As TFileRecord, tid As Long) As Boolean
Declare Function SearchFileRecByUploader Lib "wcvb.dll" Alias "vbSearchFileRecByUploader" (ByVal id As Long, f As TFileRecord, tid As Long) As Boolean
Declare Function UpdateFileRec Lib "wcvb.dll" Alias "vbUpdateFileRec" (f As TFileRecord) As Boolean
Declare Function UpdateFullFileRec Lib "wcvb.dll" Alias "vbUpdateFullFileRec" (f As TFullFileRecord) As Boolean

'//! The following functions access the message databases in Wildcat.
'//! Messages are identified by there conference number and Id.  Message Ids
'//! are assigned when the message is added to the database and never
'//! reassigned.  Message Ids are very large numbers, so a separate message
'//! 'Number' is provided for convenience.  Message numbers are assigned
'//! sequentially within a conference.

Declare Function AddMessage Lib "wcvb.dll" Alias "vbAddMessage" (msg As TMsgHeader, ByVal text As String) As Boolean
Declare Function DeleteMessage Lib "wcvb.dll" Alias "vbDeleteMessage" (msg As TMsgHeader) As Boolean
Declare Function GetHighMessageNumber Lib "wcsrv2.dll" (ByVal conf As Long) As Long
Declare Function GetLowMessageNumber Lib "wcsrv2.dll" (ByVal conf As Long) As Long
Declare Function GetMessageById Lib "wcvb.dll" Alias "vbGetMessageById" (ByVal conf As Long, ByVal msgid As Long, msg As TMsgHeader) As Boolean
Declare Function GetMsgIdFromNumber Lib "wcsrv2.dll" (ByVal conf As Long, ByVal number As Long) As Long
Declare Function GetMsgNumberFromId Lib "wcsrv2.dll" (ByVal conf As Long, ByVal msgid As Long) As Long
Declare Function GetNextMessage Lib "wcvb.dll" Alias "vbGetNextMessage" (msg As TMsgHeader) As Boolean
Declare Function GetPrevMessage Lib "wcvb.dll" Alias "vbGetPrevMessage" (msg As TMsgHeader) As Boolean
Declare Function GetTotalMessages Lib "wcsrv2.dll" () As Long
Declare Function GetTotalMessagesInConference Lib "wcsrv2.dll" (ByVal conf As Long) As Long
Declare Function GetTotalMessagesInGroup Lib "wcsrv2.dll" (ByVal group As Long) As Long
Declare Function IncrementReplyCount Lib "wcvb.dll" Alias "vbIncrementReplyCount" (msg As TMsgHeader) As Boolean
Declare Function IncrementReadCount Lib "wcvb.dll" Alias "vbIncrementReadCount" (msg As TMsgHeader) As Boolean
Declare Function MarkMessageRead Lib "wcvb.dll" Alias "vbMarkMessageRead" (msg As TMsgHeader) As Boolean
Declare Function MessageSearch Lib "wcvb.dll" Alias "vbMessageSearch" (ByVal conf As Long, ByVal msgid As Long, ByVal msflags As Long, ByVal text As String, msg As TMsgHeader) As Boolean
Declare Function SearchMessageById Lib "wcvb.dll" Alias "vbSearchMessageById" (ByVal conf As Long, ByVal msgid As Long, msg As TMsgHeader) As Boolean
Declare Function SetMessagePrivate Lib "wcvb.dll" Alias "vbSetMessagePrivate" (msg As TMsgHeader, ByVal pvt As Long) As Boolean
Declare Function UpdateMessageFidoInfo Lib "wcvb.dll" Alias "vbUpdateMessageFidoInfo" (msg As TMsgHeader) As Boolean

'//! Use this function to define a group of conference numbers and to retrieve
'//! the highest msgid for each conference.

Declare Function GetHighMessageIds Lib "wcsrv2.dll" (ByVal count As Long, conferences As Long, ids As Long) As Boolean
Declare Function SetMessageExported Lib "wcvb.dll" Alias "vbSetMessageExported" (msg As TMsgHeader, ByVal exported As Long) As Boolean

'//! The following functions access the user database in Wildcat.  Like the
'//! file database, GetUserByXxx gets a specific record, and SearchUserByXxx
'//! looks for a matching or the next higher record in the database.
'//! GetUserVariable and SetUserVariable can be used to store private
'//! application-specific information in a user record.  They are similar in
'//! use to the profile functions in the Windows API.

Declare Function AddNewUser Lib "wcvb.dll" Alias "vbAddNewUser" (u As TUser) As Boolean
Declare Function DeleteOtherUser Lib "wcvb.dll" Alias "vbDeleteOtherUser" (u As TUser) As Boolean
Declare Function GetUserById Lib "wcvb.dll" Alias "vbGetUserById" (ByVal id As Long, u As TUser, tid As Long) As Boolean
Declare Function GetUserByLastName Lib "wcvb.dll" Alias "vbGetUserByLastName" (ByVal name As String, u As TUser, tid As Long) As Boolean
Declare Function GetUserByName Lib "wcvb.dll" Alias "vbGetUserByName" (ByVal name As String, u As TUser, tid As Long) As Boolean
Declare Function GetUserBySecurity Lib "wcvb.dll" Alias "vbGetUserBySecurity" (ByVal security As String, u As TUser, tid As Long) As Boolean
Declare Function GetUserByLastCall Lib "wcvb.dll" Alias "vbGetUserByLastCall" (ft As FILETIME, u As TUser, tid As Long) As Boolean
Declare Function GetUserVariable Lib "wcvb.dll" Alias "vbGetUserVariable" (ByVal id As Long, byval section As String, byval key As String, byval def As String) As String
Declare Function GetUserVariables Lib "wcvb.dll" Alias "vbGetUserVariables" (ByVal id As Long) As String
Declare Function GetFirstUser Lib "wcvb.dll" Alias "vbGetFirstUser" (ByVal keynum As Long, u As TUser, tid As Long) As Boolean
Declare Function GetLastUser Lib "wcvb.dll" Alias "vbGetLastUser" (ByVal keynum As Long, u As TUser, tid As Long) As Boolean
Declare Function GetNextUser Lib "wcvb.dll" Alias "vbGetNextUser" (ByVal keynum As Long, u As TUser, tid As Long) As Boolean
Declare Function GetPrevUser Lib "wcvb.dll" Alias "vbGetPrevUser" (ByVal keynum As Long, u As TUser, tid As Long) As Boolean
Declare Function GetTotalUsers Lib "wcsrv2.dll" () As Long
Declare Function SearchUserById Lib "wcvb.dll" Alias "vbSearchUserById" (ByVal id As Long, u As TUser, tid As Long) As Boolean
Declare Function SearchUserByLastName Lib "wcvb.dll" Alias "vbSearchUserByLastName" (ByVal name As String, u As TUser, tid As Long) As Boolean
Declare Function SearchUserByName Lib "wcvb.dll" Alias "vbSearchUserByName" (ByVal name As String, u As TUser, tid As Long) As Boolean
Declare Function SearchUserBySecurity Lib "wcvb.dll" Alias "vbSearchUserBySecurity" (ByVal security As String, u As TUser, tid As Long) As Boolean
Declare Function SearchUserByLastCall Lib "wcvb.dll" Alias "vbSearchUserByLastCall" (ft As FILETIME, u As TUser, tid As Long) As Boolean
Declare Function SetUserVariable Lib "wcsrv2.dll" (ByVal id As Long, ByVal section As String, ByVal key As String, ByVal data As String) As Boolean
Declare Function UpdateUser Lib "wcvb.dll" Alias "vbUpdateUser" (u As TUser) As Boolean

'//! Convenience functions for accessing the set of conferences that the user
'//! can access.  The 'flags' parameter in these functions refers to the
'//! user's per-conference read flags.  Using 0 as the 'flags' parameter
'//! means ignore it when looking for conferences.

Declare Function GetEffectiveConferenceGroupCount Lib "wcsrv2.dll" () As Long
Declare Function GetEffectiveConferenceCount Lib "wcsrv2.dll" (ByVal group As Long, ByVal flags As Long) As Long
Declare Function GetFirstConference Lib "wcsrv2.dll" (ByVal group As Long, ByVal flags As Long) As Long
Declare Function GetLastConference Lib "wcsrv2.dll" (ByVal group As Long, ByVal flags As Long) As Long
Declare Function GetNextConference Lib "wcsrv2.dll" (ByVal group As Long, ByVal flags As Long, ByVal conf As Long) As Long
Declare Function GetPrevConference Lib "wcsrv2.dll" (ByVal group As Long, ByVal flags As Long, ByVal conf As Long) As Long
Declare Function GetFirstConferenceUnread Lib "wcsrv2.dll" () As Long
Declare Function GetNextConferenceUnread Lib "wcsrv2.dll" (ByVal conf As Long) As Long
Declare Function GetPrevConferenceUnread Lib "wcsrv2.dll" (ByVal conf As Long) As Long
Declare Function IsConferenceInGroup Lib "wcsrv2.dll" (ByVal group As Long, ByVal conf As Long) As Boolean

'//! Convenience functions for accessing the set of file areas that the user
'//! can access.  Unlike the conference functions, the 'flags' parameter in
'//! these functions refers to the user's access flags in the file area
'//! (that is, list/download/upload/sysop).  Using 0 as the 'flags' parameter
'//! means ignore it when looking for file areas.

Declare Function GetEffectiveFileGroupCount Lib "wcsrv2.dll" () As Long
Declare Function GetEffectiveFileAreaCount Lib "wcsrv2.dll" (ByVal group As Long, ByVal flags As Long) As Long
Declare Function GetFirstFileArea Lib "wcsrv2.dll" (ByVal group As Long, ByVal flags As Long) As Long
Declare Function GetLastFileArea Lib "wcsrv2.dll" (ByVal group As Long, ByVal flags As Long) As Long
Declare Function GetNextFileArea Lib "wcsrv2.dll" (ByVal group As Long, ByVal flags As Long, ByVal area As Long) As Long
Declare Function GetPrevFileArea Lib "wcsrv2.dll" (ByVal group As Long, ByVal flags As Long, ByVal area As Long) As Long
Declare Function IsFileAreaInGroup Lib "wcsrv2.dll" (ByVal group As Long, ByVal area As Long) As Boolean

'//! Functions to get and set the current user's per-conference information.

Declare Function GetLastRead Lib "wcsrv2.dll" (ByVal conf As Long) As Long
Declare Function GetFirstUnread Lib "wcsrv2.dll" (ByVal conf As Long) As Long
Declare Function GetConfFlags Lib "wcsrv2.dll" (ByVal conf As Long) As Long
Declare Function SetLastRead Lib "wcsrv2.dll" (ByVal conf As Long, ByVal lastread As Long) As Boolean
Declare Function SetConfFlags Lib "wcsrv2.dll" (ByVal conf As Long, ByVal flags As Long) As Boolean

'//! Functions to get and set an arbitrary user's per-conference information.

Declare Function GetUserLastRead Lib "wcsrv2.dll" (ByVal userid As Long, ByVal conf As Long) As Long
Declare Function GetUserFirstUnread Lib "wcsrv2.dll" (ByVal userid As Long, ByVal conf As Long) As Long
Declare Function GetUserConfFlags Lib "wcsrv2.dll" (ByVal userid As Long, ByVal conf As Long) As Long
Declare Function SetUserLastRead Lib "wcsrv2.dll" (ByVal userid As Long, ByVal conf As Long, ByVal lastread As Long) As Boolean
Declare Function SetUserConfFlags Lib "wcsrv2.dll" (ByVal userid As Long, ByVal conf As Long, ByVal flags As Long) As Boolean

'//! Write an entry to a log file.  The 'fname' parameter must NOT contain a
'//! full path, just a file name.

Declare Function WriteLogEntry Lib "wcsrv2.dll" (ByVal fname As String, ByVal text As String) As Boolean

'//! Write an entry to the current node's activity log file.

Declare Function WriteActivityLogEntry Lib "wcsrv2.dll" (ByVal text As String) As Boolean

'//! Check the spelling of a string based on the server's spelling dictionary.
'//! Returns the position and length of the bad word, if any.
'//! - Suggest alternate spellings for a misspelled word.
'//! - Add a word to the auxiliary dictionary.

Declare Function SpellCheckLine Lib "wcsrv2.dll" (ByVal s As String, ByVal startpos As Long, badpos As Long, badlen As Long) As Boolean
Declare Function SpellCheckSuggest Lib "wcvb.dll" Alias "vbSpellCheckSuggest" (ByVal s As String, sl As TSpellSuggestList) As Long
Declare Function SpellCheckAddWord Lib "wcsrv2.dll" (ByVal s As String) As Boolean

'//! Open a communications channel.  Channels are named, and created on the
'//! fly as necessary.  Messages can either be broadcast ('destid'=0), or
'//! directed to a specific recipient.  The 'userdata' parameter can be used
'//! to distinguish different formats of the message data.

Declare Function OpenChannel Lib "wcsrv2.dll" (ByVal name As String) As Long
Declare Function CloseChannel Lib "wcsrv2.dll" (ByVal chandle As Long) As Boolean
Declare Function WriteChannel Lib "wcsrv2.dll" (ByVal chandle As Long, ByVal destid As Long, ByVal userdata As Long, data As Any, ByVal datasize As Long) As Boolean

'//! Get the Qwk packet size limits based on the user's reported speed.

Declare Function GetQwkBaudLimits Lib "wcsrv2.dll" (perpacket As Long, perconference As Long) As Boolean

'//! Retrieve a service record by name.  The service record contains an
'//! appropriate IP address and port to pass to connect() to establish
'//! communications with the service.  Since the communications with the
'//! service does not take place through the Wildcat server, no security or
'//! authentication is provided by default.  The
'//! GetWildcatServerContextHandle and WildcatServerCreateContextByHandle
'//! functions are useful if you need to communicate with the Wildcat server
'//! under the context of a logged in user.

Declare Function GetServiceByName Lib "wcvb.dll" Alias "vbGetServiceByName" (ByVal name As String, service As TWildcatService) As Boolean

'//! Register a service with the Wildcat server.  The port number must be
'//! filled in before calling this function.  The service remains registered
'//! until the process running the service is disconnected from the Wildcat
'//! server.

Declare Function RegisterService Lib "wcvb.dll" Alias "vbRegisterService" (service As TWildcatService) As Boolean
Declare Function CheckNetworkAddress Lib "wcsrv2.dll" (ByVal clientip As Long) As Boolean

'//! These functions are used to arbitrate access to CD-ROM changers and such
'//! when files are marked for copy-before-download.  After submitting the
'//! pathnames of the files to be retrieved, with a unique Id for each file,
'//! GetNextCopyRequest should be called in a loop to determine which file to
'//! copy next.  If a positive number is returned, it is the id of a request
'//! to copy.  If 0 is returned, there are no more requests.  If -1 is
'//! returned there are still requests pending and the application should
'//! delay for a short time and keep trying.  When a file has finished
'//! copying, RemoveCopyRequest must be called so that other clients may
'//! access files they have queued.

Declare Function SubmitCopyRequest Lib "wcsrv2.dll" (ByVal id As Long, ByVal fn As String) As Boolean
Declare Function GetNextCopyRequest Lib "wcsrv2.dll" () As Long
Declare Function RemoveCopyRequest Lib "wcsrv2.dll" (ByVal id As Long) As Boolean

'//! Return connection info for the given connectionid or the next higher
'//! connectionid. Returns FALSE when there is no higher connectionid.

Declare Function GetConnectionInfo Lib "wcvb.dll" Alias "vbGetConnectionInfo" (ByVal connectionid As Long, ci As TConnectionInfo) As Boolean

'//! Modify the amount of time the current user has remaining for the day.
'//! Negative values are ok.

Declare Function AdjustUserTime Lib "wcsrv2.dll" (ByVal minutes As Long) As Boolean

Declare Function GetWildcatServerInfo Lib "wcsrv2.dll" (si As TWildcatServerInfo) As Boolean

Declare Function GetUserByKeyIndex Lib "wcvb.dll" Alias "vbGetUserByKeyIndex" (ByVal keynum As Long, ByVal idx As Long, u As TUser, tid As Long) As Boolean
Declare Function CheckClientAddress Lib "wcsrv2.dll" (ByVal clientip As Long, ByVal szIPFile As String) As Boolean
Declare Function CheckClientAddressEx Lib "wcsrv2.dll" (ByVal clientip As Long, ByVal szIPFile As String) As Long
Declare Function CheckMailIntegrity Lib "wcsrv2.dll" (ByVal conf As Long, ByVal level As Long) As Boolean
Declare Function UpdateMessageFlags Lib "wcvb.dll" Alias "vbUpdateMessageFlags" (msg As TMsgHeader) As Boolean
Declare Function DeleteMessageAttachment Lib "wcvb.dll" Alias "vbDeleteMessageAttachment" (msg As TMsgHeader) As Boolean

'//! Given computer name, return the server options for the particular machine.
'//! If computer name is "" or null, it will turn the default settings for the
'//! system wide services.  If you want the current computer server settings,
'//! use GetComputerConfig(cc) instead.

Declare Function GetComputerConfigEx Lib "wcvb.dll" Alias "vbGetComputerConfigEx" (ByVal szComputerName As String, cc As TComputerConfig) As Boolean

'//! User Extended Database/Profile Helper Functions

Declare Function ProfileDateToFileDate Lib "wcsrv2.dll" (ByVal szInt64 As String, ft As FILETIME) As Boolean
Declare Function GetUserVariableDate Lib "wcsrv2.dll" (ByVal id As Long, ByVal section As String, ByVal key As String, ft As FILETIME) As Boolean
Declare Function GetUserProfileDate Lib "wcsrv2.dll" (ByVal id As Long, ByVal key As String, ft As FILETIME) As Boolean
Declare Function GetUserProfileDateStr Lib "wcvb.dll" Alias "vbGetUserProfileDateStr" (ByVal id as Long, ByVal key as string, ByVal format as string) As String
Declare Function GetUserProfileTimeStr Lib "wcvb.dll" Alias "vbGetUserProfileDateStr" (ByVal id as Long, ByVal key as string, ByVal format as string) As String
Declare Function SetUserVariableDate Lib "wcsrv2.dll" (ByVal id As Long, ByVal section As String, ByVal key As String, ft As FILETIME) As Boolean
Declare Function SetUserProfileDate Lib "wcsrv2.dll" (ByVal id As Long, ByVal key As String, ft As FILETIME) As Boolean
Declare Function SetUserProfileSystemTime Lib "wcsrv2.dll" (ByVal id As Long, ByVal key As String, st As SYSTEMTIME) As Boolean
Declare Function GetUserProfileBool Lib "wcsrv2.dll" (ByVal id As Long, ByVal key As String, flag As Long) As Boolean
Declare Function SetUserProfileBool Lib "wcsrv2.dll" (ByVal id As Long, ByVal key As String, ByVal flag As Long) As Boolean
Declare Function wcCopyFileToTemp Lib "wcsrv2.dll" (ByVal area As Long, ByVal fn As String) As Boolean
Declare Function UpdateUserEx Lib "wcvb.dll" Alias "vbUpdateUserEx" (user As TUser, ByVal oldpwd As String, ByVal newpwd As String) As Boolean

'//!
'//! Wildcat! SASL functions for authentication services
'//!
Declare Function WcSASLGetMethodName Lib "wcsrv2.dll" (ByVal szMethod As String, ByVal dwSize As Long, ByVal dwIndex As Long) As Boolean

'//!
'//! Check the SASL Login credentials (user is logged in)
'//!
Declare Function WcSASLAuthenticateUser Lib "wcvb.dll" Alias "vbWcSASLAuthenticateUser" (ctx As TWildcatSASLContext, ByVal szFromClient As String, ByVal szResponse As String, ByVal dwResponseSize As Long, u As TUser) As Long

'//!
'//! Check the SASL Login credentials (user is logged in)
'//!
Declare Function WcSASLAuthenticateUserEx Lib "wcvb.dll" Alias "vbWcSASLAuthenticateUserEx" (ctx As TWildcatSASLContext, ByVal szFromClient As String, ByVal szResponse As String, ByVal dwResponseSize As Long, ByVal dwCallType As Long, ByVal szSpeed As String, u As TUser) As Long

'//!
'//! Check the SASL Login credentials (user is not logged in)
'//!
Declare Function WcSASLCheckAuthentication Lib "wcvb.dll" Alias "vbWcSASLCheckAuthentication" (ctx As TWildcatSASLContext, ByVal szFromClient As String, ByVal szResponse As String, ByVal dwResponseSize As Long) As Long

'//!
'//! Get the wildcat server process running times
'//!
Declare Function WcGetProcessTimes Lib "wcsrv2.dll" (pt As TWildcatProcessTimes) As Boolean

'//!
'//! Set the context peer address
'//!
Declare Function SetContextPeerAddress Lib "wcsrv2.dll" (ByVal address As Long) As Boolean

'//! Wildcat! INI File Functions. These Wildcat! INI file
'//! functions work similar to the Win32 equivalent private
'//! profile functions. The key difference is that Win32
'//! INI files are local to the machine, where these Wildcat!
'//! INI functions use server side files using the Wildcat!
'//! file naming syntax, i.e., "wc:\data\productxyz.ini"
'//!

Declare Function WcGetPrivateProfileString Lib "wcvb.dll" Alias "vbWcGetPrivateProfileString" (byval section As String, byval key As String, byval def As String, byval ini As String) As String

Declare Function WcWritePrivateProfileString Lib "wcsrv2.dll" (ByVal sect As String, ByVal key As String, ByVal value As String, ByVal inifile As String) As Boolean

Declare Function WcGetPrivateProfileSection Lib "wcvb.dll" Alias "vbWcGetPrivateProfileSection" (byval section As String, byval ini As String) As String

'//! Extended WcCreateFileEx() function returns TwcOpenFileInfo
'//! structure. Useful when you need to open a file and obtain
'//! file information in one single RPC call.

Declare Function WcCreateFileEx Lib "wcsrv2.dll" (ByVal fn As String, ByVal access As Long, ByVal sharemode As Long, ByVal create As Long, pwcofi As TwcOpenFileInfo) As Long

'//! GetConnectionInfoFromChallenge() function returns TConnectionInfo
'//! for a given challenge.

Declare Function GetConnectionInfoFromChallenge Lib "wcvb.dll" Alias "vbGetConnectionInfoFromChallenge" (ByVal challenge As String, ci As TConnectionInfo) As Boolean

'//! DeleteUserVariable - delete extended user section or key

Declare Function DeleteUserVariable Lib "wcsrv2.dll" (ByVal id As Long, ByVal section As String, ByVal key As String) As Boolean

'//! WcCheckUserName - Return FALSE if user name has invalid characters

Declare Function WcCheckUserName Lib "wcsrv2.dll" (ByVal szName As String) As Boolean

'//! WcSetMessageAttachments - helps prepare attachment field

Declare Function WcSetMessageAttachment Lib "wcvb.dll" Alias "vbWcSetMessageAttachment" (msg As TMsgHeader, ByVal szFileName As String, ByVal bCopyTo As Long) As Boolean

'//! WcLocalCopyToServer - copy local side file to server side wc:\ file

Declare Function WcLocalCopyToServer Lib "wcsrv2.dll" (ByVal szLocal As String, ByVal szServer As String, ByVal msSlice As Long) As Boolean

'//! Domain Server Functions

Declare Function GetMakewildEx Lib "wcvb.dll" Alias "vbGetMakewildEx" (ByVal szDomain As String, ByVal setdomain As Long, mw As TMakewild) As Boolean
Declare Function WcSetCurrentDomain Lib "wcsrv2.dll" (ByVal szDomain As String) As Boolean
Declare Function WcGetCurrentDomain Lib "wcsrv2.dll" (ByVal szDomain As String, ByVal dwSize As Long) As Boolean
Declare Function WcGetDefaultDomain Lib "wcsrv2.dll" (ByVal szBuffer As String, ByVal dwSize As Long) As Boolean
Declare Function WcGetDomainCount Lib "wcsrv2.dll" () As Long
Declare Function WcGetDomain Lib "wcsrv2.dll" (ByVal index As Long, ByVal szDomain As String, ByVal dwSize As Long) As Boolean
Declare Function WcGetDomainConfigString Lib "wcsrv2.dll" (ByVal szDomain As String, ByVal szSection As String, ByVal szKey As String, ByVal szValue As String, ByVal dwSize As Long, ByVal szDefault As String) As Boolean
Declare Function WcGetDomainConfigBool Lib "wcsrv2.dll" (ByVal szDomain As String, ByVal szSection As String, ByVal szKey As String, bVal As Long, ByVal bDef As Long) As Boolean
Declare Function WcGetDomainConfigInt Lib "wcsrv2.dll" (ByVal szDomain As String, ByVal szSection As String, ByVal szKey As String, dwValue As Long, ByVal dwDefault As Long) As Boolean
Declare Function WcGetDomainConfigSection Lib "wcsrv2.dll" (ByVal szDomain As String, ByVal szSection As String, ByVal szBuffer As String, ByVal dwBufSize As Long, dwSize As Long) As Boolean
Declare Function WcGetHttpConfigVar Lib "wcsrv2.dll" (ByVal szSection As String, ByVal szKey As String, ByVal szValue As String, ByVal dwSize As Long, ByVal szDefault As String) As Boolean
Declare Function WcGetConfigFileVar Lib "wcsrv2.dll" (ByVal szFile As String, ByVal szSection As String, ByVal szKey As String, ByVal szValue As String, ByVal dwSize As Long, ByVal szDefault As String) As Boolean
Declare Function WcGetVirtualDomainBool Lib "wcsrv2.dll" (ByVal szDomain As String, ByVal szSection As String, ByVal szKey As String, bVal As Long, ByVal bDef As Long) As Boolean
Declare Function WcGetVirtualDomainVar Lib "wcsrv2.dll" (ByVal szDomain As String, ByVal szSection As String, ByVal szKey As String, ByVal szValue As String, ByVal dwSize As Long, ByVal szDefault As String) As Boolean

'//! Set Context/Connection Status (activity)

Declare Function WcSetConnectionStatus Lib "wcsrv2.dll" (ByVal activity As String) As Boolean

'//! Get unique server guid across all clients, see structure TWildcatServerGuid
'//!

Declare Function WcGetWildcatServerGuid Lib "wcvb.dll" Alias "vbWcGetWildcatServerGuid" (wg As TWildcatServerGuid) As Boolean

'//! Get unique QUEUE guid, see structure TWildcatServerGuid
'//!

Declare Function WcGetWildcatQueueGuid Lib "wcvb.dll" Alias "vbWcGetWildcatQueueGuid" (ByVal qname As String, wg As TWildcatServerGuid) As Boolean

'//! Get Geographical Location Information by IP Address
'//!

Declare Function WcGetGeoIP Lib "wcvb.dll" Alias "vbWcGetGeoIP" (ByVal ip As String, geoip As TWildcatGeoIP, ByVal lang As String) As Boolean

'//! Release a buffer this DLL allocated on the caller's behalf.
'//!
'//! A few functions hand back memory the RPC client stub allocated --
'//! FileSearch() is the current example.  A C/C++ caller built against
'//! the same CRT can free() it directly, but a caller in another
'//! language (Python/ctypes, C# P/Invoke) cannot reach this heap and
'//! must use this instead.  Not an RPC call; never contacts wcServer.
'//!
'//! NULL is ignored.  Do not pass a pointer this DLL did not allocate.
'//!
'//! 500.3
'//!
'//! PHP scripts never hold a buffer this DLL allocated, and a PHP wrapper
'//! would let a script free any address.  Marker read by the cpp2*
'//! translators; no language list means all of them (php, py, pas).
'//! DO NOT TRANSLATE WcFreeMemory php

Declare Function WcFreeMemory Lib "wcsrv2.dll" (pBuffer As Any) As Any

