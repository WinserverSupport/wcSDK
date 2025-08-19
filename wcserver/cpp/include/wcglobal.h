//***********************************************************************
// (c) Copyright 1998-2025 Santronics Software, Inc. All Rights Reserved.
//***********************************************************************
//
// File Name  : wcglobal.h
// Created    : 07/14/1999
//
// Revision History:
// Build      Date      Author  Comments
// -----      --------  ------  -------------------------------------------
// 410        03/14/04  HLS
// 453.3      12/11/09  HLS
// 454.1      06/23/11  HLS    - version change to 6.4
// 454.3      11/30/11  HLS    - updated build to 454.3
// 454.4      05/27/12  HLS    - beginning of v7.0
// 454.8      04/24/19  HLS    - x64 Support
// 454.10     05/23/20  HLS    - WC_VERSION was set at 10, change to 8.
// 454.12     04/08/21  HLS    - build changed to 454.12
// 454.13     02/25/23  HLS    - build changed to 454.13
// 454.14     11/01/23  HLS    - build changed to 454.14
// 454.15     07/17/24  HLS    - build changed to 454.15
// 454.16     10/25/24  HLS    - build changed to 454.16
//            03/15/25  HLS    - updated copyright
// 500.1      08/05/25  HLS    - New Build
//***********************************************************************

#ifndef __WCGLOBAL_H
#define __WCGLOBAL_H

#include "build.h"

#if !defined(WILDCAT_V60)
#define WILDCAT_V60
#endif

#if !defined(WILDCAT_V61)
#define WILDCAT_V61
#endif

#if !defined(WILDCAT_V62)
#define WILDCAT_V62
#endif

#if !defined(WILDCAT_V63)
#define WILDCAT_V63
#endif

#if !defined(WILDCAT_V64)
#define WILDCAT_V64
#endif

#if !defined(WILDCAT_V70)
#define WILDCAT_V70
#endif

#if !defined(WILDCAT_V80)
#define WILDCAT_V80
#endif

#if !defined(WILDCAT_V100)
#define WILDCAT_V100
#endif

//------------------------------------------------------------------
// These will cause version conflict.
//------------------------------------------------------------------

//#define WC_VERSION_USER       "5.6"
//#define WC_VERSION_USER       "5.7"             // 450.9b2
//#define WC_VERSION_USER       "6.0"             // 03/14/04 06:41 am
//#define WC_VERSION_USER       "6.1"             // 03/14/04 06:41 am
//#define WC_VERSION_USER       "6.2"             // 11/16/06 12:08 am
//#define WC_VERSION_USER       "6.3"             // 05/04/08 01:46 am
//#define WC_VERSION_USER       "6.4"             // 06/23/11 02:17 am
//#define WC_VERSION_USER       "7.0"             // 05/27/12 05:18 am
//#define WC_VERSION_USER       "8.0"             // 03/15/19 12:12 am
#define WC_VERSION_USER       "10.0"              // 08/05/25 01:59 pm

//#define WC_VERSION_WORD       0x0506            // 450.8 06/20/2003, for wccdll.dll
//#define WC_VERSION_WORD       0x0507            // 450.9b2
//#define WC_VERSION_WORD       0x0600            // 03/14/04 06:42 am
//#define WC_VERSION_WORD       0x0601            // 03/29/05 10:23 am
//#define WC_VERSION_WORD       0x0602            // 11/16/06 12:08 am
//#define WC_VERSION_WORD       0x0603            // 05/04/08 01:47 am
//#define WC_VERSION_WORD       0x0604            // 06/23/11 02:17 am
//#define WC_VERSION_WORD       0x0700            // 05/27/12 05:18 am
//#define WC_VERSION_WORD       0x0800              // 03/15/19 12:12 am
#define WC_VERSION_WORD       0x0A00              // 08/05/25 01:59 pm

#define WC_DWORD_VERSION_WC5  0x00005000   // WC5 Makewild version
#define WC_DWORD_VERSION_WC55 0x00005050   // WC5 Makewild version
#define WC_DWORD_VERSION_WC56 0x00005060   // WC5.5 Makewild version
#define WC_DWORD_VERSION_WC6  0x00006000   // WC6 Makewild version
#define WC_DWORD_VERSION_WC57 0x00005070   // WC6 Makewild version // 450.9b7
#define WC_DWORD_VERSION_WC60 0x00006000   // WC6 Makewild version // 451.1
#define WC_DWORD_VERSION_WC61 0x00006010   // WC6 Makewild version // 451.4e
#define WC_DWORD_VERSION_WC62 0x00006020   // WC6 Makewild version // 452.1
#define WC_DWORD_VERSION_WC63 0x00006030   // WC6 Makewild version // 452.5c
#define WC_DWORD_VERSION_WC64 0x00006040   // WC6 Makewild version // 453.5T11
#define WC_DWORD_VERSION_WC70 0x00007000   // WC7 Makewild version // 454.4
#define WC_DWORD_VERSION_WC80 0x00008000   // WC8 Makewild version // 454.8
#define WC_DWORD_VERSION_WC100 0x0000A000   // WC10 Makewild version // 500.1

//#define WC_DWORD_VERSION      WC_DWORD_VERSION_WC56
//#define WC_DWORD_VERSION      WC_DWORD_VERSION_WC57  // 450.9b2
//#define WC_DWORD_VERSION      WC_DWORD_VERSION_WC60  // 450.9b2
//#define WC_DWORD_VERSION      WC_DWORD_VERSION_WC61  // 450.9b2
//#define WC_DWORD_VERSION      WC_DWORD_VERSION_WC63  // 452.5
//#define WC_DWORD_VERSION      WC_DWORD_VERSION_WC64  // 453.5T11
//#define WC_DWORD_VERSION      WC_DWORD_VERSION_WC70  // 454.4
//#define WC_DWORD_VERSION      WC_DWORD_VERSION_WC80    // 454.8
#define WC_DWORD_VERSION      WC_DWORD_VERSION_WC100    // 500.1

//------------------------------------------------------------------
// Sub-build numbers
//------------------------------------------------------------------

//#define WC_VERSION_REV     ".5"            // 12/11/02 12:19 am
//#define WC_VERSION_REV     ".6"            // 12/19/02 12:54 am
//#define WC_VERSION_REV     ".61"           // 02/26/03 12:17 pm for WCSMTP b21 fix
//#define WC_VERSION_REV     ".7"            // 02/24/03 08:31 pm
//#define WC_VERSION_REV     ".8"            // 06/20/2003 04:21pm
//#define WC_VERSION_REV     ".9"            // 08/09/03 07:22 pm
// Start of BUILD 451 03/14/04 02:25 am
//#define WC_VERSION_REV     ".1"            // 03/14/04 02:24 am
//#define WC_VERSION_REV     ".2"            // 05/14/04 11:51 pm
//#define WC_VERSION_REV     ".3"            // 10/20/04 8:58 pm
//#define WC_VERSION_REV     ".4"            // 03/01/2005 12:30am
//#define WC_VERSION_REV     ".5"            // 05/13/2005 08:14am
//#define WC_VERSION_REV     ".6"            // 10/27/05 07:01 pm
//#define WC_VERSION_REV     ".7"            // 02/09/06 04:58 pm
//#define WC_VERSION_REV     ".8"            // 05/31/06 05:47pm
//#define WC_VERSION_REV     ".9"            // 09/28/06 07:21 pm
// Start of BUILD 452 11/16/06 12:11 am
//#define WC_VERSION_REV     ".1"            // 11/16/06 12:11 am
//#define WC_VERSION_REV     ".2"            // 05/23/07 07:54 am
//#define WC_VERSION_REV     ".3"            // 06/14/07 08:47 pm
//#define WC_VERSION_REV     ".4"            // 11/04/07 07:43 pm
//#define WC_VERSION_REV     ".5"            // 02/05/08 03:30 am
//#define WC_VERSION_REV     ".6"            // 08/18/08 04:15 am
//#define WC_VERSION_REV     ".7"            // 11/04/08 05:02 am
//#define WC_VERSION_REV     ".8"            // 12/31/08 11:55 pm
//#define WC_VERSION_REV     ".9"            // 03/01/09 12:09 am
// Start of BUILD 453 07/00/09 04:32 pm
//#define WC_VERSION_REV     ".1"            // 07/00/09 04:32 pm (453.1)
//#define WC_VERSION_REV     ".2"            // 07/28/09 05:00 am (453.2)
//#define WC_VERSION_REV     ".3"            // 12/11/09 07:00 am (453.3)
//#define WC_VERSION_REV     ".4"            // 08/06/10 09:39 am (453.4)
//#define WC_VERSION_REV     ".5"              // 09/26/10 01:42 pm (453.5)
// Start of BUILD 454 06/23/11 02:25 am
//#define WC_VERSION_REV     ".1"              // 06/23/11 02:25 am (6.4.454.1)
//#define WC_VERSION_REV     ".2"              // 10/31/11 03:37 am (6.4.454.2)
//#define WC_VERSION_REV     ".3"              //11/30/11 01:25 am  (6.4.454.3)
//#define WC_VERSION_REV     ".4"              // 05/13/12 01:53 pm (6.4.454.4) pre-release
//#define WC_VERSION_REV     ".5"              // 12/14/15 10:11 pm pm(7.0.454.5)
//#define WC_VERSION_REV     ".6"              // 11/15/16 07:16 am (7.0.454.6)
//#define WC_VERSION_REV     ".7"              // 02/20/19 12:43 pm (7.0.454.7)
//#define WC_VERSION_REV     ".8"              // 03/15/19 12:13 am
//#define WC_VERSION_REV     ".9"              // 08/19/2019 05:13pm
//#define WC_VERSION_REV     ".10"               // 10/29/19 08:43 am
//#define WC_VERSION_REV     ".12"               // 04/08/21 02:19 pm (8.0.454.12)
//#define WC_VERSION_REV     ".13"               // 02/25/23 01:31 pm (8.0.454.13)
//#define WC_VERSION_REV     ".14"               // 11/01/23 08:05 am (8.0.454.14)
//#define WC_VERSION_REV     ".15"               // 07/17/24 01:41 pm (8.0.454.15)
//#define WC_VERSION_REV     ".16"               // 10/25/24 03:46 pm (8.0.454.16)
// Start of BUILD 500 08/05/25 02:06 pm
#define WC_VERSION_REV     ".1"               // 08/05/25 02:03 pm (10.0.500.1)

//------------------------------------------------------------------
// Beta versions
//------------------------------------------------------------------

#ifdef _DEBUG
#define WC_VERSION_BETA    "B1"
#else
#define WC_VERSION_BETA    ""
#endif

//##################################################################
// DO NOT CHANGE - except to change the date of the copyright
//##################################################################

#define WC_COPYRIGHT_LONG  "(c) copyright 1998-2026 by Santronics Software Inc."
#define WC_COPYRIGHT_SHORT "(c) 1998-2026 SSI"
#define WC_BUILD_DATE      __DATE__
#define WC_BUILD_TIME      __TIME__
#if _MFC_VER == 0x0600
#define WC_COMPILER         "VC6"
#else
//#define WC_COMPILER         "VC10+"
#define WC_COMPILER         "VC15+"
#endif

//
// example output:  v5.2.447b6
// example output:  v6.4.454.1
// example output:  v8.0.454.14
//

#define WC_VERSION "v" WC_VERSION_USER "." WC_VERSION_BUILD "" WC_VERSION_REV "" WC_VERSION_BETA

#ifdef _WIN64
#	define WC_VERSION_STR  WC_VERSION " (x64)"
#else
#	define WC_VERSION_STR  WC_VERSION
#endif

#if !defined(__WCVERSION_H)
#include "wcversion.h"
#endif

#endif

