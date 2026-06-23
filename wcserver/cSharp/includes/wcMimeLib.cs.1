//***********************************************************************
// (c) Copyright 1998-2019 Santronics Software, Inc. All Rights Reserved.
//***********************************************************************
//
// File Name : wcMimeLib.cs
// Subsystem : Wildcat! C# .NET SDK
// Version   : 8.0.454.8
// Author    : SSI
// About     : C# API for MIMELIB.DLL
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
    public static class wcMimeLib
    {

        public const int MAX_PATH = 260;

        ////***********************************************************************
        //// (c) Copyright 1998-2001 Santronics Software, Inc. All Rights Reserved.
        //// This WCBASIC source is copyrighted by Santronics Software Inc. Any
        //// modification made must retrained this copyright information.
        ////-----------------------------------------------------------------------
        //// File Name : mimelib.wch
        //// Subsystem : mimelib.dll wcBASIC protocol header file
        //// Date      : 07/11/2001
        //// Author    : SSI
        ////
        //// Revision History:
        //// Build  Date      Author  Comments
        //// -----  --------  ------  ---------------------------------------------
        ////***********************************************************************

        ///////////////////////////////////////////////////////////////////////////
        //// How to use mimelib.wch:
        ////
        //// The purpose of mimelib is to parse a Wildcat! message which may or
        //// may not be in RFC MIME multipart format and break up the mail parts
        //// into temporary files in the wcBASIC session TempPath directory.
        ////
        //// NEW 450.3! If you are using mimelib from outside wcBASIC, see
        ////            the new CreateMimeObjectEx() function describing
        ////            the issue with the work path.
        ////
        //// First, use CreateMimeObject() to create a "mime object" giving
        //// it the msg conference and msg id numbers.  You can also tell it
        //// which part (text or html) you want to save in the temporary
        //// file called; tempPath+"mimemail.dat"
        ////
        ////    dim mobj as long = CreateMimeObject(conf,msgid,"html")
        ////
        //// This will allow you to read this file using the GetLocalText()
        //// function (msgutil.wch)
        ////
        ////    dim body as string = GetLocalText(TempPath+"MimeMail.Dat")
        ////
        //// If no "html" part was found, then all text parts will be
        //// saved in TempPath+"mimemail.dat".
        ////
        //// If there are other parts in the messages, you can use the
        //// GetMimePartsCount() function to get the total number of parts.
        ////
        //// Use the GetMimeAttachmentCount() function to find out if there
        //// any mime attachments (not wildcat attachments) in the message.
        ////
        //// Then use the various Get/Find Attachment functions to extract
        //// file information.
        ////
        //// When you are finished, you must call DeleteMimeObject() to delete
        //// the mime object.
        ////
        ////   DeleteMimeObject(mobj)
        ////
        ///////////////////////////////////////////////////////////////////////////

        ////#include "windows.wch"
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct TMimeAttachmentInfo
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string tempName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string RealName;
            public long size;
            public FILETIME datetime;
        }

        ////---------------------------------------------------------------------
        //// CreateMimeObject()
        ////
        //// Pass the msgarea and msgid and the part "html" or "text" to
        //// create a mime message object.
        ////
        //// If successful, the function returns a non-zero object number and
        //// the message mime parts be stored in the TempPath directory.
        ////
        //// If not successful, the function returns zero (0).
        ////
        //// The object must be deleted using DeleteMimeObject() when you
        //// are done using the object.
        ////---------------------------------------------------------------------
        [DllImport("mimelib.dll", SetLastError = true)]
        public extern static long CreateMimeObject(long msgarea, long msgid, string part);

        ////---------------------------------------------------------------------
        //// NEW 450.3
        //// CreateMimeObjectEx()
        ////
        //// Similar to CreateMimeObject(), this extended function allows
        //// the work path to be defined by the calling process.
        ////
        //// By default, CreateMimeObject() assumes the "wcwork\nodeX"
        //// work path to store the mime message file parts.
        ////
        //// If mimelib is being used by a wcBASIC application for a
        //// logged in session, you don't need to use the extended function.
        //// The wcBASIC core engine will automatically create the work path
        //// for the current node.
        ////
        //// On the other hand, if mimelib is being used by external applets
        //// (i.e, Visual Basic), you can use the extended function to defined
        //// a work path.  You need to create this work path and clean it up
        //// yourself.
        ////
        ////      myCreateWorkPathFunction("myWorkPath\")
        ////      mobj = CreateMimeObjectEx(mh.conference,mh.id,"html","myWorkPath\")
        ////      myDeleteWorkPathFunction("myWorkPath\")
        ////
        //// Note: If mimelib is being used with a wcBASIC application for a
        //// non-node session, the wcBASIC core engine automatically creates
        //// and removes the specific work path "wcwork\node0".
        ////
        ////---------------------------------------------------------------------
        [DllImport("mimelib.dll", SetLastError = true)]
        public extern static long CreateMimeObjectEx(long msgarea, long msgid, string part, string path);

        ////---------------------------------------------------------------------
        //// DeleteMimeObject(obj)
        ////
        //// Deletes the mime object created with CreateMimeObject()
        ////---------------------------------------------------------------------
        [DllImport("mimelib.dll", SetLastError = true)]
        public extern static long DeleteMimeObject(long obj);

        ////---------------------------------------------------------------------
        //// GetMimePartsCount()
        ////
        //// Returns the numbers of mime parts to the messages.  There should
        //// always be atleast 1 part (tempPath+"MimeMail.dat") which means
        //// the message was probably not a RFC MIME based message.
        ////---------------------------------------------------------------------
        [DllImport("mimelib.dll", SetLastError = true)]
        public extern static long GetMimePartsCount(long obj);

        /////////////////////////////////////////////////////////////////////////
        //// GetMimeAttachmentCount()
        ////
        //// Returns the numbers of attachments in the messages.
        [DllImport("mimelib.dll", SetLastError = true)]
        public extern static long GetMimeAttachmentCount(long obj);

        /////////////////////////////////////////////////////////////////////////
        //// GetMimeAttachmentName(obj, idx, realname)
        ////
        //// Gets the real name of the attachment by its attachment index.
        ////
        //// Return TRUE if the mime attachment part was found.
        //// Return FALSE if the obj was invalid or the index was not found.
        ////
        //// Note: Attachments are stored in the tempPath under their
        //// temporary file name.
        [DllImport("mimelib.dll", SetLastError = true)]
        public extern static bool GetMimeAttachmentName(long obj, long idx, long pszRealName);

        ////---------------------------------------------------------------------
        //// GetMimeAttachmentInfo()
        ////
        //// Get the TMimeAttachmentInfo Structure of the attachment by
        //// attachment index, 1 to GetMimeAttachmentTotal().
        ////
        //// Return TRUE if found, otherwise FALSE
        ////---------------------------------------------------------------------
        [DllImport("mimelib.dll", SetLastError = true)]
        public extern static bool GetMimeAttachmentInfo(long obj, long idx, TMimeAttachmentInfo info);

        ////---------------------------------------------------------------------
        //// FindMimeAttachmentTempName()
        ////
        //// Searches for the real name in the list of attachments and
        //// gets the name of the temporary file in the TempPath directory.
        ////
        //// If found, returns the attachment index otherwise return 0.
        ////
        ////---------------------------------------------------------------------
        [DllImport("mimelib.dll", SetLastError = true)]
        public extern static long FindMimeAttachmentTempName(long obj, string RealName, long pszTempName);

        ////---------------------------------------------------------------------
        //// FindMimeAttachmentIndex()
        ////
        //// Searches for the real name in the list of attachments and
        //// returns the attachment index. If not found, return 0.
        ////
        //// Optional CopyPath:  If the location CopyPath is non blank,
        //// the attachment will be copied to this location.
        ////---------------------------------------------------------------------
        [DllImport("mimelib.dll", SetLastError = true)]
        public extern static long FindMimeAttachmentIndex(long obj, string RealName, string Copypath);

        ////---------------------------------------------------------------------
        //// CreateMimeObjectWorkPath(workpath)
        //// DeleteMimeObjectWorkPath(workpath)
        ////
        //// These functions are used to create and remove the work path
        //// where MIMELIB will place the mime file part when you call
        //// CreateMimeObjectEx().
        ////
        //// You don't need to call these functions if you are using wcBASIC
        //// since the work path is always managed by the wcBASIC core engine.
        //// Outside of wcBASIC, you can create and  remove your own work path
        //// or use this helper functions.
        ////
        //// See the extended function CreateMimeObjectEx()
        ////
        //// Example usage:
        ////
        ////   CreateMimeObjectWorkPath("myWorkPath\");
        ////   mobj = CreateMimeObjectEx(mh.conference,mh.id,"html","myWorkPath\")
        ////   ...
        ////   DeleteMimeObject(mobj)
        ////   DeleteMimeObjectWorkPath("myWorkPath\");
        ////
        //// WARNING: Be careful with DeleteMimeObjectWorkPath()! It will DELETE
        //// all the files in the directory before removing the directory if the
        //// parameter FilesToo is passed as TRUE.  Technically, you should pass
        //// FALSE because when you delete the mime object (DeleteMimeObject)
        //// the temporary mime file parts are automatically deleted.  So by the
        //// time you call DeleteMimeObjectWorkPath() there should be an empty
        //// directory.
        ////
        ////---------------------------------------------------------------------
        [DllImport("mimelib.dll", SetLastError = true)]
        public extern static bool CreateMimeObjectWorkPath(string workpath);

        [DllImport("mimelib.dll", SetLastError = true)]
        public extern static void DeleteMimeObjectWorkPath(string workpath, long filesToo);

    }

} //end of root namespace
