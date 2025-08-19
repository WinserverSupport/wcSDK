//************************************************************************
// (c) Copyright 1999-2026 Santronics Software, Inc. All Rights Reserved.
//************************************************************************
//
// File Name : build.h
// Created   : 07/14/99 11:19 pm
// Programmer: SSI
// Original  : none. Use to be dynamically created
//
//
// Use this header to define the BUILD GLOBAL constant.
//
// Revision History:
// Build  Date     Author  Comments
// -----  -------- ------  -------------------------------
// 447B4  07/14/99 HLS     Created. Backup made as BUILD.H.ORIG just
//                         in case an accidental overwrite by an older
//                         mkall.cmd occurs.
// 449    04/10/00 HLS     Changed to 449
// 450    12/05/01 HLS     Changed to 450
// 451    03/14/04 HLS     Changed to 451
// 452    11/16/06 HLS     Changed to 452
// 453    07/09/09 HLS     Changed to 453.1
// 454    06/23/11 HLS     Changed to 454.1  (last 453.5T10)
// 500    08/05/25 HLS     Start of Build 500
//*******************************************************************

#ifndef __WCBUILD_H
#define __WCBUILD_H

// This constant should be part of all builds, including releases

const DWORD WILDCAT_FRAMEWORK_BUILD = 500;
#define WC_VERSION_BUILD   "500"

#endif
